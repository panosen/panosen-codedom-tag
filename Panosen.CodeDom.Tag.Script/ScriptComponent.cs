using System;

using Panosen.CodeDom.JavaScript;

namespace Panosen.CodeDom.Tag.Script
{
    /// <summary>
    /// script
    /// </summary>
    public class ScriptComponent : Component
    {
        /// <summary>
        /// script
        /// </summary>
        public override string Name { get; set; } = "script";

        /// <summary>
        /// 内嵌脚本
        /// </summary>
        public JsCodeFile CodeFile { get; set; }
    }
}
