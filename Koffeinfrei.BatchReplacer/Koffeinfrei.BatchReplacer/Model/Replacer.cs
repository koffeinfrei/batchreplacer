//  Koffeinfrei Batch Replacer
//  Copyright (C) 2010  Alexis Reigel
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using Koffeinfrei.BatchReplacer.Model.Entities;

namespace Koffeinfrei.BatchReplacer.Model
{
    public class Replacer
    {
        public Rules Rules { get; set; }

        public ReplacableFiles InputFiles { get; set; }

        public string OutputDirectoryName { get; set; }

        public bool IsReady
        {
            get
            {
                return InputFiles != null && InputFiles.Count > 0 &&
                       Rules != null && !Rules.IsEmpty() &&
                       !string.IsNullOrEmpty(OutputDirectoryName);
            }
        }

        public OverallReport Report { get; private set; }

        /// <summary>
        /// Starts the and report progress. The progress is reported as percent
        /// between 0 and 100.
        /// </summary>
        /// <returns>An enumerator over the progress in percent 0 - 100</returns>
        public IEnumerable<int> StartAndReportProgress()
        {
            if (!IsReady)
            {
                throw new ApplicationException("Not all required properties are set.");
            }

            string outputDirectory = Path.Combine(
                InputFiles[0].Info.DirectoryName, OutputDirectoryName);

            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            Report = new OverallReport();

            // TODO check if fileName is not null or empty)
            for (int i = 0; i < InputFiles.Count; ++i)
            {
                try
                {
                    FileInfo sourceFile = InputFiles[i].Info;

                    InputFiles[i].LoadContentFromFile();

                    foreach (Rule rule in Rules)
                    {
                        SingleReport singleReport = Replace(InputFiles[i].ReplacedContent, rule);
                        InputFiles[i].ReplacedContent = singleReport.Text;
                        InputFiles[i].Matches += singleReport.Matches;

                        Report.Matches += singleReport.Matches;
                    }

                    InputFiles[i].SaveContentToFile(
                        Path.Combine(sourceFile.DirectoryName, outputDirectory, sourceFile.Name));
                }
                catch (Exception e)
                {
                    InputFiles[i].Error = e.Message;
                    Report.Errors.Add(e.Message);
                }

                InputFiles[i].Done = true;

                yield return (int)((i + 1) * 1.0 / (InputFiles.Count) * 100);
            }
        }

        private static SingleReport Replace(string input, Rule rule)
        {
            switch (rule.Mode)
            {
                case Rule.ModeType.Regex:
                    return RegexReplacer.Replace(input, rule.Search, rule.Replace, false);
                case Rule.ModeType.RegexIgnoreCase:
                    return RegexReplacer.Replace(input, rule.Search, rule.Replace, true);
                case Rule.ModeType.Normal:
                    return StringReplacer.Replace(input, rule.Search, rule.Replace, false);
                case Rule.ModeType.NormalIgnoreCase:
                default:
                    return StringReplacer.Replace(input, rule.Search, rule.Replace, true);
            }
        }
    }
}