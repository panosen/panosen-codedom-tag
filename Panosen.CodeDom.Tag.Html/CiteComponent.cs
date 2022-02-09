using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// CiteComponent 引用(citation)
    /// </summary>
    public class CiteComponent : HtmlComponent
    {

        /// <summary>
        /// cite
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Cite;
    }
}
