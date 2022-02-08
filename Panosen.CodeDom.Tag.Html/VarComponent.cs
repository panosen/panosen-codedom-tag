using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// VarComponent 文本的变量部分
    /// </summary>
    public class VarComponent : HtmlComponent
    {

        /// <summary>
        /// var
        /// </summary>
        public override string Name { get; set; } = "var";
    }
}
