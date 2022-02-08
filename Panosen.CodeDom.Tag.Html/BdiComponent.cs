using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// BdiComponent 文本的文本方向，使其脱离其周围文本的方向设置
    /// </summary>
    public class BdiComponent : HtmlComponent
    {

        /// <summary>
        /// bdi
        /// </summary>
        public override string Name { get; set; } = "bdi";
    }
}
