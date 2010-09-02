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

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Koffeinfrei.BatchReplacer
{
    [XmlType("rules")]
    [XmlRoot("rules")]
    public class Rules : List<Rule>
    {
        /// <summary>
        /// Loads (i.e. deserializes) the specified file and returns a <see cref="Rules"/> instance.
        /// </summary>
        /// <param name="file">The xml file.</param>
        /// <returns>The <see cref="Rules"/> instance representing the contents of the specified <paramref name="file"/>.</returns>
        public static Rules Load(string file)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Rules));
            Rules rules;
            using (TextReader textReader = new StreamReader(file, Encoding.UTF8))
            {
                rules = (Rules)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            return rules;
        }

        /// <summary>
        /// Saves (i.e. serializes) this instance to the <see cref="File"/>.
        /// </summary>
        /// <param name="file">The file.</param>
        public void Save(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Rules));
            using (TextWriter textWriter = new StreamWriter(file, false, Encoding.UTF8))
            {
                serializer.Serialize(textWriter, this);
                textWriter.Close();
            }
        }
    }
}
