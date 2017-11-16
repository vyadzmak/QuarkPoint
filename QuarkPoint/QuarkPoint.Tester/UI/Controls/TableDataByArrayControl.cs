using System;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.Helpers.GUI;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class TableDataByArrayControl : UserControl
    {
        public TableDataByArrayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Init control
        /// </summary>
        public void Init()
        {
            try
            {
                Dock = DockStyle.Fill;
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        ///     cancel event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var form = (Form) Parent.Parent;
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// ok event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;
                table.TableType = TableType.DataByVariables;
                table.ColumnsCount = (int) nColumnCount.Value;
                table.InitColumns();
                table.IsInit = true;


                var form = (Form) Parent.Parent;
                form.Close();
                Program.MainForm.lbTemplateElements.SelectedIndex = -1;
                GuiListHelper.SelectLastItem();
            }
            catch (Exception exception)
            {
            }
        }
    }
}