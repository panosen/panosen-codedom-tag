using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// QComponent 短的引用
    /// </summary>
    public class QComponent : HtmlComponent
    {

        /// <summary>
        /// q
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Q;
    }
}
