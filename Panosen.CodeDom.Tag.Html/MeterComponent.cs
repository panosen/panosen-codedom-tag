using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// MeterComponent 预定义范围内的度量
    /// </summary>
    public class MeterComponent : HtmlComponent
    {

        /// <summary>
        /// meter
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Meter;
    }
}
