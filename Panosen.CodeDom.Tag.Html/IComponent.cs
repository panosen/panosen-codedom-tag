using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// IComponent 斜体字
    /// </summary>
    public class IComponent : HtmlComponent
    {

        /// <summary>
        /// i
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.I;
    }
}
