using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ThComponent 表格中的表头单元格
    /// </summary>
    public class ThComponent : HtmlComponent
    {

        /// <summary>
        /// th
        /// </summary>
        public override string Name { get; set; } = "th";
    }
}
