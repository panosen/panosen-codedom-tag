using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Engine
{
    public abstract class ComponentEngine
    {
        public abstract void Generate(Component component, CodeWriter codeWriter, GenerateOptions options);
    }

    public abstract class ComponentEngine<TComponent> : ComponentEngine
        where TComponent : Component
    {
        public sealed override void Generate(Component component, CodeWriter codeWriter, GenerateOptions options)
        {
            var tComponent = component as TComponent;
            if (tComponent == null)
            {
                throw new ArgumentException($"component should be instance of `{typeof(TComponent).FullName}`");
            }

            OnGenerate(tComponent, codeWriter, options);
        }

        /// <summary>
        /// GenerateComponents
        /// </summary>
        /// <param name="components"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public abstract void OnGenerate(TComponent component, CodeWriter codeWriter, GenerateOptions options);

        protected void GenerateAttributes(Component component, CodeWriter codeWriter)
        {
            if (component.AttributeSet == null || component.AttributeSet.Count == 0)
            {
                return;
            }

            foreach (var attribute in component.AttributeSet)
            {
                codeWriter.Write($" {attribute}");
            }
        }

        protected void GenerateProperties(Component component, CodeWriter codeWriter)
        {
            if (component.PropertyMap == null || component.PropertyMap.Count == 0)
            {
                return;
            }

            foreach (var property in component.PropertyMap)
            {
                codeWriter.Write(Marks.WHITESPACE).Write(property.Key ?? string.Empty).Write(Marks.EQUAL)
                    .Write(Marks.DOUBLE_QUOTATION).Write(property.Value ?? string.Empty).Write(Marks.DOUBLE_QUOTATION);
            }
        }
    }
}
