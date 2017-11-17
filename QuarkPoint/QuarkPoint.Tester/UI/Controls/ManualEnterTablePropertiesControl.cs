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
    public partial class ManualEnterTablePropertiesControl : UserControl
    {
        #region constrcutor
        /// <summary>
        /// constructor
        /// </summary>
        public ManualEnterTablePropertiesControl()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        /// <summary>
        /// init control
        /// </summary>
        public void InitControl()
        {
            try
            {
                Top = 15;
                Left = 10;
                if (Program.MainForm.CurrentElement.Table.ColumnsCount>0)
                numColumnsCount.Value= Program.MainForm.CurrentElement.Table.ColumnsCount;

            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// num up down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numColumnsCount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.ColumnsCount = (int)numColumnsCount.Value;
            }
            catch (Exception exception)
            {
            }
        }
        #endregion


    }
}
