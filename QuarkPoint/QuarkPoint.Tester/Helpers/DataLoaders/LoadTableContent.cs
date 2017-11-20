using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.ParseModels;
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
                grid.Columns.Clear();
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
        /// load data to body
        /// </summary>
        public static void LoadDataToHeaders(DataGridView grid)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;
                var headers = table.Headers;
                grid.Columns.Clear();
                foreach (var column in table.Columns)
                {
                    grid.Columns.Add(column.Name, column.Name);
                }


                foreach (var header in table.Headers)
                {
                    DataGridViewRow dRow = new DataGridViewRow();
                    foreach (var cell in header.Cells)
                    {
                        DataGridViewCell dCell = new DataGridViewTextBoxCell();
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
        /// check row is empty
        /// </summary>
        /// <returns></returns>
        private static bool RowIsEmpty(DataGridViewRow gRow)
        {
            try
            {
                foreach (DataGridViewCell cell in gRow.Cells)
                {
                    if (!string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                return true;
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
                    if (RowIsEmpty(gRow))
                    {
                        continue;
                        
                    }
                    RowModel row = new RowModel() {Index = rIndex};
                    
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

        /// <summary>
        /// set table by grid
        /// </summary>
        /// <param name="grid"></param>

        public static void LoadHeaderFromGridBody(DataGridView grid)
        {
            try
            {
                var table = Program.MainForm.CurrentElement.Table;
                table.Headers = new List<HeaderModel>();
                int rIndex = 0;
                foreach (DataGridViewRow gRow in grid.Rows)
                {
                    if (RowIsEmpty(gRow))
                    {
                        continue;

                    }
                    HeaderModel headerModel = new HeaderModel() { Index = rIndex };

                    int cIndex = 0;
                    foreach (DataGridViewCell gCell in gRow.Cells)
                    {
                        headerModel.Cells.Add(new CellModel() { Index = cIndex, Value = (string)gCell.Value });
                        cIndex++;
                    }
                    table.Headers.Add(headerModel);
                    rIndex++;

                }
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// load data to fomatting
        /// </summary>
        /// <param name="dgvFormatting"></param>

        public static void LoadDataFromFormatting(DataGridView grid)
        {
            var table = Program.MainForm.CurrentElement.Table;
            table.Formatting = new List<ReplaceModel>();
            int rIndex = 0;
            foreach (DataGridViewRow gRow in grid.Rows)
            {
                if (RowIsEmpty(gRow))
                {
                    continue;

                }
                ReplaceModel replaceModel = new ReplaceModel() {From = gRow.Cells[0].Value.ToString(), To = gRow.Cells[1].Value.ToString() };
                table.Formatting.Add(replaceModel);

                rIndex++;

            }
        }

        public static void LoadDataToFormatting(DataGridView grid)
        {
            try
            {
                try
                {
                    var table = Program.MainForm.CurrentElement.Table;
                    
                    grid.Columns.Clear();
                    grid.Columns.Add("From", "From");
                    grid.Columns.Add("To", "To");
                    

                    foreach (var format in table.Formatting)
                    {
                        DataGridViewRow dRow = new DataGridViewRow();
                        
                            DataGridViewCell fromCell = new DataGridViewTextBoxCell();
                            fromCell.Value = format.From;
                            dRow.Cells.Add(fromCell);

                        DataGridViewCell toCell = new DataGridViewTextBoxCell();
                        toCell.Value = format.To;
                        dRow.Cells.Add(toCell);
                        grid.Rows.Add(dRow);
                    }
                }
                catch (Exception e)
                {
                }
            }
            catch (Exception e)
            {
                
                
            }
        }
    }
}
