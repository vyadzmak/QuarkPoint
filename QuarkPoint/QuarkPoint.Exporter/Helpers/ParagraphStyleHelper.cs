using System;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Models.TemplateModels;


namespace QuarkPoint.Exporter.Helpers
{
    /// <summary>
    ///     style helper
    /// </summary>
    public static class ParagraphStyleHelper
    {
        /// <summary>
        /// generate run properties
        /// </summary>
        /// <returns></returns>
        public static RunProperties GenerateRunProperities(TemplateElement element)
        {
            try
            {
                var style = new TemplateStyle();

                switch (element.ElementType)
                {
                    case ElementType.Текст:
                        var par = element.Paragraph;
                        style = new TemplateStyle(par.FontName, par.FontWeight, par.TextAlign, par.FontSize,
                            par.BackgroundColor, par.ForegroundColor, par.UnderLine);
                        break;

                    case ElementType.Таблица:
                        var table = element.Table;
                        style =  new TemplateStyle(table.DefaultCellStyle.FontName, table.DefaultCellStyle.FontWeight, table.DefaultCellStyle.TextAlign, table.DefaultCellStyle.FontSize,
                            table.DefaultCellStyle.BackgroundColor, table.DefaultCellStyle.ForegroundColor, table.DefaultCellStyle.UnderLine);
                        break;
                }

                var properties = new RunProperties();

                //text font
                var fonts = new RunFonts();
                switch (style.FontName)
                {
                    case FontName.Arial:
                        fonts.Ascii = "Arial";
                        fonts.HighAnsi = "Arial";
                        break;

                    case FontName.Calibri:
                        fonts.Ascii = "Calibri";
                        fonts.HighAnsi = "Calibri";
                        break;

                    case FontName.Times:
                        fonts.Ascii = "Times New Roman";
                        fonts.HighAnsi = "Times New Roman";
                        break;
                }
                properties.Append(fonts);

                //font weight
                switch (style.FontWeight)
                {
                    case FontWeight.Bold:
                        properties.Bold = new Bold();
                        break;

                    case FontWeight.Italic:
                        properties.Italic = new Italic();
                        break;

                    case FontWeight.Normal:

                        break;

                    case FontWeight.BoldItalic:
                        properties.Bold = new Bold();
                        properties.Italic = new Italic();

                        break;
                }

                //underline
                if (style.UnderLine)
                    properties.Underline = new Underline();

                var size = new FontSize();
                size.Val = (style.FontSize * 2).ToString();

                Color color = new Color();
                color.Val =style.ForegroundColor;
                properties.Append(color);
                properties.Append(size);

                return properties;
            }
            catch (Exception e)
            {
                return new RunProperties();
            }
        }

        /// <summary>
        /// paragraph properties
        /// </summary>
        /// <returns></returns>
        public static ParagraphProperties GenerateParagraphProperties(TemplateElement element)
        {
            try
            {

                var style = new TemplateStyle();

                switch (element.ElementType)
                {
                    case ElementType.Текст:
                        var par = element.Paragraph;
                        style = new TemplateStyle(par.FontName, par.FontWeight, par.TextAlign, par.FontSize,
                            par.BackgroundColor, par.ForegroundColor, par.UnderLine);
                        break;

                    case ElementType.Таблица:
                        var table = element.Table;
                        style = new TemplateStyle(table.DefaultCellStyle.FontName, table.DefaultCellStyle.FontWeight, table.DefaultCellStyle.TextAlign, table.DefaultCellStyle.FontSize,
                            table.DefaultCellStyle.BackgroundColor, table.DefaultCellStyle.ForegroundColor, table.DefaultCellStyle.UnderLine);
                        break;
                }

                ParagraphProperties properties = new ParagraphProperties();

                var spacing = new SpacingBetweenLines
                {
                    Line = "240",
                    LineRule = LineSpacingRuleValues.Auto,
                    Before = "0",
                    After = "0"
                };

                properties.Append(spacing);

                var shading =
                    new Shading
                    {
                        Color = style.ForegroundColor,
                        Fill = style.BackgroundColor,
                        Val = ShadingPatternValues.Clear
                    };
                properties.Append(shading);

                var align = JustificationValues.Left;

                switch (style.TextAlign)
                {
                    case TextAlign.Center:
                        align = JustificationValues.Center;
                        break;

                    case TextAlign.Right:
                        align = JustificationValues.Right;
                        break;
                }
                var textAlign = new Justification { Val = align };
                properties.Append(textAlign);

                return properties;
            }
            catch (Exception e)
            {
                return new ParagraphProperties();
            }
        }



        /// <summary>
        /// generate run properties
        /// </summary>
        /// <returns></returns>
        public static RunProperties GenerateRunProperitiesByStyle(TemplateStyle style)
        {
            try
            {
                

                var properties = new RunProperties();

                //text font
                var fonts = new RunFonts();
                switch (style.FontName)
                {
                    case FontName.Arial:
                        fonts.Ascii = "Arial";
                        fonts.HighAnsi = "Arial";
                        break;

                    case FontName.Calibri:
                        fonts.Ascii = "Calibri";
                        fonts.HighAnsi = "Calibri";
                        break;

                    case FontName.Times:
                        fonts.Ascii = "Times New Roman";
                        fonts.HighAnsi = "Times New Roman";
                        break;
                }
                properties.Append(fonts);

                //font weight
                switch (style.FontWeight)
                {
                    case FontWeight.Bold:
                        properties.Bold = new Bold();
                        break;

                    case FontWeight.Italic:
                        properties.Italic = new Italic();
                        break;

                    case FontWeight.Normal:

                        break;

                    case FontWeight.BoldItalic:
                        properties.Bold = new Bold();
                        properties.Italic = new Italic();

                        break;
                }

                //underline
                if (style.UnderLine)
                    properties.Underline = new Underline();

                var size = new FontSize();
                size.Val = (style.FontSize * 2).ToString();
                properties.Append(size);

                return properties;
            }
            catch (Exception e)
            {
                return new RunProperties();
            }
        }

        /// <summary>
        /// paragraph properties
        /// </summary>
        /// <returns></returns>
        public static ParagraphProperties GenerateParagraphPropertiesByStyle(TemplateStyle style)
        {
            try
            {

                

                ParagraphProperties properties = new ParagraphProperties();

                var spacing = new SpacingBetweenLines
                {
                    Line = "240",
                    LineRule = LineSpacingRuleValues.Auto,
                    Before = "0",
                    After = "0"
                };

                properties.Append(spacing);

                var shading =
                    new Shading
                    {
                        Color = style.ForegroundColor,
                        Fill = style.BackgroundColor,
                        Val = ShadingPatternValues.Clear
                    };
                properties.Append(shading);

                var align = JustificationValues.Left;

                switch (style.TextAlign)
                {
                    case TextAlign.Center:
                        align = JustificationValues.Center;
                        break;

                    case TextAlign.Right:
                        align = JustificationValues.Right;
                        break;
                }
                var textAlign = new Justification { Val = align };
                properties.Append(textAlign);

                return properties;
            }
            catch (Exception e)
            {
                return new ParagraphProperties();
            }
        }
    }
}