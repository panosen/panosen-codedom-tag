using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ParamComponent 对象的参数
    /// </summary>
    public class ParamComponent : HtmlComponent
    {

        /// <summary>
        /// param
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Param;
    }
}
