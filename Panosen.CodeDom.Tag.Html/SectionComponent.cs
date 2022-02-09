using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// SectionComponent  section
    /// </summary>
    public class SectionComponent : HtmlComponent
    {

        /// <summary>
        /// section
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Section;
    }
}
