using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// VideoComponent 视频
    /// </summary>
    public class VideoComponent : HtmlComponent
    {

        /// <summary>
        /// video
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Video;
    }
}
