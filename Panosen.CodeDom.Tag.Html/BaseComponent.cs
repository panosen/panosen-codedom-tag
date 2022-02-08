using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// BaseComponent 页面中所有链接的默认地址或默认目标
    /// </summary>
    public class BaseComponent : HtmlComponent
    {

        /// <summary>
        /// base
        /// </summary>
        public override string Name { get; set; } = "base";

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }
}
