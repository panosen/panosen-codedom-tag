using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// OptionComponent 选择列表中的选项
    /// </summary>
    public class OptionComponent : HtmlComponent
    {

        /// <summary>
        /// option
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Option;
    }
}
