using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// InputComponent 输入控件
    /// </summary>
    public class InputComponent : HtmlComponent
    {

        /// <summary>
        /// input
        /// </summary>
        public override string Name { get; set; } = "input";

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
