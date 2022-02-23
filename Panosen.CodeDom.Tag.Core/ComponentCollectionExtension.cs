using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Core
{
    /// <summary>
    /// ComponentCollectionExtension
    /// </summary>
    public static class ComponentCollectionExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this ComponentCollection components, GenerateOptions options = null)
        {
            var builder = new StringBuilder();

            new TagEngineCore().Generate(components.Components, new StringWriter(builder), options);

            return builder.ToString();
        }

        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this ComponentCollection components, Action<GenerateOptions> action)
        {
            var builder = new StringBuilder();

            new TagEngineCore().Generate(components.Components, new StringWriter(builder), action);

            return builder.ToString();
        }
    }
}
