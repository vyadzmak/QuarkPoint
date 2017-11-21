using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.ParseModels;
using QuarkPoint.Exporter.Models.TemplateModels.AdditionalTableModels;

namespace QuarkPoint.Tester.UI.Controls
{
    public partial class AutoBindingWithoutFormattingTableControl : UserControl
    {
        /// <summary>
        /// current value
        /// </summary>
        private VariableModel currentVariable = null;

        /// <summary>
        /// source data
        /// </summary>
        private string SourceData = "";

        private int CurrentColumnIndex = -1;

        private bool isLoading = false;
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public AutoBindingWithoutFormattingTableControl()
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
                isLoading = true;
                var element = Program.MainForm.CurrentElement;
                txtSourceData.Text = element.Table.DataSource;
                string sourceData = txtSourceData.Text;
                this.SourceData = sourceData;

                
                if (!string.IsNullOrEmpty(sourceData))
                {
                    var variable = ParseHelper.GetToVars(sourceData).FirstOrDefault();
                    if (variable == null)
                        return;
                    currentVariable = variable;

                    chlbFields.Items.Clear();

                    if (element.Table.Rows.Count>0)
                    foreach (var arrayElement in element.Table.Rows[0].Cells)
                    {
                            var name = arrayElement.Value.Replace("{","").Replace("}","").Split('.').ToList().LastOrDefault();


                        chlbFields.Items.Add(name, true);
                    }

                }
                isLoading = false;
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region control events
        /// <summary>
        /// get to fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFieldBindings_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceData = txtSourceData.Text;
                this.SourceData = sourceData;
                var currentProject = Program.MainForm.CurrentProject;
                if (!string.IsNullOrEmpty(sourceData))
                {
                    var variable = ParseHelper.GetToVars(sourceData).FirstOrDefault();
                    if (variable == null)
                        return;
                    currentVariable = variable;

                    List<string> arrayElements = JHelper.GetToArrayElements(currentProject, variable);
                    chlbFields.Items.Clear();

                    List<ColumnEnabledModel> columns = new List<ColumnEnabledModel>();
                    foreach (var arrayElement in arrayElements)
                    {
                        string name = variable.Name.Replace("{","").Replace("}", "");
                        name = "{"+name + "." + arrayElement+"}";
                        columns.Add(new ColumnEnabledModel() {Checked =true, Name = name});
                        chlbFields.Items.Add(arrayElement, true);
                    }

                    Program.MainForm.CurrentElement.Table.InitColumnsWithVariable(columns);
                }
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
        private void chlbFields_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }


        #endregion

        private void chlbFields_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (isLoading) return;
                if (chlbFields.Items.Count == 0) return;
                int index = 0;
                //chlbFields.SetItemCheckState(e.Index,e.NewValue);
                List<ColumnEnabledModel> columns = new List<ColumnEnabledModel>();
                
                foreach (var item in chlbFields.Items)
                {
                    bool check = chlbFields.GetItemChecked(index);

                    if (index == e.Index)
                    {
                        switch (e.NewValue)
                        {
                            case CheckState.Checked:
                                check = true;
                                break;

                            case CheckState.Unchecked:
                                check = false;
                                break;


                        }
                    }

                    if (check)
                    {
                        string name = currentVariable.Name.Replace("{", "").Replace("}", "");
                        name = "{" + name + "." + item.ToString() + "}";

                        columns.Add(new ColumnEnabledModel() { Checked = true, Name = name });
                    }

                    index++;
                }
                Program.MainForm.CurrentElement.Table.DataSource = this.SourceData;
                Program.MainForm.CurrentElement.Table.InitColumnsWithVariable(columns);
            }
            catch (Exception exception)
            {

            }
        }

        private void chlbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentColumnIndex = chlbFields.SelectedIndex;
            }
            catch (Exception exception)
            {

            }
        }

        private void btnUpElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentColumnIndex-1<0) return;

                int prevIndex = CurrentColumnIndex - 1;

                var prevItem = chlbFields.Items[prevIndex];
                var currItem = chlbFields.Items[CurrentColumnIndex];

                var tmpItem = prevItem;
                chlbFields.Items[prevIndex] = currItem;
                chlbFields.Items[CurrentColumnIndex] = tmpItem;

                chlbFields.SelectedIndex = prevIndex;

                List<ColumnEnabledModel> columns = new List<ColumnEnabledModel>();

                foreach (var item in chlbFields.Items)
                {
                    string name = txtSourceData.Name.Replace("{", "").Replace("}", "");

                    name = "{" + name + "." + item + "}";
                    columns.Add(new ColumnEnabledModel() { Checked = true, Name = name });
                }

                Program.MainForm.CurrentElement.Table.InitColumnsWithVariable(columns);
            }
            catch (Exception exception)
            {
                
            }
        }

        private void btnDownElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentColumnIndex+1 >= chlbFields.Items.Count) return;

                int nextIndex = CurrentColumnIndex + 1;

                var nextItem = chlbFields.Items[nextIndex];
                var currItem = chlbFields.Items[CurrentColumnIndex];

                var tmpItem = nextItem;
                chlbFields.Items[nextIndex] = currItem;
                chlbFields.Items[CurrentColumnIndex] = tmpItem;

                chlbFields.SelectedIndex = nextIndex;

                List<ColumnEnabledModel> columns = new List<ColumnEnabledModel>();

                foreach (var item in chlbFields.Items)
                {
                    string name = txtSourceData.Name.Replace("{", "").Replace("}", "");

                    name = "{" + name + "." + item + "}";
                    columns.Add(new ColumnEnabledModel() { Checked = true, Name = name });
                }

                Program.MainForm.CurrentElement.Table.InitColumnsWithVariable(columns);
            }
            catch (Exception exception)
            {
            }
        }
    }
}
