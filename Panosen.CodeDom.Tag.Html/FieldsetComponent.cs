using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// FieldsetComponent 围绕表单中元素的边框
    /// </summary>
    public class FieldsetComponent : HtmlComponent
    {

        /// <summary>
        /// fieldset
        /// </summary>
        public override string Name { get; set; } = "fieldset";
    }
}
