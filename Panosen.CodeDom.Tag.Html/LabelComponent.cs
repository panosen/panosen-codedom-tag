using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// LabelComponent  input 元素的标注
    /// </summary>
    public class LabelComponent : HtmlComponent
    {

        /// <summary>
        /// label
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Label;
    }
}
