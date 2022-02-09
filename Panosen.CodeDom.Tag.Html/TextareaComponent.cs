using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TextareaComponent 多行的文本输入控件
    /// </summary>
    public class TextareaComponent : HtmlComponent
    {

        /// <summary>
        /// textarea
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Textarea;
    }
}
