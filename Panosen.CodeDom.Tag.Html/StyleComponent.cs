using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// StyleComponent 文档的样式信息
    /// </summary>
    public class StyleComponent : HtmlComponent
    {

        /// <summary>
        /// style
        /// </summary>
        public override string Name { get; set; } = "style";
    }
}
