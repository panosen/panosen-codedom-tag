using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Panosen.CodeDom.Tag;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// HtmlComponent  HTML 文档
    /// </summary>
    public class HtmlComponent : BasicComponent
    {

        /// <summary>
        /// html
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Html;

        /// <summary>
        /// BuiltIn
        /// </summary>
        public override bool BuiltIn { get; set; } = true;
    }
}
