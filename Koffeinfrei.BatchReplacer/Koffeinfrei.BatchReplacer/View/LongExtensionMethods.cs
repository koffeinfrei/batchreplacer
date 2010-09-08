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

namespace Koffeinfrei.BatchReplacer.View
{
    /// <summary>
    /// Provides extension methods for a <see cref="long"/> value.
    /// </summary>
    /// <remarks>credits to http://stackoverflow.com/questions/128618/c-file-size-format-provider</remarks>
    public static class LongExtensionMethods
    {
        public static string ToFileSize(this long value)
        {
            return String.Format(new FileSizeFormatProvider(), "{0:fs}", value);
        }

    }
}
