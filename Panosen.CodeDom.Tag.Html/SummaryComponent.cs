using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SummaryComponent 为 &lt;details&gt; 元素定义可见的标题
    /// </summary>
    public class SummaryComponent : HtmlComponent
    {

        /// <summary>
        /// summary
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Summary;
    }
}
