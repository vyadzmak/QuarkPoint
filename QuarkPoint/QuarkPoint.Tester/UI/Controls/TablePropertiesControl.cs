using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class TablePropertiesControl : UserControl
    {
        #region constrcutor
        /// <summary>
        /// constructor
        /// </summary>
        public TablePropertiesControl()
        {
            InitializeComponent();
        }
        #endregion

        #region init controls
        /// <summary>
        /// init controls
        /// </summary>
        public void InitControl()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                var table = Program.MainForm.CurrentElement.Table;
                txtTableName.DataBindings.Add("Text",
                    Program.MainForm.CurrentElement,
                    "Title",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);

                if (!table.IsInit)
                {
                   this.tcTableProperties.TabPages.Remove(this.tpHeaders);
                   this.tcTableProperties.TabPages.Remove(this.tpFooters);
                   this.tcTableProperties.TabPages.Remove(this.tpBody);
                    rbManual.Checked = true;

                    chbUseFooters.Checked = Program.MainForm.CurrentElement.Table.UseFooters;
                    chbUseHeaders.Checked = Program.MainForm.CurrentElement.Table.UseHeaders;
                }
                else
                {
                    gbConfirm.Enabled = false;
                    gbDetails.Enabled = false;
                    gbSelectType.Enabled = false;

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

                    chbUseFooters.Checked= Program.MainForm.CurrentElement.Table.UseFooters;
                    chbUseHeaders.Checked= Program.MainForm.CurrentElement.Table.UseHeaders;
                }
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region events
        /// <summary>
        /// load controls
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
        /// rb manual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.DataType = DataType.Manual;
                ManualEnterTablePropertiesControl control = new ManualEnterTablePropertiesControl();
                control.InitControl();
                LoadControl(control);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// rb auto without format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAutoWithoutFormat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.DataType = DataType.AutoByDataWithoutFormatting;
                AutoBindingWithoutFormattingTableControl control = new AutoBindingWithoutFormattingTableControl();
                control.InitControl();
                LoadControl(control);
            }
            catch (Exception exception)
            {
                
            }
        }

        /// <summary>
        /// rb auto with format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAutoWithFormat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.CurrentElement.Table.DataType = DataType.AutoByDataWithFormatting;
                AutoBindingWithFormattingTableControl control = new AutoBindingWithFormattingTableControl();
                control.InitControl();
                LoadControl(control);
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// check box use headers events
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
        /// check box use footers events
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
        #endregion


    }
}
