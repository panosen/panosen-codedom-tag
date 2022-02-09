using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// H3Component  HTML 标题
    /// </summary>
    public class H3Component : HtmlComponent
    {

        /// <summary>
        /// h3
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.H3;
    }
}
