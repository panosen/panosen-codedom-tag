using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;

namespace Panosen.CodeDom.Tag.Engine
{
    /// <summary>
    /// BasicComponentEngine
    /// </summary>
    public class BasicComponentEngine : ComponentEngine<BasicComponent>
    {

        #region IComponentEngine<BasicComponent> Members

        /// <summary>
        /// IComponentEngine&lt;BasicComponent&gt;.OnGenerate
        /// </summary>
        /// <param name="basicComponent"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public override void OnGenerate(BasicComponent basicComponent, CodeWriter codeWriter, GenerateOptions options)
        {
            Process(basicComponent, codeWriter, options);
        }

        #endregion

        private void Process(BasicComponent basicComponent, CodeWriter codeWriter, GenerateOptions options)
        {
            if (basicComponent == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            var tagName = basicComponent.BuiltIn ? basicComponent.Name : basicComponent.Name.ToLowerCaseBreakLine();

            //在节点前面插入空行
            if (basicComponent.Margin || basicComponent.MarginTop)
            {
                codeWriter.WriteLine();
            }

            //注释
            if (!string.IsNullOrEmpty(basicComponent.Comment))
            {
                codeWriter.Write(options.IndentString).Write(Marks.LESS_THAN).Write(Marks.Exclamation).Write(Marks.MINUS).Write(Marks.MINUS).Write(Marks.WHITESPACE);

                codeWriter.Write(basicComponent.Comment);

                codeWriter.Write(Marks.WHITESPACE).Write(Marks.MINUS).Write(Marks.MINUS).WriteLine(Marks.GREATER_THAN);
            }

            codeWriter.Write(options.IndentString).Write(Marks.LESS_THAN).Write(tagName);

            GenerateProperties(basicComponent, codeWriter);

            GenerateAttributes(basicComponent, codeWriter);

            GenerateCss(basicComponent, codeWriter);

            //自闭和标签 <input /> <hr />
            if (basicComponent.SelfClosing)
            {
                codeWriter.Write(Marks.WHITESPACE).Write(Marks.SLASH).Write(Marks.GREATER_THAN);

                //在节点后面插入空行
                if (basicComponent.Margin || basicComponent.MarginBottom)
                {
                    codeWriter.WriteLine();
                }

                return;
            }

            codeWriter.Write(Marks.GREATER_THAN);

            //<子节点>
            {
                if (basicComponent.Children != null && basicComponent.Children.Count > 0)
                {
                    if (basicComponent.Padding || basicComponent.PaddingTop)
                    {
                        codeWriter.WriteLine();
                    }
                }

                GenerateChildren(basicComponent.Children, codeWriter, options);

                if (basicComponent.Children != null && basicComponent.Children.Count > 0)
                {
                    if (basicComponent.Padding || basicComponent.PaddingBottom)
                    {
                        codeWriter.WriteLine();
                    }
                }
            }

            //<内容>
            if (!string.IsNullOrEmpty(basicComponent.Content))
            {
                codeWriter.Write(basicComponent.Content);
            }

            if (basicComponent.Children != null && basicComponent.Children.Count > 0)
            {
                codeWriter.WriteLine();
                codeWriter.Write(options.IndentString);
            }

            codeWriter.Write(Marks.LESS_THAN).Write(Marks.SLASH).Write(tagName).Write(Marks.GREATER_THAN);

            //在节点后面插入空行
            if (basicComponent.Margin || basicComponent.MarginBottom)
            {
                codeWriter.WriteLine();
            }
        }

        /// <summary>
        /// GenerateCss
        /// </summary>
        /// <param name="basicComponent"></param>
        /// <param name="codeWriter"></param>
        protected void GenerateCss(BasicComponent basicComponent, CodeWriter codeWriter)
        {
            if (basicComponent.CssClassSet == null || basicComponent.CssClassSet.Count == 0)
            {
                return;
            }
            codeWriter.Write(Marks.WHITESPACE).Write("class").Write(Marks.EQUAL).Write(Marks.DOUBLE_QUOTATION).Write(string.Join(Marks.WHITESPACE, basicComponent.CssClassSet)).Write(Marks.DOUBLE_QUOTATION);
        }

        private void GenerateChildren(List<Component> components, CodeWriter codeWriter, GenerateOptions options)
        {
            if (components == null || components.Count <= 0)
            {
                return;
            }

            options.PushIndent();
            foreach (var component in components)
            {
                codeWriter.WriteLine();

                var engine = options.GetComponentEngine(component);
                if (engine == null)
                {
                    continue;
                }

                engine.Generate(component, codeWriter, options);
            }
            options.PopIndent();
        }
    }
}
