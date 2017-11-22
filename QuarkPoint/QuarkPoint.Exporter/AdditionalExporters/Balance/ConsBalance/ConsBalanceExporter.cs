using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using QuarkPoint.Exporter.AdditionalExporters.Balance.BalanceIndicators;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Balance;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Balance.ConsBalance
{
    public static class ConsBalanceExporter
    {
        private static void GenerateHeader(Body body,FinDataBalanceModel mdl)
        {
            try
            {
                string header = "КОНСОЛИДИРОВАННЫЙ БАЛАНС (";
                int count = 0;
                foreach (var company in mdl.Companies)
                {
                    header += "\"" + company.Name + "\"";
                    if (count + 1 < mdl.Companies.Count)
                    {
                        header += ", ";
                    }
                    count++;
                }

                header += ")";

                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;
                
                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Center,
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

                if (v1 && v2) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private static TableRow GenerateRowBySingleDate(string leftTitle, string firstLeftValue,string secondLeftValue,string rightTitle, string firstRightValue,string secondRightValue, bool bold =false, bool fill =false)
        {
            try
            {
                TableRow row = new TableRow();

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
        /// <summary>
        /// generate by single date
        /// </summary>
        /// <param name="body"></param>
        /// <param name="cMdl"></param>
        private static void GenerateBySingleDate(Body body, ConsFinDataBalanceModel model)
        {
            try
            {
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);


                table.Append(GenerateRowBySingleDate("Актив",model.CompanyBalances[0].Date.ToShortDateString(),"", "Пассив", model.CompanyBalances[0].Date.ToShortDateString(),"",true,true));
                table.Append(GenerateRowBySingleDate("Касса", Math.Round(model.CompanyBalances[0].Assets.Checkout.ConsTotal, 2).ToString(), "", "Счета к оплате", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.ConsTotal,2).ToString(),""));
                table.Append(GenerateRowBySingleDate("Расчетный счет", Math.Round(model.CompanyBalances[0].Assets.CurrentAccount.ConsTotal, 2).ToString(), "", "Частные займы (менее 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.ShortPrivateLoans.ConsTotal, 2).ToString(),""));
                table.Append(GenerateRowBySingleDate("Сбережения", Math.Round(model.CompanyBalances[0].Assets.Savings.ConsTotal, 2).ToString(), "", "Банковский кредит (менее 12 месяцев)", Math.Round(model.CompanyBalances[0].Liabilities.ShortCredit.ConsTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Депозит", Math.Round(model.CompanyBalances[0].Assets.Deposit.ConsTotal, 2).ToString(), "", "Прочие текущие задолженности", Math.Round(model.CompanyBalances[0].Liabilities.OtherCurrentDebt.ConsTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Ликвидные средства", Math.Round(model.CompanyBalances[0].ConsLiquidAssets, 2).ToString(), "", "Итого кр.-сроч. зад-ть", Math.Round(model.CompanyBalances[0].ConsTotalShortTermDebt, 2).ToString(), "",true));

                //дебиторка
                table.Append(GenerateRowBySingleDate("Дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.Recievables.ConsTotal, 2).ToString(), "", "Част.займы(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongPrivateLoans.ConsTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Прочая дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.OtherRecievables.ConsTotal, 2).ToString(), "", "Банк.кр.(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongCredit.ConsTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("", "", "", "Прочие пассивы", Math.Round(model.CompanyBalances[0].Liabilities.OtherLiabilities.ConsTotal, 2).ToString(), ""));
                table.Append(GenerateRowBySingleDate("Дебиторская задолженность", Math.Round(model.CompanyBalances[0].ConsReceivables, 2).ToString(), "", "Итого долгосрочная задолженность", Math.Round(model.CompanyBalances[0].ConsTotalLongTermDebt, 2).ToString(), "",true));

                //ТМЗ
                 table.Append(GenerateRowBySingleDate("ТМЗ", Math.Round(model.CompanyBalances[0].ConsInventories, 2).ToString(), "", "Всего кредиторская задолженность", Math.Round(model.CompanyBalances[0].ConsTotalLongAccountsPayable, 2).ToString(),"",true));

                table.Append(GenerateRowBySingleDate("Всего оборотных средств", Math.Round(model.CompanyBalances[0].ConsTotalCurrentAssets, 2).ToString(), "", "", "","",true));
              
                
                 table.Append(GenerateRowBySingleDate("Оборудование", Math.Round(model.CompanyBalances[0].Assets.Hardware.ConsTotal, 2).ToString(), "", "", "",""));
                 table.Append(GenerateRowBySingleDate("Автотранспорт", Math.Round(model.CompanyBalances[0].Assets.MotorTransport.ConsTotal, 2).ToString(), "", "", "",""));
                 table.Append(GenerateRowBySingleDate("Недвижимость", Math.Round(model.CompanyBalances[0].Assets.RealEstate.ConsTotal, 2).ToString(), "", "", "",""));
                 table.Append(GenerateRowBySingleDate("Всего основных средств", Math.Round(model.CompanyBalances[0].ConsTotalFixedAssets, 2).ToString(), "", "Собственный капитал", Math.Round(model.CompanyBalances[0].ConsEquity, 2).ToString(),"",true));

                table.Append(GenerateRowBySingleDate("ИТОГО:", Math.Round(model.CompanyBalances[0].ConsTotalAssets, 2).ToString(), "", "ИТОГО:", Math.Round(model.CompanyBalances[0].ConsTotalLiabilities, 2).ToString(),"",true));
                //table.Append(GenerateRowBySingleDate("", Math.Round(model.CompanyBalances[0].Assets.Checkout.ConsTotal, 2).ToString(), "", "", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.ConsTotal,2).ToString(),""));


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
        private static void GenerateByTwoDates(Body body, ConsFinDataBalanceModel model)
        {
            try
            {
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);


                table.Append(GenerateRowBySingleDate("Актив", model.CompanyBalances[0].Date.ToShortDateString(), model.CompanyBalances[1].Date.ToShortDateString(), "Пассив", model.CompanyBalances[0].Date.ToShortDateString(), model.CompanyBalances[1].Date.ToShortDateString(), true, true));
                table.Append(GenerateRowBySingleDate("Касса", Math.Round(model.CompanyBalances[0].Assets.Checkout.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Checkout.ConsTotal, 2).ToString(), "Счета к оплате", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.PayableAccounts.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Расчетный счет", Math.Round(model.CompanyBalances[0].Assets.CurrentAccount.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.CurrentAccount.ConsTotal, 2).ToString(), "Частные займы (менее 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.ShortPrivateLoans.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.ShortPrivateLoans.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Сбережения", Math.Round(model.CompanyBalances[0].Assets.Savings.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Savings.ConsTotal, 2).ToString(), "Банковский кредит (менее 12 месяцев)", Math.Round(model.CompanyBalances[0].Liabilities.ShortCredit.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.ShortCredit.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Депозит", Math.Round(model.CompanyBalances[0].Assets.Deposit.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Deposit.ConsTotal, 2).ToString(), "Прочие текущие задолженности", Math.Round(model.CompanyBalances[0].Liabilities.OtherCurrentDebt.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.OtherCurrentDebt.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Ликвидные средства", Math.Round(model.CompanyBalances[0].ConsLiquidAssets, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsLiquidAssets, 2).ToString(), "Итого кр.-сроч. зад-ть", Math.Round(model.CompanyBalances[0].ConsTotalShortTermDebt, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalShortTermDebt, 2).ToString(), true));

                //дебиторка
                table.Append(GenerateRowBySingleDate("Дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.Recievables.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Recievables.ConsTotal, 2).ToString(), "Част.займы(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongPrivateLoans.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.LongPrivateLoans.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Прочая дебиторская задолженность", Math.Round(model.CompanyBalances[0].Assets.OtherRecievables.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.OtherRecievables.ConsTotal, 2).ToString(), "Банк.кр.(бол. 12 мес.)", Math.Round(model.CompanyBalances[0].Liabilities.LongCredit.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.LongCredit.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("", "", "", "Прочие пассивы", Math.Round(model.CompanyBalances[0].Liabilities.OtherLiabilities.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Liabilities.OtherLiabilities.ConsTotal, 2).ToString()));
                table.Append(GenerateRowBySingleDate("Дебиторская задолженность", Math.Round(model.CompanyBalances[0].ConsReceivables, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsReceivables, 2).ToString(), "Итого долгосрочная задолженность", Math.Round(model.CompanyBalances[0].ConsTotalLongTermDebt, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalLongTermDebt, 2).ToString(), true));

                //ТМЗ
                table.Append(GenerateRowBySingleDate("ТМЗ", Math.Round(model.CompanyBalances[0].ConsInventories, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsInventories, 2).ToString(), "Всего кредиторская задолженность", Math.Round(model.CompanyBalances[0].ConsTotalLongAccountsPayable, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalLongAccountsPayable, 2).ToString(), true));

                table.Append(GenerateRowBySingleDate("Всего оборотных средств", Math.Round(model.CompanyBalances[0].ConsTotalCurrentAssets, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalCurrentAssets, 2).ToString(), "", "", "", true));


                table.Append(GenerateRowBySingleDate("Оборудование", Math.Round(model.CompanyBalances[0].Assets.Hardware.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.Hardware.ConsTotal, 2).ToString(), "", "", ""));
                table.Append(GenerateRowBySingleDate("Автотранспорт", Math.Round(model.CompanyBalances[0].Assets.MotorTransport.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.MotorTransport.ConsTotal, 2).ToString(), "", "", ""));
                table.Append(GenerateRowBySingleDate("Недвижимость", Math.Round(model.CompanyBalances[0].Assets.RealEstate.ConsTotal, 2).ToString(), Math.Round(model.CompanyBalances[1].Assets.RealEstate.ConsTotal, 2).ToString(), "", "", ""));
                table.Append(GenerateRowBySingleDate("Всего основных средств", Math.Round(model.CompanyBalances[0].ConsTotalFixedAssets, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalFixedAssets, 2).ToString(), "Собственный капитал", Math.Round(model.CompanyBalances[0].ConsEquity, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsEquity, 2).ToString(), true));

                table.Append(GenerateRowBySingleDate("ИТОГО:", Math.Round(model.CompanyBalances[0].ConsTotalAssets, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalAssets, 2).ToString(), "ИТОГО:", Math.Round(model.CompanyBalances[0].ConsTotalLiabilities, 2).ToString(), Math.Round(model.CompanyBalances[1].ConsTotalLiabilities, 2).ToString(), true));
                //table.Append(GenerateRowBySingleDate("", Math.Round(model.CompanyBalances[0].Assets.Checkout.ConsTotal, 2).ToString(), "", "", Math.Round(model.CompanyBalances[0].Liabilities.PayableAccounts.ConsTotal,2).ToString(),""));


                body.Append(table);


            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// export consolidate balance
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="body"></param>
        public static void ExportConsolidateBalance(object currentProject, Body body)
        {
            try
            {
                dynamic obj = currentProject;
                dynamic r_obj = JsonConvert.DeserializeObject(obj.ToString());

                object bObj = r_obj["FinDataBalance"];
                object cObj = r_obj["ConsolidatedBalance"];
                string b = bObj.ToString();
                string c = cObj.ToString();


                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                FinDataBalanceModel mdl = JsonConvert.DeserializeObject<FinDataBalanceModel>(b, settings);

                ConsFinDataBalanceModel cMdl = JsonConvert.DeserializeObject<ConsFinDataBalanceModel>(c, settings);
                GenerateHeader(body,mdl);

                int dataCount = cMdl.CompanyBalances.Count;

                switch (dataCount)
                {
                    case 1:
                        GenerateBySingleDate(body,cMdl);
                    break;

                    case 2:
                        GenerateByTwoDates(body,cMdl) ;
                        break;

                        
                }


                BalanceIndicatorsExporter.ExportIndicatorsByConsolidateBalance(body,cMdl);

            }
            catch (Exception e)
            {

            }
        }
    }
}
