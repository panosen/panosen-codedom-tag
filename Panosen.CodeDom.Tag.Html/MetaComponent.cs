using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MetaComponent 关于 HTML 文档的元信息
    /// </summary>
    public class MetaComponent : HtmlComponent
    {

        /// <summary>
        /// meta
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Meta;

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
