using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// FigureComponent 媒介内容的分组，以及它们的标题
    /// </summary>
    public class FigureComponent : HtmlComponent
    {

        /// <summary>
        /// figure
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Figure;
    }
}
