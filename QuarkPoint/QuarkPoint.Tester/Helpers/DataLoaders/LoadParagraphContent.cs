using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.ParseModels;

namespace QuarkPoint.Tester.Helpers.DataLoaders
{
    public static class LoadParagraphContent
    {
        public static void LoadDataToFormatting(DataGridView grid)
        {
            try
            {
                try
                {
                    var paragraph = Program.MainForm.CurrentElement.Paragraph;

                    grid.Columns.Clear();
                    grid.Columns.Add("From", "From");
                    grid.Columns.Add("To", "To");


                    foreach (var format in paragraph.Formatting)
                    {
                        var dRow = new DataGridViewRow();

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

        /// <summary>
        ///     load data to fomatting
        /// </summary>
        /// <param name="dgvFormatting"></param>
        public static void LoadDataFromFormatting(DataGridView grid)
        {
            try
            {
                var paragraph = Program.MainForm.CurrentElement.Paragraph;
                paragraph.Formatting = new List<ReplaceModel>();
                var rIndex = 0;
                foreach (DataGridViewRow gRow in grid.Rows)
                {
                    string f = gRow.Cells[0].Value!=null ? gRow.Cells[0].Value.ToString():"";
                    string t = gRow.Cells[1].Value!=null ? gRow.Cells[1].Value.ToString():"";
                    if (string.IsNullOrEmpty(f) && string.IsNullOrEmpty(t)) continue;
                    var replaceModel = new ReplaceModel
                    {
                        From = f,
                        To = t
                    };
                    paragraph.Formatting.Add(replaceModel);

                    rIndex++;
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}