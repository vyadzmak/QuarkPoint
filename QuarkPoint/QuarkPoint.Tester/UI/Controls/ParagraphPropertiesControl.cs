using System;
using System.Drawing;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.Helpers.DataLoaders;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class ParagraphPropertiesControl : UserControl
    {
        private readonly TemplateElement element = Program.MainForm.CurrentElement;

        #region constructor

        /// <summary>
        ///     constructor
        /// </summary>
        public ParagraphPropertiesControl()
        {
            InitializeComponent();
        }

        #endregion

        #region help methods

        /// <summary>
        ///     color invertor
        /// </summary>
        /// <param name="ColourToInvert"></param>
        /// <returns></returns>
        private Color InvertMeAColour(Color ColourToInvert)
        {
            return Color.FromArgb((byte) ~ColourToInvert.R, (byte) ~ColourToInvert.G, (byte) ~ColourToInvert.B);
        }

        #endregion

        #region init control

        /// <summary>
        ///     init control
        /// </summary>
        public void InitControl()
        {
            try
            {
                Dock = DockStyle.Fill;
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
                rtbText.Text = element.Paragraph.Text;

                btnBackColor.Text = element.Paragraph.BackgroundColor;
                btnBackColor.BackColor = ColorTranslator.FromHtml(element.Paragraph.BackgroundColor);
                btnBackColor.ForeColor = InvertMeAColour(btnBackColor.BackColor);

                btnForegroundColor.Text = element.Paragraph.ForegroundColor;
                btnForegroundColor.BackColor = ColorTranslator.FromHtml(element.Paragraph.ForegroundColor);
                btnForegroundColor.ForeColor = InvertMeAColour(btnForegroundColor.BackColor);

                rtbText.ForeColor = btnForegroundColor.BackColor;
                rtbText.BackColor = btnBackColor.BackColor;
            }
            catch (Exception exception)
            {
            }
        }

        #endregion

        private void tcParagraphProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var page = tcParagraphProperties.SelectedTab;
                switch (page.Name)
                {
                    case "tpFormatting":
                        LoadParagraphContent.LoadDataToFormatting(dgvFormatting);

                        break;
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void dgvFormatting_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadParagraphContent.LoadDataFromFormatting(dgvFormatting);
            }
            catch (Exception exception)
            {
            }
        }

        #region control events

        /// <summary>
        ///     text align combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbTextAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextAlign textAlign;
                Enum.TryParse(cbTextAlign.SelectedValue.ToString(), out textAlign);
                element.Paragraph.TextAlign = textAlign;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     font weight combobox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFontWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontWeight fontWeight;
                Enum.TryParse(cbFontWeight.SelectedValue.ToString(), out fontWeight);
                element.Paragraph.FontWeight = fontWeight;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     change font name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontName fontName;
                Enum.TryParse(cbFont.SelectedValue.ToString(), out fontName);
                element.Paragraph.FontName = fontName;
            }
            catch (Exception exception)
            {
            }
        }


        /// <summary>
        ///     text and schema rtb event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     foreground color button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForegroundColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnForegroundColor.BackColor = cd.Color;
                    btnForegroundColor.ForeColor = InvertMeAColour(cd.Color);
                    var c = ColorTranslator.ToHtml(cd.Color);
                    rtbText.ForeColor = cd.Color;
                    element.Paragraph.ForegroundColor = c;
                    btnForegroundColor.Text = c;
                }
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     back color button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnBackColor.BackColor = cd.Color;
                    btnBackColor.ForeColor = InvertMeAColour(cd.Color);
                    rtbText.BackColor = cd.Color;

                    var c = ColorTranslator.ToHtml(cd.Color);
                    element.Paragraph.BackgroundColor = c;
                    btnBackColor.Text = c;
                }
            }
            catch (Exception exception)
            {
            }
        }

        #endregion
    }
}