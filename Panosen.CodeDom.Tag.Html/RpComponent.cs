using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// RpComponent 若浏览器不支持 ruby 元素显示的内容
    /// </summary>
    public class RpComponent : HtmlComponent
    {

        /// <summary>
        /// rp
        /// </summary>
        public override string Name { get; set; } = "rp";
    }
}
