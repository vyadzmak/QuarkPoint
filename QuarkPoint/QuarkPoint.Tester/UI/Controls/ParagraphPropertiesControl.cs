using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class ParagraphPropertiesControl : UserControl
    {
        TemplateElement element = Program.MainForm.CurrentElement;

        Color InvertMeAColour(Color ColourToInvert)
        {
            return Color.FromArgb((byte)~ColourToInvert.R, (byte)~ColourToInvert.G, (byte)~ColourToInvert.B);
        }

        public ParagraphPropertiesControl()
        {
            InitializeComponent();
        }

        public void InitControl()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                txtElementName.DataBindings.Add("Text",
                    Program.MainForm.CurrentElement,
                    "Title",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);



                nFontSize.DataBindings.Add("Value",
                    Program.MainForm.CurrentElement.Paragraph,
                    "FontSize",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);

                
                //binding combobox
                cbFont.DataSource = Enum.GetValues(typeof(FontName));
                cbFont.SelectedItem = element.Paragraph.FontName;
                cbFont.SelectedIndexChanged += CbFont_SelectedIndexChanged;

                cbFontWeight.DataSource = Enum.GetValues(typeof(FontWeight));
                cbFontWeight.SelectedItem = element.Paragraph.FontWeight;
                cbFontWeight.SelectedIndexChanged += CbFontWeight_SelectedIndexChanged;

                cbTextAlign.DataSource = Enum.GetValues(typeof(TextAlign));
                cbTextAlign.SelectedItem = element.Paragraph.TextAlign;
                cbTextAlign.SelectedIndexChanged += CbTextAlign_SelectedIndexChanged;
                rtbText.Text=element.Paragraph.Text ;

                btnBackColor.Text = element.Paragraph.BackgroundColor;
                btnBackColor.BackColor = System.Drawing.ColorTranslator.FromHtml(element.Paragraph.BackgroundColor);
                btnBackColor.ForeColor = InvertMeAColour(btnBackColor.BackColor);

                btnForegroundColor.Text = element.Paragraph.ForegroundColor;
                btnForegroundColor.BackColor = System.Drawing.ColorTranslator.FromHtml(element.Paragraph.ForegroundColor);
                btnForegroundColor.ForeColor = InvertMeAColour(btnForegroundColor.BackColor);

                rtbText.ForeColor = btnForegroundColor.BackColor;
                rtbText.BackColor = btnBackColor.BackColor;
            }
            catch (Exception exception)
            {

            }
        }


        private void ParagraphPropertiesControl_Load(object sender, EventArgs e)
        {
            
            
        }

        private void CbTextAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextAlign textAlign;
                Enum.TryParse<TextAlign>(cbTextAlign.SelectedValue.ToString(), out textAlign);
                element.Paragraph.TextAlign = textAlign;
            }
            catch (Exception exception)
            {
                
            }
        }

        private void CbFontWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontWeight fontWeight;
                Enum.TryParse<FontWeight>(cbFontWeight.SelectedValue.ToString(), out fontWeight);
                element.Paragraph.FontWeight = fontWeight;
            }
            catch (Exception exception)
            {
                
            }
        }

        /// <summary>
        /// change font name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontName fontName;
                Enum.TryParse<FontName>(cbFont.SelectedValue.ToString(), out fontName);
                element.Paragraph.FontName = fontName;

            }
            catch (Exception exception)
            {
            }
        }

        #region control events

        #endregion

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                element.Paragraph.Text = rtbText.Text;
            }
            catch (Exception exception)
            {
            }
        }

        private void btnForegroundColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnForegroundColor.BackColor = cd.Color;
                    btnForegroundColor.ForeColor = InvertMeAColour(cd.Color);
                    string c = ColorTranslator.ToHtml(cd.Color).ToString();
                    rtbText.ForeColor = cd.Color;
                    element.Paragraph.ForegroundColor = c;
                    btnForegroundColor.Text = c;
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnBackColor.BackColor = cd.Color;
                    btnBackColor.ForeColor = InvertMeAColour(cd.Color);
                    rtbText.BackColor = cd.Color;

                    string c = ColorTranslator.ToHtml(cd.Color).ToString();
                    element.Paragraph.BackgroundColor = c;
                    btnBackColor.Text = c;
                }
            }
            catch (Exception exception)
            {
            }
        }
    }
}
