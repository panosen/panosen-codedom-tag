using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ColComponent 表格中一个或多个列的属性值
    /// </summary>
    public class ColComponent : HtmlComponent
    {

        /// <summary>
        /// col
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Col;
    }
}
