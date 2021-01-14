using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectum
{
    /// <summary>
    /// Блок формы.
    /// </summary>
    public class FormGeneratorData
    {
        /// <summary>
        /// Имя формы.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Массив элементов формы.
        /// </summary>
        public object[] Items { get; set; }
        /// <summary>
        /// Сообщение в случае успешного взаимодействия.
        /// </summary>
        public string Postmessage { get; set; }
    }
}
