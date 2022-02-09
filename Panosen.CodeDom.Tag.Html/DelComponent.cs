using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// DelComponent 被删除文本
    /// </summary>
    public class DelComponent : HtmlComponent
    {

        /// <summary>
        /// del
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Del;
    }
}
