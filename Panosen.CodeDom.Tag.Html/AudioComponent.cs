using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// AudioComponent 声音内容
    /// </summary>
    public class AudioComponent : HtmlComponent
    {

        /// <summary>
        /// audio
        /// </summary>
        public override string Name { get; set; } = "audio";
    }
}
