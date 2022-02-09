using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// DlComponent 列表
    /// </summary>
    public class DlComponent : HtmlComponent
    {

        /// <summary>
        /// dl
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Dl;
    }
}
