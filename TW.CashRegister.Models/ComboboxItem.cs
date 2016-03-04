using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// Combobox item.
    /// </summary>
    public class ComboboxItem
    {
        /// <summary>
        /// Show Text.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Indiacate value.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 输出文字
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text;
        }
    }
}
