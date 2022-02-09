using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TitleComponent 文档的标题
    /// </summary>
    public class TitleComponent : HtmlComponent
    {

        /// <summary>
        /// title
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Title;
    }
}
