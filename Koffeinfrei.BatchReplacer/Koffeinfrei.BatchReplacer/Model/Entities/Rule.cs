﻿//  Koffeinfrei Batch Replacer
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

using System.Xml.Serialization;

namespace Koffeinfrei.BatchReplacer.Model.Entities
{
    [XmlType("rule")]
    public class Rule
    {
        public enum ModeType
        {
            [XmlEnum("normal")]
            Normal,
            [XmlEnum("normal-ignorecase")]
            NormalIgnoreCase,
            [XmlEnum("regex")]
            Regex,
            [XmlEnum("regex-ignorecase")]
            RegexIgnoreCase
        }

        [XmlElement("search")]
        public string Search { get; set; }
        [XmlElement("replace")]
        public string Replace { get; set; }
        [XmlAttribute("mode")]
        public ModeType Mode { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is empty.
        /// If <see cref="Search"/> and <see cref="Replace"/>
        /// are null or empty, this rule is considered empty.
        /// </summary>
        /// <returns>&lt;c&gt;true&lt;/c&gt; if this instance is empty; otherwise, &lt;c&gt;false&lt;/c&gt;.</returns>
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Search) && string.IsNullOrEmpty(Replace);
        }
    }
}
