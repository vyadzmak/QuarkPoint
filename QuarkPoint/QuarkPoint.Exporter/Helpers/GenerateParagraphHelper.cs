using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.Helpers
{
    /// <summary>
    /// helper for generate paragraph
    /// </summary>
    public static class GenerateParagraphHelper
    {
        /// <summary>
        /// generate paragraph
        /// </summary>
        public static void GenerateParagraph(Body body,TemplateElement element)
        {
            try
            {
                var paragraph = element.Paragraph;
                var rProperties = ParagraphStyleHelper.GenerateRunProperities(element);
                var pProperties = ParagraphStyleHelper.GenerateParagraphProperties(element);

                Run run = new Run();
                run.Append(rProperties);
                
                var text = new Text(FormattingHelper.FormatParagraphElements(element,paragraph.Text));
                run.Append(text);

                var tParagraph = new Paragraph();
                tParagraph.Append(pProperties);
                tParagraph.Append(run);

                body.Append(tParagraph);

            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// generate paragraph
        /// </summary>
        public static Paragraph GenerateParagraphByStyle(TemplateStyle style, string content)
        {
            try
            {
                
                var rProperties = ParagraphStyleHelper.GenerateRunProperitiesByStyle(style);
                var pProperties = ParagraphStyleHelper.GenerateParagraphPropertiesByStyle(style);

                Run run = new Run();
                run.Append(rProperties);

                var text = new Text(content);
                run.Append(text);

                var tParagraph = new Paragraph();
                tParagraph.Append(pProperties);
                tParagraph.Append(run);

                return tParagraph;

            }
            catch (Exception e)
            {
                return new Paragraph();
            }
        }
    }
}
