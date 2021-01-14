using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectum.FormItems
{
    /// <summary>
    /// Наполнитель.
    /// </summary>
    [Serializable()]
    public class Filler : IStorable
    {
        /// <summary>
        /// Содержит размещаемый контент.
        /// </summary>
        public string Message { get; set; }

        FormElementType IStorable.Type
        {
            get
            {
                return FormElementType.Filler;
            }
        }
    }
}
