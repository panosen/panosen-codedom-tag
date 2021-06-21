using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{
    /// <summary>
    /// BaseComponent
    /// </summary>
    public class BaseComponent : HtmlComponent
    {
        /// <summary>
        /// Name
        /// </summary>
        public override string Name { get; set; } = "base";

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
