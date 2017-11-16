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
using QuarkPoint.Tester.Helpers.GUI;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class TableDataByVariablesControl : UserControl
    {
        /// <summary>
        /// constructor
        /// </summary>
        public TableDataByVariablesControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// init control
        /// </summary>

        public void Init()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                
            }
            catch (Exception e)
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = (Form)this.Parent.Parent;
                form.Close();
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
                table.GroupCount = (int)nGroupCount.Value;
                table.GroupSize = (int) nSizeGroup.Value;
                table.InitGroups();
                table.IsInit = true;


                Form form = (Form)this.Parent.Parent;
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
