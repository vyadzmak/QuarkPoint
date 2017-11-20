using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Models.ParseModels;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;

namespace QuarkPoint.Exporter.Helpers
{
    public static class TableDataInitializer
    {
        /// <summary>
        /// init manual table
        /// </summary>
        public static void InitManualTableData(object currentProject,TemplateElement element)
        {
            try
            {
                for (int i = 0; i < element.Table.Rows.Count; i++)
                {
                    var row = element.Table.Rows[i];

                    for (int j = 0; j < row.Cells.Count; j++)
                    {
                        var cell = row.Cells[j];

                        var _el = ParseHelper.GetToVars(cell.Value);
                        cell.Value =
                            DataInitializer.InitData(currentProject, _el, cell.Value);
                    }
                }
            }
            catch (Exception e)
            {
                
            }
        }

        /// <summary>
        /// /auto without formatting
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="element"></param>
        public static void InitAutoByDataWithoutFormattingTableData(object currentProject, TemplateElement element)
        {
            try
            {
                List<VariableModel> vars = new List<VariableModel>();

                if (element.Table.Rows.Count==0) return;

                foreach (var cell in element.Table.Rows[0].Cells)
                {
                    vars.AddRange(ParseHelper.GetToVars(cell.Value));
                }
                List<List<string>> data = null;
                List<List<string>> result = DataInitializer.InitArrayData(currentProject, vars);

                element.Table.Rows = new List<RowModel>();
                foreach (var row in result)
                {
                    RowModel r = new RowModel();
                    foreach (var cell in row)
                    {
                        CellModel c = new CellModel();
                        c.Value = cell;
                        r.Cells.Add(c);
                    }
                    element.Table.Rows.Add(r);
                }
                
               
            }
            catch (Exception e)
            {
            }

        }
    }
}
