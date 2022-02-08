using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// BrComponent 简单的折行
    /// </summary>
    public class BrComponent : HtmlComponent
    {

        /// <summary>
        /// br
        /// </summary>
        public override string Name { get; set; } = "br";

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
