using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MenuComponent 命令的列表或菜单
    /// </summary>
    public class MenuComponent : HtmlComponent
    {

        /// <summary>
        /// menu
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Menu;
    }
}
