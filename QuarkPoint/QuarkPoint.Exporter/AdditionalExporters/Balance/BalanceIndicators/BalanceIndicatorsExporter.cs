using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Balance;
using QuarkPoint.Exporter.Models.TemplateModels;
using Break = DocumentFormat.OpenXml.Wordprocessing.Break;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;

namespace QuarkPoint.Exporter.AdditionalExporters.Balance.BalanceIndicators
{
    public static  class BalanceIndicatorsExporter
    {

        private static TableRow AddIndicatorRow(string name, double? value=null)
        {
            try
            {
                TableRow row = new TableRow();

                #region name
                TemplateElement nameElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                nameElement.Paragraph = new TemplateParagraph()
                {
                    Text = name,
                    FontWeight = FontWeight.Bold,
                    TextAlign = TextAlign.Center,
                    FontSize = 9
                };
                if (value!=null) nameElement.Paragraph.FontWeight = FontWeight.Normal;

                var tc = new TableCell();
                Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(nameElement, FormattingHelper.FormatTableElements(nameElement, nameElement.Paragraph.Text));
                tc.Append(paragraph);
                tc.Append(new TableCellProperties(
                    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                row.Append(tc);
                #endregion

                #region name

                if (value != null) value = Math.Round((double)value, 2);
                string sValue = value.ToString();
                if (value == null) sValue = "";
                
                    TemplateElement valueElement = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };


                    valueElement.Paragraph = new TemplateParagraph()
                    {
                        Text = sValue,
                        FontWeight = FontWeight.Normal,
                        TextAlign = TextAlign.Center,
                        FontSize = 9
                    };

                    var tc2 = new TableCell();
                    Paragraph paragraph2 = GenerateTableHelper.InitDefaultCellStyle(nameElement,
                        FormattingHelper.FormatTableElements(valueElement, valueElement.Paragraph.Text));
                    tc2.Append(paragraph2);
                    tc2.Append(new TableCellProperties(
                        new TableCellWidth {Type = TableWidthUnitValues.Auto}));
                    row.Append(tc2);


                #endregion
               


                return row;
            }
            catch (Exception e)
            {
                return new TableRow();
            }
        }


        /// <summary>
        /// by consolidate balance
        /// </summary>
        /// <param name="body"></param>
        /// <param name="model"></param>
        public static void ExportIndicatorsByConsolidateBalance(Body body, ConsFinDataBalanceModel model)
        {
            try
            {
                Run run = new Run();
                run.Append(new Break());

                var tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);
                string header = "Показатели:";
                

                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Bold,
                    Text = header
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);


                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);
                table.Append(AddIndicatorRow("Индикторы ликвидности"));
                table.Append(AddIndicatorRow("Коэффициент срочной ликвидности", model.UrgentLiquidityCoef));
                table.Append(AddIndicatorRow("Коэффициент текущей ликвидности", model.CurrentLiquidityCoef));


                table.Append(AddIndicatorRow("Показатели управления рабочим капиталом"));
                table.Append(AddIndicatorRow("Чистый оборотный капитал", model.NetWorkingCapital));
                table.Append(AddIndicatorRow("Срок оборачиваемости дебиторов (дн.)", model.DebtorsTurnoverTerm));
                table.Append(AddIndicatorRow("Срок оборачиваемости ТМЗ (дн.)", model.InventoriesTurnoverTerm));
                table.Append(AddIndicatorRow("Срок оборачиваемости кредиторов (дн.)", model.CreditorsTurnoverTerm));
                table.Append(AddIndicatorRow("Операционный цикл (дн.)", model.OperationCycle));
                table.Append(AddIndicatorRow("Финансовый цикл (дн.)", model.FinancialCycle));


