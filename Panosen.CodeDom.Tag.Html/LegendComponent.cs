using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// LegendComponent  fieldset 元素的标题
    /// </summary>
    public class LegendComponent : HtmlComponent
    {

        /// <summary>
        /// legend
        /// </summary>
        public override string Name { get; set; } = "legend";
    }
}
