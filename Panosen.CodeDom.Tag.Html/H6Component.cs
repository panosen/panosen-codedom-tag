using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// H6Component  HTML 标题
    /// </summary>
    public class H6Component : HtmlComponent
    {

        /// <summary>
        /// h6
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.H6;
    }
}
