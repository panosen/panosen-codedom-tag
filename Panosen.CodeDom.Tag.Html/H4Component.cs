using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// H4Component  HTML 标题
    /// </summary>
    public class H4Component : HtmlComponent
    {

        /// <summary>
        /// h4
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.H4;
    }
}
