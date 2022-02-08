using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// PreComponent 预格式文本
    /// </summary>
    public class PreComponent : HtmlComponent
    {

        /// <summary>
        /// pre
        /// </summary>
        public override string Name { get; set; } = "pre";
    }
}
