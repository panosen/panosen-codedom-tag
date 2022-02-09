using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TrComponent 表格中的行
    /// </summary>
    public class TrComponent : HtmlComponent
    {

        /// <summary>
        /// tr
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Tr;
    }
}
