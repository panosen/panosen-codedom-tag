using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// HeadComponent 关于文档的信息
    /// </summary>
    public class HeadComponent : HtmlComponent
    {

        /// <summary>
        /// head
        /// </summary>
        public override string Name { get; set; } = "head";
    }
}
