using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// FooterComponent  section 或 page 的页脚
    /// </summary>
    public class FooterComponent : HtmlComponent
    {

        /// <summary>
        /// footer
        /// </summary>
        public override string Name { get; set; } = "footer";
    }
}
