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
    }
}
