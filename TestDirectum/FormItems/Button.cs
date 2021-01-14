using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectum.FormItems
{/// <summary>
/// Кнопка.
/// </summary>
    public class Button : IStorable
    {
        /// <summary>
        /// css-класс кнопки.
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// Текст кнопки.
        /// </summary>
        public string Text { get; set; }

        FormElementType IStorable.Type
        {
            get
            {
                return FormElementType.Button;
            }
        }
    }
}
