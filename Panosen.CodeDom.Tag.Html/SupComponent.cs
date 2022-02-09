using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SupComponent 上标文本
    /// </summary>
    public class SupComponent : HtmlComponent
    {

        /// <summary>
        /// sup
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Sup;
    }
}
