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
    /// This is a datagridview cell that displays an image (<see cref="Bitmap"/> 
    /// depending on the value of a <c>bool?</c> field.
    /// </summary>
    /// <seealso cref="DataGridViewSuccessImageColumn"/>
    public class DataGridViewSuccessImageCell : DataGridViewImageCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter valueTypeConverter, System.ComponentModel.TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            bool? boolValue = (bool?) value;
            object imageValue;
            if (boolValue.HasValue)
            {
                imageValue = boolValue.Value ? Properties.Resources.success : Properties.Resources.error;
            }
            else
            {
                imageValue = null;
                cellStyle.NullValue = null;
            }
            return base.GetFormattedValue(imageValue, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
        }
    }
}
