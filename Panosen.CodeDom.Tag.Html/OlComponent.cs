using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// OlComponent 有序列表
    /// </summary>
    public class OlComponent : HtmlComponent
    {

        /// <summary>
        /// ol
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Ol;
    }
}
