using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// BComponent 粗体字
    /// </summary>
    public class BComponent : HtmlComponent
    {

        /// <summary>
        /// b
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.B;
    }
}
