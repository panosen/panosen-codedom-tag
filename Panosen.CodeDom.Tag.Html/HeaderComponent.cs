using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// HeaderComponent  section 或 page 的页眉
    /// </summary>
    public class HeaderComponent : HtmlComponent
    {

        /// <summary>
        /// header
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Header;
    }
}
