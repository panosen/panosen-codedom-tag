using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// H2Component  HTML 标题
    /// </summary>
    public class H2Component : HtmlComponent
    {

        /// <summary>
        /// h2
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.H2;
    }
}
