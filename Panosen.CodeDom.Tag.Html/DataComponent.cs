using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// DataComponent 添加给定内容的机器可读翻译
    /// </summary>
    public class DataComponent : HtmlComponent
    {

        /// <summary>
        /// data
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Data;
    }
}
