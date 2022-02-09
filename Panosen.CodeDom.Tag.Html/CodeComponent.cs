using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// CodeComponent 计算机代码文本
    /// </summary>
    public class CodeComponent : HtmlComponent
    {

        /// <summary>
        /// code
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Code;
    }
}
