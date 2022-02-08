using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// DialogComponent 对话框或窗口
    /// </summary>
    public class DialogComponent : HtmlComponent
    {

        /// <summary>
        /// dialog
        /// </summary>
        public override string Name { get; set; } = "dialog";
    }
}
