using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// H5Component  HTML 标题
    /// </summary>
    public class H5Component : HtmlComponent
    {

        /// <summary>
        /// h5
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.H5;
    }
}
