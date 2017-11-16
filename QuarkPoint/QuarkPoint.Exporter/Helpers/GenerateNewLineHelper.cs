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
    public static class GenerateNewLineHelper
    {
        /// <summary>
        /// generate paragraph
        /// </summary>
        public static void GenerateNewLine(Body body)
        {
            try
            {
                
                Run run = new Run();
                run.Append(new Break());
                
                var tParagraph = new Paragraph();
                
                tParagraph.Append(run);

                body.Append(tParagraph);

            }
            catch (Exception e)
            {
            }
        }
    }
}
