using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// HeaderComponent  section ๆ page ็้กต็
    /// </summary>
    public class HeaderComponent : HtmlComponent
    {

        /// <summary>
        /// header
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Header;
    }
}
