using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// FooterComponent  section ๆ page ็้กต่
    /// </summary>
    public class FooterComponent : HtmlComponent
    {

        /// <summary>
        /// footer
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Footer;
    }
}
