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

using System.Text.RegularExpressions;
using Koffeinfrei.BatchReplacer.Model.Entities;

namespace Koffeinfrei.BatchReplacer.Model
{
    public static class RegexReplacer
    {
        public static SingleReport Replace(string input, string search, string replace, bool ignoreCase)
        {
            SingleReport singleReport = new SingleReport();

            MatchCollection matches = ignoreCase ? 
                Regex.Matches(input, search, RegexOptions.IgnoreCase) :
                Regex.Matches(input, search);

            singleReport.Matches = matches.Count;
            
            if (matches.Count == 0)
            {
                singleReport.Text = input;
            }
            else
            {
                singleReport.Text = ignoreCase ? 
                    Regex.Replace(input, search, replace, RegexOptions.IgnoreCase) : 
                    Regex.Replace(input, search, replace);
            }

            return singleReport;
        }
    }
}
