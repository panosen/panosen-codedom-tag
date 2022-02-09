using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// NavComponent 导航链接
    /// </summary>
    public class NavComponent : HtmlComponent
    {

        /// <summary>
        /// nav
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Nav;
    }
}
