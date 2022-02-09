using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// NoscriptComponent 针对不支持客户端脚本的用户的替代内容
    /// </summary>
    public class NoscriptComponent : HtmlComponent
    {

        /// <summary>
        /// noscript
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Noscript;
    }
}
