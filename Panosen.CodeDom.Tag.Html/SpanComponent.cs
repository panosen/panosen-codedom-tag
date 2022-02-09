using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SpanComponent 文档中的节
    /// </summary>
    public class SpanComponent : HtmlComponent
    {

        /// <summary>
        /// span
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Span;
    }
}
