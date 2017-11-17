using System;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;
using QuarkPoint.Tester.Helpers.DataLoaders;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class TablePropertiesControl : UserControl
    {
        #region constrcutor

        /// <summary>
        ///     constructor
        /// </summary>
        public TablePropertiesControl()
        {
            InitializeComponent();
        }

        #endregion

        #region init controls

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
                    rbManual.Checked = true;

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcTableProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TabPage page = tcTableProperties.SelectedTab;
                switch (page.Name)
                {
                    case "tpBody":
                        LoadTableContent.LoadDataToBody(dgvTableContent);
                        break;
                }
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// init table data from grid
        /// 
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


    }
}