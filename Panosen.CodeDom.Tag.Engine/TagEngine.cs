using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Engine
{
    /// <summary>
    /// TagEngine
    /// </summary>
    public class TagEngine
    {
        public void Generate(Component component, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (component == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            var type = component.GetType();
            if (!options.ComponentEngineMap.ContainsKey(type))
            {
                return;
            }

            var engine = options.ComponentEngineMap[component.GetType()];

            
        }

        public void Generate(List<Component> components, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (components == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            foreach (var component in components)
            {
                Generate(component, codeWriter, options);
            }
        }
    }
}
