using System;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.UI.Controls;

namespace QuarkPoint.Tester.UI
{
    public partial class TableSettingsForm : Form
    {
        public TableSettingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableSettingsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                pDetails.Hide();
                cbTableType.DataSource = Enum.GetValues(typeof(TableType));
                cbTableType.SelectedItem = TableType.DataByVariables;
                Height = pMainTableSetting.Height + 32;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        ///     load control
        /// </summary>
        /// <param name="control"></param>
        private void LoadControl(Control control)
        {
            try
            {
                pDetails.Show();
                pDetails.Controls.Clear();
                pDetails.Controls.Add(control);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;
                table.TableType = (TableType) cbTableType.SelectedItem;
                table.UseHeaders = chbUseHeaders.Checked;
                table.UseFooters = chbUseFooters.Checked;

                switch (table.TableType)
                {
                    case TableType.DataByArray:
                        var vControl = new TableDataByArrayControl();
                        Height = vControl.Height + 32;
                        Width = vControl.Width + 32;
                        vControl.Init();
                        LoadControl(vControl);
                        break;

                    case TableType.DataByVariables:
                        var dControl = new TableDataByVariablesControl();
                        Height = dControl.Height + 32;
                        Width = dControl.Width + 32;
                        dControl.Init();
                        LoadControl(dControl);
                        break;

                    case TableType.ComplexDataByArray:
                        break;
                }

                pMainTableSetting.Hide();
            }
            catch (Exception exception)
            {
            }
        }
    }
}