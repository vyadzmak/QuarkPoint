using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;

namespace QuarkPoint.Tester.Helpers.DataLoaders
{
    public static class LoadTableContent
    {
        /// <summary>
        /// load data to body
        /// </summary>
        public static void LoadDataToBody(DataGridView grid)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;

                foreach (var column in table.Columns)
                {
                    grid.Columns.Add(column.Name, column.Name);
                }


                foreach (var row in table.Rows)
                {
                    DataGridViewRow dRow = new DataGridViewRow();
                    foreach (var cell in row.Cells)
                    {
                        DataGridViewCell dCell= new DataGridViewTextBoxCell();
                        dCell.Value = cell.Value;
                        dRow.Cells.Add(dCell);
                    }
                    grid.Rows.Add(dRow);
                }
            }
            catch (Exception e)
            {
            }

        }

        /// <summary>
        /// set table by grid
        /// </summary>
        /// <param name="grid"></param>

        public static void LoadTableContentFromGridBody(DataGridView grid)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;
                table.Rows = new List<RowModel>();
                int rIndex = 0;
                foreach (DataGridViewRow gRow in grid.Rows)
                {
                    RowModel row = new FooterModel() {Index = rIndex};
                    
                    int cIndex = 0;
                    foreach (DataGridViewCell gCell in gRow.Cells)
                    {
                        row.Cells.Add(new CellModel() {Index = cIndex,Value = (string)gCell.Value});
                        cIndex++;
                    }
                    table.Rows.Add(row);
                    rIndex++;

                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
