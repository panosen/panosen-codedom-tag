using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SelectComponent 选择列表（下拉列表）
    /// </summary>
    public class SelectComponent : HtmlComponent
    {

        /// <summary>
        /// select
        /// </summary>
        public override string Name { get; set; } = "select";
    }
}