                table.Append(AddIndicatorRow("Показатели рентабельности, в %"));
                table.Append(AddIndicatorRow("Валовая рентабельность", model.GrossProfitability));
                table.Append(AddIndicatorRow("Рентабельность до уплаты %% и КПН", model.ProfitabilityBeforeTaxes));
                table.Append(AddIndicatorRow("Чистая рентабельность", model.NetProfitability));
                table.Append(AddIndicatorRow("Коэффициент покрытия %%", model.CoverageRate));
                table.Append(AddIndicatorRow("ROE", model.ROE));
                table.Append(AddIndicatorRow("ROA", model.ROA));

                table.Append(AddIndicatorRow("Показатели финансовой устойчивости"));
                table.Append(AddIndicatorRow("Отношение фин. долга к активам", model.DebtAssetsRatio));
                table.Append(AddIndicatorRow("Доля собственного капитала в активах, (коэффициент автономии)", model.AutonomyCoef));

                table.Append(AddIndicatorRow("Прочие показатели"));
                table.Append(AddIndicatorRow("Скорость товарооборота", model.TurnoverSpeedCoef));
                table.Append(AddIndicatorRow("Коэффициент оборачиваемости запасов", model.TurnoverInventoryCoef));

                table.Append(AddIndicatorRow("Коэффициент собственного капитала №1",model.Equity1Coef));

                
                body.Append(table);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// by consolidate balance
        /// </summary>
        /// <param name="body"></param>
        /// <param name="model"></param>
        public static void ExportIndicatorsByBalance(Body body, BalanceModel model)
        {
            try
            {
                Run run = new Run();
                run.Append(new Break());

                var tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);
                string header = "Показатели:";


                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Bold,
                    Text = header
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);


                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);
                table.Append(AddIndicatorRow("Индикторы ликвидности"));
                table.Append(AddIndicatorRow("Коэффициент срочной ликвидности", model.UrgentLiquidityCoef));
                table.Append(AddIndicatorRow("Коэффициент текущей ликвидности", model.CurrentLiquidityCoef));


                table.Append(AddIndicatorRow("Показатели управления рабочим капиталом"));
                table.Append(AddIndicatorRow("Чистый оборотный капитал", model.NetWorkingCapital));
                table.Append(AddIndicatorRow("Срок оборачиваемости дебиторов (дн.)", model.DebtorsTurnoverTerm));
                table.Append(AddIndicatorRow("Срок оборачиваемости ТМЗ (дн.)", model.InventoriesTurnoverTerm));
                table.Append(AddIndicatorRow("Срок оборачиваемости кредиторов (дн.)", model.CreditorsTurnoverTerm));
                table.Append(AddIndicatorRow("Операционный цикл (дн.)", model.OperationCycle));
                table.Append(AddIndicatorRow("Финансовый цикл (дн.)", model.FinancialCycle));


                table.Append(AddIndicatorRow("Показатели рентабельности, в %"));
                table.Append(AddIndicatorRow("Валовая рентабельность", model.GrossProfitability));
                table.Append(AddIndicatorRow("Рентабельность до уплаты %% и КПН", model.ProfitabilityBeforeTaxes));
                table.Append(AddIndicatorRow("Чистая рентабельность", model.NetProfitability));
                table.Append(AddIndicatorRow("Коэффициент покрытия %%", model.CoverageRate));
                table.Append(AddIndicatorRow("ROE", model.ROE));
                table.Append(AddIndicatorRow("ROA", model.ROA));

                table.Append(AddIndicatorRow("Показатели финансовой устойчивости"));
                table.Append(AddIndicatorRow("Отношение фин. долга к активам", model.DebtAssetsRatio));
                table.Append(AddIndicatorRow("Доля собственного капитала в активах, (коэффициент автономии)", model.AutonomyCoef));

                table.Append(AddIndicatorRow("Прочие показатели"));
                table.Append(AddIndicatorRow("Скорость товарооборота", model.TurnoverSpeedCoef));
                table.Append(AddIndicatorRow("Коэффициент оборачиваемости запасов", model.TurnoverInventoryCoef));

                table.Append(AddIndicatorRow("Коэффициент собственного капитала №1", model.Equity1Coef));


                body.Append(table);
            }
            catch (Exception e)
            {
            }
        }
    }
}
