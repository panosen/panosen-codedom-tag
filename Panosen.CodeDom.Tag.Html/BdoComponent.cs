using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// BdoComponent 文字方向
    /// </summary>
    public class BdoComponent : HtmlComponent
    {

        /// <summary>
        /// bdo
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Bdo;
    }
}
