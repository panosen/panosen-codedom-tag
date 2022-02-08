using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// CaptionComponent 表格标题
    /// </summary>
    public class CaptionComponent : HtmlComponent
    {

        /// <summary>
        /// caption
        /// </summary>
        public override string Name { get; set; } = "caption";
    }
}
