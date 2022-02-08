using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// FigcaptionComponent  figure 元素的标题
    /// </summary>
    public class FigcaptionComponent : HtmlComponent
    {

        /// <summary>
        /// figcaption
        /// </summary>
        public override string Name { get; set; } = "figcaption";
    }
}
