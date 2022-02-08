using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// CommandComponent 命令按钮
    /// </summary>
    public class CommandComponent : HtmlComponent
    {

        /// <summary>
        /// command
        /// </summary>
        public override string Name { get; set; } = "command";
    }
}
