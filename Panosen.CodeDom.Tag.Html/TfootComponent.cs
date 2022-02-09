using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TfootComponent 表格中的表注内容（脚注）
    /// </summary>
    public class TfootComponent : HtmlComponent
    {

        /// <summary>
        /// tfoot
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Tfoot;
    }
}
