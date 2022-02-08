using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MenuitemComponent 用户可以从弹出菜单调用的命令/菜单项目
    /// </summary>
    public class MenuitemComponent : HtmlComponent
    {

        /// <summary>
        /// menuitem
        /// </summary>
        public override string Name { get; set; } = "menuitem";
    }
}
