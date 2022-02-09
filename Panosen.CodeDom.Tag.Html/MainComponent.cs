using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MainComponent 文档的主要内容
    /// </summary>
    public class MainComponent : HtmlComponent
    {

        /// <summary>
        /// main
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Main;
    }
}
