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
        /// init control
        /// </summary>
        public void InitControl()
        {
            try
            {
                this.Dock = DockStyle.Fill;
            }
            catch (Exception exception)
            {

            }
        }
        #endregion
    }
}
