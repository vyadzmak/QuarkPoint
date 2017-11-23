using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.AdditionalExporters.Balance.Balances;
using QuarkPoint.Exporter.AdditionalExporters.Balance.ConsBalance;
using QuarkPoint.Exporter.AdditionalExporters.Odds;
using QuarkPoint.Exporter.AdditionalExporters.Opiu.ConsOpiu;
using QuarkPoint.Exporter.AdditionalExporters.Opiu.Opius;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;

namespace QuarkPoint.Exporter.Helpers
{
    public static class GenerateProcessor
    {
        /// <summary>
        /// export document
        /// </summary>
        public static void ExportDocument(object currentProject, TemplateModel template, string path)
        {
            try
            {
                var wordDocument = GenerateDocumentHelper.GenerateDocument(path);
                var body = wordDocument.MainDocumentPart.Document.Body;

                foreach (var element in template.Elements)
                {


                    switch (element.ElementType)
                    {
                        case ElementType.Текст:
                            var el = ParseHelper.GetToVars(element.Paragraph.Text);
                            if (el != null && el.Count > 0)
                            {
                                element.Paragraph.Text =
                                    DataInitializer.InitData(currentProject, el, element.Paragraph.Text);
                            }
                            GenerateParagraphHelper.GenerateParagraph(body, element);
                            break;

                        case ElementType.Таблица:

                            switch (element.Table.DataType)
                            {
                                    case DataType.Manual:
                                        TableDataInitializer.InitManualTableData(currentProject,element);
                                    break;

                                case DataType.AutoByDataWithoutFormatting:
                                    TableDataInitializer.InitAutoByDataWithoutFormattingTableData(currentProject, element);
                                    break;

                            }


                            GenerateTableHelper.GenerateTable(body,element);
                            break;

                        case ElementType.Перенос:
                            GenerateNewLineHelper.GenerateNewLine(body);
                            break;

                        case ElementType.КонсБаланс:
                            ConsBalanceExporter.ExportConsolidateBalance(currentProject,body);
                            break;

                        case ElementType.Балансы:
                            BalancesExporter.ExportBalances(currentProject, body);
                            break;

                        case ElementType.КонсОпиу:
                            ConsOpiuExporter.ExportConsolidateOpiu(currentProject,body);
                            break;

                        case ElementType.ОПиУ:
                            OpiusExporter.ExportOpiu(currentProject,body);
                            break;
                        case ElementType.ОДДС:
                            OddsExporter.ExportOdds(currentProject,body);
                            break;

                        case ElementType.РазрывСтраницы:
                            OpiusExporter.AddHoryzontalPage(body);
                            break;
                    }
                }
                wordDocument.Close();
            }
            catch (Exception e)
            {
                
            }
        }

        

        /// <summary>
        /// export element
        /// </summary>
        public static void ExportElement(object currentProject,TemplateElement element, string path)
        {
            try
            {
                var wordDocument = GenerateDocumentHelper.GenerateDocument(path);
                var body = wordDocument.MainDocumentPart.Document.Body;
                switch (element.ElementType)
                {
                    case ElementType.Текст:
                        var el = ParseHelper.GetToVars(element.Paragraph.Text);
                        if (el != null && el.Count > 0)
                        {
                            element.Paragraph.Text =DataInitializer.InitData(currentProject, el, element.Paragraph.Text);
                        }
                        GenerateParagraphHelper.GenerateParagraph(body,element);
                        break;

                    case ElementType.Таблица:
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


                        GenerateTableHelper.GenerateTable(body, element);
                        break;

                    case ElementType.Перенос:
                        GenerateNewLineHelper.GenerateNewLine(body);

                        break;
                }

                wordDocument.Close();
               // Process.Start(path);
            }
            catch (Exception e)
            {

            }
        }
    }
}
