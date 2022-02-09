using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// H1Component  HTML 标题
    /// </summary>
    public class H1Component : HtmlComponent
    {

        /// <summary>
        /// h1
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.H1;
    }
}
