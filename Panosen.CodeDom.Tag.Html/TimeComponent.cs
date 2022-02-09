using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// TimeComponent 日期/时间
    /// </summary>
    public class TimeComponent : HtmlComponent
    {

        /// <summary>
        /// time
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Time;
    }
}
