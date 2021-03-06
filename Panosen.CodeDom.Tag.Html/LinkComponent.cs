using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// LinkComponent 文档与外部资源的关系
    /// </summary>
    public class LinkComponent : HtmlComponent
    {

        /// <summary>
        /// link
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Link;

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
