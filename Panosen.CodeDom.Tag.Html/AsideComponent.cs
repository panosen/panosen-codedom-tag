using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// AsideComponent 页面内容之外的内容
    /// </summary>
    public class AsideComponent : HtmlComponent
    {

        /// <summary>
        /// aside
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Aside;
    }
}
