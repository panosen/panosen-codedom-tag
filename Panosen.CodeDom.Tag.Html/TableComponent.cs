using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TableComponent 表格
    /// </summary>
    public class TableComponent : HtmlComponent
    {

        /// <summary>
        /// table
        /// </summary>
        public override string Name { get; set; } = "table";
    }
}
