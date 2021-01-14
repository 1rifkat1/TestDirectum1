using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectum.FormItems
{
    /// <summary>
    /// Список выпадающих значений.
    /// </summary>
    class Option
    {
        /// <summary>
        /// Значение элемента списка.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Текст элемента списка.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Активен или нет элемент по умолчанию, принимает значение true / false.
        /// </summary>
        public bool Selected { get; set; }

    }
}
