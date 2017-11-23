using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Models.HardModels.Opiu;

namespace QuarkPoint.Exporter.AdditionalExporters.Opiu.Opius
{
    public static class AdditionalOpiuTableExporter
    {
        private static void GenerateTableHeader(Table table, List<string> headers)
        {
            try
            {

            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void ExportLoanContributionDetailsTable(Body body,LoanContributionDetailsModel model)
        {
            try
            {
                List<string> headers = new List<string>()
                {
                    "Заемщик",
                    "БВУ",
                    "Действующие об.",
                    "Вид финансирования",
                    "Лимит финансирования",
                    "Сумма взноса основного долга",
                    "Сумма взноса вознаграждения",
                    "Учитывать полный взнос",
                    "Итого"
                };

                Table table = new Table();


                body.Append(table);

            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExportRelatedCompanyRevenue(Body body, List<object> rows, object total)
        {
            try
            {

            }
            catch (Exception e)
            {
            }
        }
    }
}
