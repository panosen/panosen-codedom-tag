using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// EmbedComponent 外部交互内容或插件
    /// </summary>
    public class EmbedComponent : HtmlComponent
    {

        /// <summary>
        /// embed
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Embed;
    }
}
