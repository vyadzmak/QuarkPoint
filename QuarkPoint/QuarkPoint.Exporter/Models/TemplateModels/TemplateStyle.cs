using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    /// <summary>
    /// font weight
    /// </summary>
    public enum FontWeight { Normal=0, Bold=1, Italic=2, BoldItalic=3}

    /// <summary>
    /// font name
    /// </summary>
    public enum FontName { Arial=0, Times=1, Calibri =2}
    
    /// <summary>
    /// text align
    /// </summary>
    public enum TextAlign { Left=0,Center=1,Right=2,Justify=3}


    public class TemplateStyle
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateStyle()
        {
            try
            {
                FontName = FontName.Times;
                FontWeight = FontWeight.Normal;
                FontSize = 10;
                ForegroundColor = "#000000";
                BackgroundColor = "#ffffff";
                TextAlign = TextAlign.Left;
                UnderLine = false;

            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// constructor with params
        /// </summary>
        /// <param name="fontName"></param>
        /// <param name="fontWeight"></param>
        /// <param name="textAlign"></param>
        /// <param name="fontSize"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="foregroundColor"></param>
        /// <param name="underLine"></param>
        /// <param name=""></param>
        public TemplateStyle(FontName fontName, FontWeight fontWeight, TextAlign textAlign, int fontSize,string backgroundColor, string foregroundColor,bool underLine)
        {
            try
            {
                this.FontName = fontName;
                this.FontWeight = fontWeight;
                this.TextAlign = textAlign;
                this.FontSize = fontSize;
                this.ForegroundColor = foregroundColor;
                this.BackgroundColor = backgroundColor;
                this.UnderLine = underLine;
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region fields
        /// <summary>
        /// foreground color
        /// </summary>
        [JsonProperty("foreground_color")]

        public string ForegroundColor { get; set; }

        /// <summary>
        /// background color
        /// </summary>
        [JsonProperty("background_color")]

        public string BackgroundColor { get; set; }

        /// <summary>
        /// font name
        /// </summary>
        [JsonProperty("font_name")]

        public FontName FontName { get; set; }

        /// <summary>
        /// font weight
        /// </summary>
        [JsonProperty("font_weight")]

        public FontWeight FontWeight { get; set; }

        /// <summary>
        /// text align
        /// </summary>
        [JsonProperty("text_align")]

        public TextAlign TextAlign { get; set; }
        /// <summary>
        /// font size in pt
        /// </summary>
        [JsonProperty("font_size")]

        public int FontSize { get; set; }

        [JsonProperty("underline")]
        public bool UnderLine { get; set; }
        #endregion
    }
}
