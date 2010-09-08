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

using System.IO;
using Koffeinfrei.BatchReplacer.View;

namespace Koffeinfrei.BatchReplacer.Model.Entities
{
    public class ReplacableFile
    {
        public FileInfo Info { get; set; }

        public string Name
        {
            get { return Info.Name; }
        }

        public long SizeBefore
        {
            get { return Info.Length; }
        }
        
        public string SizeBeforeFormatted
        {
            get { return SizeBefore == 0 ? "" : SizeBefore.ToFileSize(); }
        }

        public long SizeAfter { get; set; }

        public string SizeAfterFormated
        {
            get { return SizeAfter == 0 ? "" : SizeAfter.ToFileSize(); }
        }

        public int Matches { get; set; }

        public bool Done { get; set; }

        public bool? Success
        {
            get { return !Done ? (bool?) null : Error == null; }
        }
        
        public string Error { get; set; }

        public string OriginalContent { get; set; }


        private string replacedContent;

        public string ReplacedContent
        {
            get
            {
                if (replacedContent == null)
                {
                    return OriginalContent;
                }
                return replacedContent;
            }
            set { replacedContent = value; }
        }

        public ReplacableFile(string path)
        {
            Info = new FileInfo(path);
        }

        public void LoadContentFromFile()
        {
            OriginalContent = File.ReadAllText(Info.FullName);
        }

        public void SaveContentToFile(string path)
        {
            File.WriteAllText(path, ReplacedContent);

            // TODO verify that this is the size of the file also, depending on encoding
            SizeAfter = replacedContent.ToCharArray().Length;
        }
    }
}
