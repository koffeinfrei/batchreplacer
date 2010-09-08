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

using System.Drawing;
using System.Windows.Forms;

namespace Koffeinfrei.BatchReplacer.View
{
    /// <summary>
    /// This is a datagridview column that displays an image (<see cref="Bitmap"/> 
    /// depending on the value of a <c>bool?</c> field.
    /// </summary>
    /// <seealso cref="DataGridViewSuccessImageCell"/>.
    public class DataGridViewSuccessImageColumn : DataGridViewImageColumn
    {
        public DataGridViewSuccessImageColumn()
        {
            CellTemplate = new DataGridViewSuccessImageCell();
        }
    }
}
