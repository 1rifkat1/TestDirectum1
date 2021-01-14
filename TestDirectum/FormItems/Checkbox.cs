using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectum.FormItems
{
    class Checkbox : IStorable
    {
        /// <summary>
        /// Имя элемента.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Плейсхолдер.
        /// </summary>
        public string Placeholder { get; set; }
        /// <summary>
        /// Свойство, указывающее на обязательность заполнения элемента, принимает значения true / false.
        /// </summary>
        public bool Required { get; set; }
        /// <summary>
        /// Тип проверки.
        /// </summary>
        public ValidationRule Type { get; set; }
        /// <summary>
        /// Предустановленное значение элемента.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Описание поля.
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// css-класс элемента.
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// Активен или нет элемент.
        /// </summary>
        public bool Disabled { get; set; }
        /// <summary>
        /// Состояние флажка.
        /// </summary>
        public bool Checked { get; set; }
        /// <summary>
        /// Поле для выбора.
        /// </summary>
        FormElementType IStorable.Type
        {
            get
            {
                return FormElementType.Checkbox;
            }
        }
    }
}
