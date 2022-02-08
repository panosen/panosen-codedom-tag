using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ColgroupComponent 表格中供格式化的列组
    /// </summary>
    public class ColgroupComponent : HtmlComponent
    {

        /// <summary>
        /// colgroup
        /// </summary>
        public override string Name { get; set; } = "colgroup";
    }
}
