using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Core
{
    /// <summary>
    /// TagEngine
    /// </summary>
    public class TagEngineCore
    {
        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void Generate(Component component, CodeWriter codeWriter, GenerateOptions options = null)
        {
            options = options ?? new GenerateOptions();

            var engine = options.GetComponentEngine(component);
            if (engine == null)
            {
                return;
            }

            engine.Generate(component, codeWriter, options);
        }

        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="components"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void Generate(List<Component> components, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (components == null || components.Count == 0)
            {
                return;
            }
            options = options ?? new GenerateOptions();

            for (int i = 0; i < components.Count; i++)
            {
                var component = components[i];

                var engine = options.GetComponentEngine(component);
                if (engine == null)
                {
                    continue;
                }

                engine.Generate(component, codeWriter, options);
                if (i < components.Count - 1)
                {
                    codeWriter.WriteLine();
                }
            }
        }
    }
}
