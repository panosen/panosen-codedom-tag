using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// BlockquoteComponent 长的引用
    /// </summary>
    public class BlockquoteComponent : HtmlComponent
    {

        /// <summary>
        /// blockquote
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Blockquote;
    }
}
