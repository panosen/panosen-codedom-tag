using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TrackComponent 用在媒体播放器中的文本轨道
    /// </summary>
    public class TrackComponent : HtmlComponent
    {

        /// <summary>
        /// track
        /// </summary>
        public override string Name { get; set; } = "track";
    }
}
