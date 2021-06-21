using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{
    /// <summary>
    /// MetaComponent
    /// </summary>
    public class MetaComponent : HtmlComponent
    {
        /// <summary>
        /// Name
        /// </summary>
        public override string Name { get; set; } = "meta";

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
