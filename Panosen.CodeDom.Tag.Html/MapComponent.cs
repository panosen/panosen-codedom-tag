using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MapComponent 图像映射
    /// </summary>
    public class MapComponent : HtmlComponent
    {

        /// <summary>
        /// map
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Map;
    }
}
