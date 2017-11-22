using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Balance;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Balance.ConsBalance
{
    public static class OutBalanceExporter
    {

        private static void GenerateHeader(Body body)
        {
            try
            {
                string header = "Вынесено за баланс";
               

                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Bold,
                    Text = header
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);
            }
            catch (Exception e)
            {

            }
        }

        private static bool ChekEmptyLine(string val1, string val2, string val3, string val4)
        {
            try
            {
                bool v1 = false;
                bool v2 = false;
                bool v3 = false;
                bool v4 = false;


                if (string.IsNullOrEmpty(val1) || val1 == "0") v1 = true;
                if (string.IsNullOrEmpty(val2) || val2 == "0") v2 = true;
                if (string.IsNullOrEmpty(val3) || val3 == "0") v3 = true;
                if (string.IsNullOrEmpty(val4) || val4 == "0") v4 = true;

                if (v1 && v2 && v3 && v4) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        private static bool ChekEmptyPair(string val1, string val2)
        {
            try
            {
                bool v1 = false;
                bool v2 = false;
              


                if (string.IsNullOrEmpty(val1) || val1 == "0") v1 = true;
                if (string.IsNullOrEmpty(val2) || val2 == "0") v2 = true;
                
                if (v1 && v2 ) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #region generators
        private static TableRow GenerateRowBySingleDate(string leftTitle, string firstLeftValue, string secondLeftValue, string rightTitle, string firstRightValue, string secondRightValue, bool bold = false, bool fill = false)
        {
            try
            {

                if (ChekEmptyPair(firstLeftValue, secondLeftValue))
                {
                    leftTitle = "";
                    firstLeftValue = "";
                    secondLeftValue = "";
                }

                if (ChekEmptyPair(firstRightValue, secondRightValue))
                {
                    rightTitle = "";
                    firstRightValue = "";
                    secondRightValue = "";
                }
                if (ChekEmptyLine(firstLeftValue, secondLeftValue, firstRightValue, secondRightValue)) return null;

                TableRow row = new TableRow();
                List<TemplateElement> elements = new List<TemplateElement>();
                #region create elements

                #region left
                TemplateElement leftTitlElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                leftTitlElement.Paragraph = new TemplateParagraph()
                {
                    Text = leftTitle,
                    //BackgroundColor = "#ff0000",
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Normal,
                    FontSize = 9
                };
                if (bold) leftTitlElement.Paragraph.FontWeight = FontWeight.Bold;
                if (fill) leftTitlElement.Paragraph.BackgroundColor = "#f2f2f2";

                elements.Add(leftTitlElement);
                TemplateElement firstLeftValueElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };

                firstLeftValueElement.Paragraph = new TemplateParagraph()
                {
                    Text = firstLeftValue,

                    TextAlign = TextAlign.Center,
                    FontSize = 9
                };
                if (bold) firstLeftValueElement.Paragraph.FontWeight = FontWeight.Bold;
                if (fill) firstLeftValueElement.Paragraph.BackgroundColor = "#f2f2f2";

                elements.Add(firstLeftValueElement);


                TemplateElement secondLeftValueElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                secondLeftValueElement.Paragraph = new TemplateParagraph()
                {
                    Text = secondLeftValue,

                    TextAlign = TextAlign.Center,
                    FontSize = 9
                };
                if (bold) secondLeftValueElement.Paragraph.FontWeight = FontWeight.Bold;
                if (fill) secondLeftValueElement.Paragraph.BackgroundColor = "#f2f2f2";

                if (!string.IsNullOrEmpty(secondLeftValue))
                {
                    elements.Add(secondLeftValueElement);

                }
                #endregion


                #region right
                TemplateElement rightTitlElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                rightTitlElement.Paragraph = new TemplateParagraph()
                {
                    Text = rightTitle,
                    //BackgroundColor = "#ff0000",
                    TextAlign = TextAlign.Left,
                    //FontWeight = FontWeight.Bold,
                    FontSize = 9
                };

                if (bold) rightTitlElement.Paragraph.FontWeight = FontWeight.Bold;
                if (fill) rightTitlElement.Paragraph.BackgroundColor = "#f2f2f2";

                elements.Add(rightTitlElement);
                TemplateElement firstRightValueElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                firstRightValueElement.Paragraph = new TemplateParagraph()
                {
                    Text = firstRightValue,

                    TextAlign = TextAlign.Center,
                    FontSize = 9
                };
                if (bold) firstRightValueElement.Paragraph.FontWeight = FontWeight.Bold;
                if (fill) firstRightValueElement.Paragraph.BackgroundColor = "#f2f2f2";


                elements.Add(firstRightValueElement);

                TemplateElement secondRightValueElement = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                secondRightValueElement.Paragraph = new TemplateParagraph()
                {
                    Text = secondRightValue,

                    TextAlign = TextAlign.Center,
                    FontSize = 9
                };
                if (bold) secondRightValueElement.Paragraph.FontWeight = FontWeight.Bold;
                if (fill) secondRightValueElement.Paragraph.BackgroundColor = "#f2f2f2";

                if (!string.IsNullOrEmpty(secondRightValue))
                {
                    elements.Add(secondRightValueElement);

                }
                #endregion
                #endregion




                foreach (var element in elements)
                {
                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(element, FormattingHelper.FormatTableElements(element, element.Paragraph.Text));


                    tc.Append(paragraph);

                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    row.Append(tc);
                }


                return row;
            }
            catch (Exception e)
            {
                return null;
            }
        }
#endregion
        /// <summary>
        /// generate by single date
        /// </summary>
        /// <param name="body"></param>
        /// <param name="cMdl"></param>
        private static void GenerateBySingleDate(Body body, BalanceModel model)
        {
            try
            {
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);


                table.Append(GenerateRowBySingleDate("Актив", model.CompanyBalances[0].Date.ToShortDateString(), "", "Пассив", model.CompanyBalances[0].Date.ToShortDateString(), "", true, true));
                table.Append(GenerateRowBySingleDate("Касса", Math.Round(model.CompanyBalances[0].Assets.Checkout.OutTotal, 2).ToString(), "", "Счета к оплате", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.OutTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Расчетный счет", Math.Round(model.CompanyBalances[0].Assets.CurrentAccount.OutTotal, 2).ToString(), "", "Частные займы (менее 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.ShortPrivateLoans.OutTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Сбережения", Math.Round(model.CompanyBalances[0].Assets.Savings.OutTotal, 2).ToString(), "", "Банковский кредит (менее 12 месяцев)", Math.Round(model.CompanyBalances[0].Liabilities.ShortCredit.OutTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Депозит", Math.Round(model.CompanyBalances[0].Assets.Deposit.OutTotal, 2).ToString(), "", "Прочие текущие задолженности", Math.Round(model.CompanyBalances[0].Liabilities.OtherCurrentDebt.OutTotal, 2).ToString(), ""));

                //дебиторка
                table.Append(GenerateRowBySingleDate("Дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.Recievables.OutTotal, 2).ToString(), "", "Част.займы(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongPrivateLoans.OutTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Прочая дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.OtherRecievables.OutTotal, 2).ToString(), "", "Банк.кр.(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongCredit.OutTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("", "", "", "Прочие пассивы", Math.Round(model.CompanyBalances[0].Liabilities.OtherLiabilities.OutTotal, 2).ToString(), ""));

                //ТМЗ
                table.Append(GenerateRowBySingleDate("Оборудование", Math.Round(model.CompanyBalances[0].Assets.Hardware.OutTotal, 2).ToString(), "", "", "", ""));
                table.Append(GenerateRowBySingleDate("Автотранспорт", Math.Round(model.CompanyBalances[0].Assets.MotorTransport.OutTotal, 2).ToString(), "", "", "", ""));
                table.Append(GenerateRowBySingleDate("Недвижимость", Math.Round(model.CompanyBalances[0].Assets.RealEstate.OutTotal, 2).ToString(), "", "", "", ""));

                table.Append(GenerateRowBySingleDate("ИТОГО:", Math.Round(model.CompanyBalances[0].OutTotalAssets, 2).ToString(), "", "ИТОГО:", Math.Round(model.CompanyBalances[0].OutTotalLiabilities, 2).ToString(), "", true));
                //table.Append(GenerateRowBySingleDate("", Math.Round(model.CompanyBalances[0].Assets.Checkout.OutTotal, 2).ToString(), "", "", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.OutTotal,2).ToString(),""));


                body.Append(table);


            }
            catch (Exception e)
            {
            }
        }



        /// <summary>
        /// generate by single date
        /// </summary>
        /// <param name="body"></param>
        /// <param name="cMdl"></param>
        private static void GenerateByTwoDates(Body body, BalanceModel model)
        {
            try
            {
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);


                table.Append(GenerateRowBySingleDate("Актив", model.CompanyBalances[0].Date.ToShortDateString(), model.CompanyBalances[1].Date.ToShortDateString(), "Пассив", model.CompanyBalances[0].Date.ToShortDateString(), model.CompanyBalances[1].Date.ToShortDateString(), true, true));
                table.Append(GenerateRowBySingleDate("Касса", Math.Round(model.CompanyBalances[0].Assets.Checkout.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Checkout.OutTotal, 2).ToString(), "Счета к оплате", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.PayableAccounts.OutTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Расчетный счет", Math.Round(model.CompanyBalances[0].Assets.CurrentAccount.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.CurrentAccount.OutTotal, 2).ToString(), "Частные займы (менее 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.ShortPrivateLoans.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.ShortPrivateLoans.OutTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Сбережения", Math.Round(model.CompanyBalances[0].Assets.Savings.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Savings.OutTotal, 2).ToString(), "Банковский кредит (менее 12 месяцев)", Math.Round(model.CompanyBalances[0].Liabilities.ShortCredit.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.ShortCredit.OutTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Депозит", Math.Round(model.CompanyBalances[0].Assets.Deposit.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Deposit.OutTotal, 2).ToString(), "Прочие текущие задолженности", Math.Round(model.CompanyBalances[0].Liabilities.OtherCurrentDebt.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.OtherCurrentDebt.OutTotal, 2).ToString()));

                //дебиторка
                table.Append(GenerateRowBySingleDate("Дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.Recievables.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Recievables.OutTotal, 2).ToString(), "Част.займы(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongPrivateLoans.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.LongPrivateLoans.OutTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Прочая дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.OtherRecievables.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.OtherRecievables.OutTotal, 2).ToString(), "Банк.кр.(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongCredit.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.LongCredit.OutTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("", "", "", "Прочие пассивы", Math.Round(model.CompanyBalances[0].Liabilities.OtherLiabilities.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.OtherLiabilities.OutTotal, 2).ToString()));


                table.Append(GenerateRowBySingleDate("Оборудование", Math.Round(model.CompanyBalances[0].Assets.Hardware.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Hardware.OutTotal, 2).ToString(), "", "", ""));
                table.Append(GenerateRowBySingleDate("Автотранспорт", Math.Round(model.CompanyBalances[0].Assets.MotorTransport.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.MotorTransport.OutTotal, 2).ToString(), "", "", ""));
                table.Append(GenerateRowBySingleDate("Недвижимость", Math.Round(model.CompanyBalances[0].Assets.RealEstate.OutTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.RealEstate.OutTotal, 2).ToString(), "", "", ""));

                table.Append(GenerateRowBySingleDate("ИТОГО:", Math.Round(model.CompanyBalances[0].OutTotalAssets, 2).ToString(), Math.Round(model.CompanyBalances[1].OutTotalAssets, 2).ToString(), "ИТОГО:", Math.Round(model.CompanyBalances[0].OutTotalLiabilities, 2).ToString(), Math.Round(model.CompanyBalances[1].OutTotalLiabilities, 2).ToString(), true));
                //table.Append(GenerateRowBySingleDate("", Math.Round(model.CompanyBalances[0].Assets.Checkout.OutTotal, 2).ToString(), "", "", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.OutTotal,2).ToString(),""));


                body.Append(table);


            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// generate out consolidate balance
        /// </summary>
        /// <param name="body"></param>
        /// <param name="model"></param>
        public static void GenerateOutConsolidateBalance(Body body, BalanceModel model)
        {
            try
            {
                Run run = new Run();
                run.Append(new Break());

                var tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);
                int dataCount = model.CompanyBalances.Count;
                GenerateHeader(body);
                switch (dataCount)
                {
                    case 1:
                        GenerateBySingleDate(body, model);
                        break;

                    case 2:
                        GenerateByTwoDates(body, model);
                        break;


                }
                run = new Run();
                run.Append(new Break());

                tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);
            }
            catch (Exception e)
            {
            }
        }
    }
}
