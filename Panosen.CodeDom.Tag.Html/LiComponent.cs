using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// LiComponent 列表的项目
    /// </summary>
    public class LiComponent : HtmlComponent
    {

        /// <summary>
        /// li
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Li;
    }
}
