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
    /// ComponentExtension
    /// </summary>
    public static class ComponentExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this Component component, GenerateOptions options = null)
        {
            var builder = new StringBuilder();

            new TagEngineCore().Generate(component, new StringWriter(builder), options);

            return builder.ToString();
        }

        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this Component component, Action<GenerateOptions> action)
        {
            var builder = new StringBuilder();

            new TagEngineCore().Generate(component, new StringWriter(builder), action);

            return builder.ToString();
        }
    }
}
