using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SComponent 加删除线的文本
    /// </summary>
    public class SComponent : HtmlComponent
    {

        /// <summary>
        /// s
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.S;
    }
}
