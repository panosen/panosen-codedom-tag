using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// KbdComponent 键盘文本
    /// </summary>
    public class KbdComponent : HtmlComponent
    {

        /// <summary>
        /// kbd
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Kbd;
    }
}
