using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panosen.CodeDom.Tag.Engine;

namespace Panosen.CodeDom.Tag.Script
{
    /// <summary>
    /// ScriptComponentEngine
    /// </summary>
    public class ScriptComponentEngine : ComponentEngine<ScriptComponent>
    {

        #region ComponentEngine<ScriptComponent> Members

        /// <summary>
        /// ComponentEngine&lt;ScriptComponent&gt;.OnGenerate
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public override void OnGenerate(ScriptComponent component, CodeWriter codeWriter, GenerateOptions options)
        {
            Process(component, codeWriter, options);
        }

        #endregion

        /// <summary>
        /// script
        /// </summary>
        /// <param name="scriptComponent"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        private void Process(ScriptComponent scriptComponent, CodeWriter codeWriter, GenerateOptions options)
        {
            if (scriptComponent == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(options.IndentString).Write(Marks.LESS_THAN).Write(scriptComponent.Name);

            GenerateProperties(scriptComponent, codeWriter);

            GenerateAttributes(scriptComponent, codeWriter);

            codeWriter.Write(Marks.GREATER_THAN);

            if (scriptComponent.CodeFile == null)
            {
                codeWriter.Write(Marks.LESS_THAN).Write(Marks.SLASH).Write(scriptComponent.Name).Write(Marks.GREATER_THAN);
                return;
            }

            codeWriter.WriteLine();

            new JavaScript.Engine.JsCodeEngine().GenerateFile(scriptComponent.CodeFile, codeWriter, new JavaScript.Engine.GenerateOptions
            {
                IndentSize = options.IndentSize + 1
            });

            codeWriter.Write(options.IndentString).Write(Marks.LESS_THAN).Write(Marks.SLASH).Write(scriptComponent.Name).Write(Marks.GREATER_THAN);
        }
    }
}
