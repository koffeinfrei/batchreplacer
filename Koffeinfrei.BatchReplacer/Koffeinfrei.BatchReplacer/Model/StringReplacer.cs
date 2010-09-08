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

using System.Text;
using Koffeinfrei.BatchReplacer.Model.Entities;

namespace Koffeinfrei.BatchReplacer.Model
{
    /// <summary>
    /// Allows to replace occurences in a string both case sensitive and case insensitive.
    /// </summary>
    /// <remarks>credits to http://blogs.msdn.com/b/btine/archive/2005/03/22/400667.aspx</remarks>
    public static class StringReplacer
    {
        public static SingleReport Replace(string input, string search, string replace, bool ignoreCase)
        {
            SingleReport singleReport = new SingleReport();

            if (input.Length == 0 || search.Length == 0 || search.Length > input.Length)
            {
                singleReport.Text = input;
            }
            else
            {
                StringBuilder resultString = new StringBuilder(input.Length);

                int pos = 0;
                while (pos + search.Length <= input.Length)
                {
                    if (string.Compare(input, pos, search, 0, search.Length, ignoreCase) == 0)
                    {
                        // add the replaced string
                        resultString.Append(replace);
                        pos += search.Length;

                        ++singleReport.Matches;
                    }
                    else
                    {
                        // advance one character
                        resultString.Append(input, pos++, 1);
                    }
                }

                // append remaining characters
                resultString.Append(input, pos, input.Length - pos);

                singleReport.Text = resultString.ToString();
            }

            return singleReport;
        }
    }
}
