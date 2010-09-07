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
using System.Linq;
using System.Text.RegularExpressions;

namespace Koffeinfrei.BatchReplacer
{
    public class Replacer
    {
        public Rules Rules { get; set; }

        public List<string> InputFiles { get; set; }

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
                new FileInfo(InputFiles[0]).DirectoryName, OutputDirectoryName);

            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // TODO check if fileName is not null or empty);
            //foreach (string fileName in inputFileNames)
            for (int i = 0; i < InputFiles.Count; ++i)
            {
                FileInfo sourceFile = new FileInfo(InputFiles[i]);

                string text = File.ReadAllText(sourceFile.FullName);

                text = Rules.Aggregate(text, Replace);

                File.WriteAllText(
                    Path.Combine(Path.Combine(sourceFile.DirectoryName, outputDirectory, sourceFile.Name)), text);

                yield return (int)((i+1) * 1.0 / (InputFiles.Count) * 100);
            }
        }

        private static string Replace(string input, Rule rule)
        {
            switch (rule.Mode)
            {
                case Rule.ModeType.Regex:
                    return Regex.Replace(input, rule.Search, rule.Replace);
                case Rule.ModeType.RegexIgnoreCase:
                    return Regex.Replace(input, rule.Search, rule.Replace, RegexOptions.IgnoreCase);
                case Rule.ModeType.Normal:
                    return StringReplacer.Replace(input, rule.Search, rule.Replace, false);
                case Rule.ModeType.NormalIgnoreCase:
                default:
                    return StringReplacer.Replace(input, rule.Search, rule.Replace, true);
            }
        }
    }
}