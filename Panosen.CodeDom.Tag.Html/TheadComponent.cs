using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TheadComponent 表格中的表头内容
    /// </summary>
    public class TheadComponent : HtmlComponent
    {

        /// <summary>
        /// thead
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Thead;
    }
}
