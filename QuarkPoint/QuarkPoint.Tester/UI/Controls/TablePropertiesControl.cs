using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;
using QuarkPoint.Tester.Helpers.DataLoaders;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class TablePropertiesControl : UserControl
    {
        #region variables
        /// <summary>
        /// current element
        /// </summary>
        private TemplateElement element = Program.MainForm.CurrentElement;

        /// <summary>
        /// currrent header
        /// </summary>
        private HeaderModel CurrentHeader = null;
        #endregion

        #region constrcutor

        /// <summary>
        ///     constructor
        /// </summary>
        public TablePropertiesControl()
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

        #region header controls methods

        private void dgvHeaderContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvHeaderContent.CurrentCell.RowIndex;
                CurrentHeader = element.Table.Headers.FirstOrDefault(x => x.Index == index);
                if (CurrentHeader!=null)
                InitHeaderComponent();
            }
            catch (Exception exception)
            {
            }
        }

        private void dgvHeaderContent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHeaderContent.CurrentCell.RowIndex;
                CurrentHeader = element.Table.Headers.FirstOrDefault(x => x.Index == index);
                if (CurrentHeader != null)
                    InitHeaderComponent();
            }
            catch (Exception exception)
            {
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHeaderContent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadTableContent.LoadHeaderFromGridBody(dgvHeaderContent);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// cbheader font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHeaderFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontName fontName;
                Enum.TryParse(cbFont.SelectedValue.ToString(), out fontName);
                CurrentHeader.Style.FontName = fontName;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// header font weight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHeaderFontWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontWeight fontWeight;
                Enum.TryParse(cbFontWeight.SelectedValue.ToString(), out fontWeight);
                CurrentHeader.Style.FontWeight = fontWeight;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// header text align
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHeaderTextAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextAlign textAlign;
                Enum.TryParse(cbTextAlign.SelectedValue.ToString(), out textAlign);
                CurrentHeader.Style.TextAlign = textAlign;
            }
            catch (Exception exception)
            {
            }
            
        }

        #endregion

        #region init controls
        /// <summary>
        /// init header component
        /// </summary>
        private void InitHeaderComponent()
        {
            try
            {


                nHeaderFontSize.DataBindings.Add("Value",
                    CurrentHeader.Style,
                    "FontSize",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);


                //binding combobox
                cbHeaderFont.DataSource = Enum.GetValues(typeof(FontName));
                cbHeaderFont.SelectedItem = CurrentHeader.Style.FontName;


                cbHeaderFontWeight.DataSource = Enum.GetValues(typeof(FontWeight));
                cbHeaderFontWeight.SelectedItem = CurrentHeader.Style.FontWeight;

                cbHeaderTextAlign.DataSource = Enum.GetValues(typeof(TextAlign));
                cbHeaderTextAlign.SelectedItem = CurrentHeader.Style.TextAlign;
                

                btnHeaderBackColor.Text = CurrentHeader.Style.BackgroundColor;
                btnHeaderBackColor.BackColor = ColorTranslator.FromHtml(CurrentHeader.Style.BackgroundColor);
                btnHeaderBackColor.ForeColor = InvertMeAColour(btnHeaderBackColor.BackColor);

                btnHeaderForegroundColor.Text = CurrentHeader.Style.ForegroundColor;
                btnHeaderForegroundColor.BackColor = ColorTranslator.FromHtml(CurrentHeader.Style.ForegroundColor);
                btnHeaderForegroundColor.ForeColor = InvertMeAColour(btnHeaderForegroundColor.BackColor);
            }
            catch (Exception e)
            {
            }

        }
        /// <summary>
        ///     init content component
        /// </summary>
        private void InitContentComponent()
        {
            try
            {
                nFontSize.DataBindings.Add("Value",
                    Program.MainForm.CurrentElement.Table.DefaultCellStyle,
                    "FontSize",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);


                //binding combobox
                cbFont.DataSource = Enum.GetValues(typeof(FontName));
                cbFont.SelectedItem = element.Table.DefaultCellStyle.FontName;
                cbFont.SelectedIndexChanged += CbFont_SelectedIndexChanged;

                cbFontWeight.DataSource = Enum.GetValues(typeof(FontWeight));
                cbFontWeight.SelectedItem = element.Table.DefaultCellStyle.FontWeight;
                cbFontWeight.SelectedIndexChanged += CbFontWeight_SelectedIndexChanged;

                cbTextAlign.DataSource = Enum.GetValues(typeof(TextAlign));
                cbTextAlign.SelectedItem = element.Table.DefaultCellStyle.TextAlign;
                cbTextAlign.SelectedIndexChanged += CbTextAlign_SelectedIndexChanged;

                btnBackColor.Text = element.Table.DefaultCellStyle.BackgroundColor;
                btnBackColor.BackColor = ColorTranslator.FromHtml(element.Table.DefaultCellStyle.BackgroundColor);
                btnBackColor.ForeColor = InvertMeAColour(btnBackColor.BackColor);

                btnForegroundColor.Text = element.Table.DefaultCellStyle.ForegroundColor;
                btnForegroundColor.BackColor = ColorTranslator.FromHtml(element.Table.DefaultCellStyle.ForegroundColor);
                btnForegroundColor.ForeColor = InvertMeAColour(btnForegroundColor.BackColor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        ///     init controls
        /// </summary>
        public void InitControl()
        {
            try
            {
                Dock = DockStyle.Fill;
                var table = Program.MainForm.CurrentElement.Table;
                txtTableName.DataBindings.Add("Text",
                    Program.MainForm.CurrentElement,
                    "Title",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);

                if (!table.IsInit)
                {
                    tcTableProperties.TabPages.Remove(tpHeaders);
                    tcTableProperties.TabPages.Remove(tpFooters);
                    tcTableProperties.TabPages.Remove(tpBody);
                    tcTableProperties.TabPages.Remove(tpFormatting);


                    chbUseFooters.Checked = Program.MainForm.CurrentElement.Table.UseFooters;
                    chbUseHeaders.Checked = Program.MainForm.CurrentElement.Table.UseHeaders;
                }
                else
                {
                    gbConfirm.Enabled = false;
                    gbDetails.Enabled = false;
                    gbSelectType.Enabled = false;
                    chbUseHeaders.Enabled = false;
                    chbUseFooters.Enabled = false;

                    switch (table.DataType)
                    {
                        case DataType.Manual:
                            rbManual.Checked = true;
                            break;

                        case DataType.AutoByDataWithoutFormatting:
                            rbAutoWithoutFormat.Checked = true;
                            break;

                        case DataType.AutoByDataWithFormatting:
                            rbAutoWithFormat.Checked = true;
                            break;
                    }

                    if (!table.UseHeaders)
                        tcTableProperties.TabPages.Remove(tpHeaders);

                    if (!table.UseFooters)
                        tcTableProperties.TabPages.Remove(tpFooters);


                    chbUseFooters.Checked = Program.MainForm.CurrentElement.Table.UseFooters;
                    chbUseHeaders.Checked = Program.MainForm.CurrentElement.Table.UseHeaders;
                }


                switch (table.DataType)
                {
                    case DataType.Manual:
                        rbManual.Checked = true;
                        var control = new ManualEnterTablePropertiesControl();
                        control.InitControl();
                        LoadControl(control);

                        break;

                    case DataType.AutoByDataWithoutFormatting:
                        rbAutoWithoutFormat.Checked = true;
                        Program.MainForm.CurrentElement.Table.DataType = DataType.AutoByDataWithoutFormatting;
                        var aControl = new AutoBindingWithoutFormattingTableControl();
                        aControl.InitControl();
                        LoadControl(aControl);
                        break;

                    case DataType.AutoByDataWithFormatting:
                        rbAutoWithFormat.Checked = true;
                        var vControl = new AutoBindingWithFormattingTableControl();
                        vControl.InitControl();
                        LoadControl(vControl);
                        break;
                }

                if (element.Table.Headers.Count > 0)
                {
                    dgvHeaderContent.Rows[0].Selected = true;
                }
                InitContentComponent();
            }
            catch (Exception e)
            {
            }
        }


        /// <summary>
        ///     init controls
        /// </summary>
        public void FirstInitControl()
        {
            try
            {
                Dock = DockStyle.Fill;
                var table = Program.MainForm.CurrentElement.Table;

                if (table.UseHeaders)
                    tcTableProperties.TabPages.Add(tpHeaders);

                if (table.UseFooters)
                    tcTableProperties.TabPages.Add(tpFooters);

                tcTableProperties.TabPages.Add(tpFormatting);

                tcTableProperties.TabPages.Add(tpBody);

                gbConfirm.Enabled = false;
                gbDetails.Enabled = false;
                gbSelectType.Enabled = false;

                chbUseHeaders.Enabled = false;
                chbUseFooters.Enabled = false;

                switch (table.DataType)
                {
                    case DataType.Manual:
                        rbManual.Checked = true;
                        break;

                    case DataType.AutoByDataWithoutFormatting:
                        rbAutoWithoutFormat.Checked = true;
                        break;

                    case DataType.AutoByDataWithFormatting:
                        rbAutoWithFormat.Checked = true;
                        break;
                }

                chbUseFooters.Checked = Program.MainForm.CurrentElement.Table.UseFooters;
                chbUseHeaders.Checked = Program.MainForm.CurrentElement.Table.UseHeaders;
            }
            catch (Exception e)
            {
            }
        }

        #endregion

        #region events

        /// <summary>
        ///     load controls
        /// </summary>
        private void LoadControl(Control control)
        {
            try
            {
                gbDetails.Controls.Clear();
                gbDetails.Controls.Add(control);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        ///     rb manual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.DataType = DataType.Manual;
                var control = new ManualEnterTablePropertiesControl();
                control.InitControl();
                LoadControl(control);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     rb auto without format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAutoWithoutFormat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.DataType = DataType.AutoByDataWithoutFormatting;
                var control = new AutoBindingWithoutFormattingTableControl();
                control.InitControl();
                LoadControl(control);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     rb auto with format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAutoWithFormat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.DataType = DataType.AutoByDataWithFormatting;
                var control = new AutoBindingWithFormattingTableControl();
                control.InitControl();
                LoadControl(control);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     check box use headers events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbUseHeaders_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.UseHeaders = chbUseHeaders.Checked;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     check box use footers events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbUseFooters_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.UseFooters = chbUseFooters.Checked;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     init table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;
                switch (table.DataType)
                {
                    case DataType.Manual:
                        table.InitColumns();
                        break;

                    case DataType.AutoByDataWithoutFormatting:
                        table.IsInit = true;
                        break;

                    case DataType.AutoByDataWithFormatting:
                        break;
                }
                FirstInitControl();
                table.IsInit = true;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcTableProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var page = tcTableProperties.SelectedTab;
                switch (page.Name)
                {
                    case "tpBody":
                        LoadTableContent.LoadDataToBody(dgvTableContent);
                        InitContentComponent();
                        break;

                    case "tpHeaders":
                        LoadTableContent.LoadDataToHeaders(dgvHeaderContent);
                        break;

                    case "tpFormatting":
                        LoadTableContent.LoadDataToFormatting(dgvFormatting);

                        break;
                }
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     init table data from grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTableContent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadTableContent.LoadTableContentFromGridBody(dgvTableContent);
            }
            catch (Exception exception)
            {
            }
        }

        #endregion

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
                element.Table.DefaultCellStyle.TextAlign = textAlign;
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
                element.Table.DefaultCellStyle.FontWeight = fontWeight;
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
                element.Table.DefaultCellStyle.FontName = fontName;
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

        private void dgvTableContent_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvFormatting_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadTableContent.LoadDataFromFormatting(dgvFormatting);
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}