using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class TablePropertiesControl : UserControl
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TablePropertiesControl()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        /// <summary>
        /// init components by table type
        /// </summary>
        private void InitComponentsByType()
        {
            try
            {

            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// init control
        /// </summary>
        public void InitControl()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                var table = Program.MainForm.CurrentElement.Table;
                if (!table.IsInit)
                {
                    TableSettingsForm form = new TableSettingsForm();
                    form.ShowDialog();
                    this.tcTableProperties.Hide();
                    
                }
                else
                {
                    
                }

            }
            catch (Exception exception)
            {

            }
        }
        #endregion
    }
}
