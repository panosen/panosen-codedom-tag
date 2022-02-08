using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// OptgroupComponent 选择列表中相关选项的组合
    /// </summary>
    public class OptgroupComponent : HtmlComponent
    {

        /// <summary>
        /// optgroup
        /// </summary>
        public override string Name { get; set; } = "optgroup";
    }
}
