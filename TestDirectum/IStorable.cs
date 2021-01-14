using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectum
{
    /// <summary>
    /// Хранимые элементы формы.
    /// </summary>
    public interface IStorable
    {
        /// <summary>
        /// Тип элемента формы.
        /// </summary>
      FormElementType Type {get;}
    }

}
