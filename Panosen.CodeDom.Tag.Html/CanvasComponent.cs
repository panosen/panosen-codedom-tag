using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// CanvasComponent 图形
    /// </summary>
    public class CanvasComponent : HtmlComponent
    {

        /// <summary>
        /// canvas
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Canvas;
    }
}
