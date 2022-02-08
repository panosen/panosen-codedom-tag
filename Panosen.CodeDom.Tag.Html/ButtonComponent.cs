using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ButtonComponent 按钮 (push button)
    /// </summary>
    public class ButtonComponent : HtmlComponent
    {

        /// <summary>
        /// button
        /// </summary>
        public override string Name { get; set; } = "button";
    }
}
