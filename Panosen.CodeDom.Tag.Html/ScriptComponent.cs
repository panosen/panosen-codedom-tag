using System;

using Panosen.CodeDom.JavaScript;

namespace Panosen.CodeDom.Tag.Html
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

    /// <summary>
    /// ScriptComponent
    /// </summary>
    public static class ScriptComponentExtension
    {
        /// <summary>
        /// AddCodeFile
        /// </summary>
        /// <typeparam name="TScriptComponent"></typeparam>
        /// <param name="scriptComponent"></param>
        /// <returns></returns>
        public static JsCodeFile AddCodeFile<TScriptComponent>(this TScriptComponent scriptComponent)
            where TScriptComponent : ScriptComponent
        {
            JsCodeFile jsCodeFile = new JsCodeFile();

            scriptComponent.CodeFile = jsCodeFile;

            return jsCodeFile;
        }
    }
}
