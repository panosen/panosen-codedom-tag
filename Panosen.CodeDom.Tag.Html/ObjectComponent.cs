using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ObjectComponent 内嵌对象
    /// </summary>
    public class ObjectComponent : HtmlComponent
    {

        /// <summary>
        /// object
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Object;
    }
}
