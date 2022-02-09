using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SvgComponent  SVG 图形的容器
    /// </summary>
    public class SvgComponent : HtmlComponent
    {

        /// <summary>
        /// svg
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Svg;
    }
}
