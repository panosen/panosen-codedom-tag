using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// IframeComponent 内联框架
    /// </summary>
    public class IframeComponent : HtmlComponent
    {

        /// <summary>
        /// iframe
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Iframe;
    }
}
