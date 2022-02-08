using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// HrComponent 水平线
    /// </summary>
    public class HrComponent : HtmlComponent
    {

        /// <summary>
        /// hr
        /// </summary>
        public override string Name { get; set; } = "hr";

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
