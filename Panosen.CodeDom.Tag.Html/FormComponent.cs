using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// FormComponent 供用户输入的 HTML 表单
    /// </summary>
    public class FormComponent : HtmlComponent
    {

        /// <summary>
        /// form
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Form;
    }
}
