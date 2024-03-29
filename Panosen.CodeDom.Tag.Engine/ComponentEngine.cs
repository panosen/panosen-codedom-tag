﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Engine
{
    /// <summary>
    /// ComponentEngine
    /// </summary>
    public abstract class ComponentEngine
    {
        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public abstract void Generate(Component component, CodeWriter codeWriter, GenerateOptions options);
    }

    /// <summary>
    /// ComponentEngine
    /// </summary>
    /// <typeparam name="TComponent"></typeparam>
    public abstract class ComponentEngine<TComponent> : ComponentEngine
        where TComponent : Component
    {
        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public sealed override void Generate(Component component, CodeWriter codeWriter, GenerateOptions options)
        {
            if (!(component is TComponent tComponent))
            {
                throw new ArgumentException($"component should be instance of `{typeof(TComponent).FullName}`");
            }

            OnGenerate(tComponent, codeWriter, options);
        }

        /// <summary>
        /// GenerateComponents
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public abstract void OnGenerate(TComponent component, CodeWriter codeWriter, GenerateOptions options);

        /// <summary>
        /// GenerateAttributes
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
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

        /// <summary>
        /// GenerateProperties
        /// </summary>
        /// <param name="component"></param>
        /// <param name="codeWriter"></param>
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
