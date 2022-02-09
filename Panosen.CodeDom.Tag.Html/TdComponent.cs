using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TdComponent 表格中的单元
    /// </summary>
    public class TdComponent : HtmlComponent
    {

        /// <summary>
        /// td
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Td;
    }
}
