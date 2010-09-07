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

namespace Koffeinfrei.BatchReplacer
{
    public static class StringReplacer
    {
        public static string Replace(string input, string search, string replace, bool ignoreCase)
        {
            if (input.Length == 0 || search.Length == 0 || search.Length > input.Length)
            {
                return input;
            }

            // use the framework method if the case is required
            if (!ignoreCase)
            {
                return input.Replace(search, replace);
            }

            StringBuilder result = new StringBuilder(input.Length);

            int pos = 0;
            while (pos + search.Length <= input.Length)
            {
                if (string.Compare(input, pos, search, 0, search.Length, true) == 0)
                {
                    // add the replaced string
                    result.Append(replace);
                    pos += search.Length;
                }
                else
                {
                    // advance one character
                    result.Append(input, pos++, 1);
                }
            }

            // append remaining characters
            result.Append(input, pos, input.Length - pos);

            return result.ToString();
        }
    }
}
