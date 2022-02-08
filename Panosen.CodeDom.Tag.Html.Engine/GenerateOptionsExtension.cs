using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html.Engine
{
    /// <summary>
    /// GenerateOptionsExtension
    /// </summary>
    public static class GenerateOptionsExtension
    {
        /// <summary>
        /// AddHtmlComponentEngine
        /// </summary>
        public static GenerateOptions AddHtmlComponentEngine(this GenerateOptions options)
        {
            options.AddComponentEngine(new ScriptComponentEngine());

            return options;
        }
    }
}
