using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TemplateComponent 用作容纳页面加载时隐藏内容的容器
    /// </summary>
    public class TemplateComponent : HtmlComponent
    {

        /// <summary>
        /// template
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Template;
    }
}
