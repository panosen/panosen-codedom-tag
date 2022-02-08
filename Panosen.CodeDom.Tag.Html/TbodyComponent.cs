using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TbodyComponent 表格中的主体内容
    /// </summary>
    public class TbodyComponent : HtmlComponent
    {

        /// <summary>
        /// tbody
        /// </summary>
        public override string Name { get; set; } = "tbody";
    }
}
