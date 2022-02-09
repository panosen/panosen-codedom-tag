using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MarkComponent 有记号的文本
    /// </summary>
    public class MarkComponent : HtmlComponent
    {

        /// <summary>
        /// mark
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Mark;
    }
}
