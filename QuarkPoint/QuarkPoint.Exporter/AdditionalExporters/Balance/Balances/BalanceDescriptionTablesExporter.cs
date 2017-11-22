using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Linq;
using QuarkPoint.Exporter.AdditionalModels;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Balance;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Balance.Balances
{
    public  static class BalanceDescriptionTablesExporter
    {
        private static List<BalanceHeaderModel> headers =new List<BalanceHeaderModel>();
        private static int tableIndex = 1;
        /// <summary>
        /// init single header
        /// </summary>
        private static void InitSingleBalanceHeader(BalanceHeaderModel model, Dictionary<string,string> values)
        {
            try
            {
                foreach (var value in values)
                {
                    model.InitHeader(value.Key,value.Value);
                }
                headers.Add(model);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// init header
        /// </summary>
        /// <param name="name"></param>
        /// <param name="names"></param>
        /// <param name="titles"></param>
        private static void InitHeader(string name, List<string> names, List<string> titles)
        {
            try
            {
                BalanceHeaderModel model = new BalanceHeaderModel(name);
                Dictionary<string, string> dict = new Dictionary<string, string>();
                for (int i = 0; i < names.Count; i++)
                {
                    string _n = names[i];
                    string _t = titles[i];
                    dict.Add(_n,_t);
                }
                InitSingleBalanceHeader(model,dict);
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// init headers
        /// </summary>
        private static void InitBalanceHeaders()
        {
            try
            {
                #region actives
                //checkout
                InitHeader("Checkout",new List<string>()
                {
                    "Name",
                    "Sum",
                    "NotConfirmed",
                    "OutBusiness"
                }, new List<string>()
                {
                    "Наименование",
                    "Сумма",
                    "Сумма не подтв.",
                    "Сумма вне бизнеса"
                });

                //current account
                InitHeader("CurrentAccount", new List<string>()
                {
                    
                    "Sum",
                    "Document",
                    
                }, new List<string>()
                {
                    
                    "Сумма",
                    "Документ",
                    
                });

                //Savings
                InitHeader("Savings", new List<string>()
                {
                   
                    "Sum",
                    "NotConfirmed",
                    "OutBusiness"
                }, new List<string>()
                {
                    
                    "Сумма",
                    "Сумма не подтв.",
                    "Сумма вне бизнеса"
                });

                //Deposit
                InitHeader("Deposit", new List<string>()
                {

                    "Sum",
                    "NotConfirmed",
                    "OutBusiness"
                }, new List<string>()
                {

                    "Сумма",
                    "Сумма не подтв.",
                    "Сумма вне бизнеса"
                });

                //Recievables
                InitHeader("Recievables", new List<string>()
                {

                    "Name",
                    "Sum",
                    "OccurDate",
                    "ReturnDate",
                    "IsRelatedCompany",
                    "NoReturn",
                    "Notes",
                    
                }, new List<string>()
                {

                    "Дебитор",
                    "Сумма",
                    "Дата возникновения",
                    "Дата возврата",
                    "Аффилирован.",
                    "Нет возврата",
                    "Примечания",
                    
                });

                //OtherRecievables
                InitHeader("OtherRecievables", new List<string>()
                {

                    "Name",
                    "Sum",
                    "OccurDate",
                    "ReturnDate",
                    "IsRelatedCompany",
                    "NoReturn",
                    "Notes",

                }, new List<string>()
                {

                    "Дебитор",
                    "Сумма",
                    "Дата возникновения",
                    "Дата возврата",
                    "Аффилирован.",
                    "Нет возврата",
                    "Примечания",

                });

                
                //Inventories
                InitHeader("Inventories", new List<string>()
                {

                    "Name",
                    "Quantity",
                    "CostPerUnit",
                    "Sum",
                   

                }, new List<string>()
                {

                    "Наименование",
                    "Количество",
                    "Стоимость за ед.",
                    "Стоимость общая"

                });


                
                //Hardware
                InitHeader("Hardware", new List<string>()
                {

                    "Name",
                    "ProdYear",
                    "Quantity",
                    "CostB1",
                    "CostB2",
                    "Revalue",
                    "Notes",
                    

                }, new List<string>()
                {


                    "Наименование",
                    "Год выпуска",
                    "Количество",
                    "Рыночная стоимость в Б1",
                    "Рыночная стоимость в Б2",
                    "Переоценка",
                    "Примечания",

                });

                //MotorTransport
                InitHeader("MotorTransport", new List<string>()
                {

                    "Name",
                    "ProdYear",
                    "License",
                    "Color",
                    "Quantity",
                    "CostB1",
                    "CostB2",
                    "Revalue",
                    "Notes",


                }, new List<string>()
                {
                    "Марка, модель",
                    "Год выпуска",
                    "Гос. номер",
                    "Цвет",
                    "Количество",
                    "Рыночная стоимость в Б1",
                    "Рыночная стоимость в Б2",
                    "Переоценка",
                    "Примечания",

                });

                //RealEstate
                InitHeader("RealEstate", new List<string>()
                {

                    "Name",
                    "Address",
                    "Area",
                    "CostB1",
                    "CostB2",
                    "Revalue"
                }, new List<string>()
                {
                    
                    "Наименование",
                    "Местонахождение",
                    "Площадь",
                    "Рыночная стоимость в Б1",
                    "Рыночная стоимость в Б2",
                    "Переоценка",

                });

                //Investments
                InitHeader("Investments", new List<string>()
                {
                    "Name",
                    "Sum",
                    "Date",
                    "Notes"
                }, new List<string>()
                {

                    "Наименование",
                    "Стоимость затрат",
                    "Дата",
                    "Примечания"

                });
                #endregion

                #region passives
                //PayableAccounts
                InitHeader("PayableAccounts", new List<string>()
                {
                   "Name",
                   "Sum",
                   "ArrearsDate",
                   "MaturityDate",
                   "IsRelatedCompany",
                   "Notes",

                }, new List<string>()
                {

                    "Кредитор",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Аффилирован.",
                    "Примечания",

                });

                //ShortPrivateLoans
                InitHeader("ShortPrivateLoans", new List<string>()
                {
                    "Name",
                    "Sum",
                    "ArrearsDate",
                    "MaturityDate",
                    "IsRelatedCompany",
                    "Notes",

                }, new List<string>()
                {

                    "Кредитор",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Аффилирован.",
                    "Примечания"
                });

                //ShortCredit
                InitHeader("ShortCredit", new List<string>()
                {
                    
                    "Name",
                    "Sum",
                    "ArrearsDate",
                    "MaturityDate",
                    "Notes"
                }, new List<string>()
                {
                    "Банк",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Примечания"
                });

                //ShortFixedAssetsCredit
                InitHeader("ShortFixedAssetsCredit", new List<string>()
                {

                    "Name",
                    "Sum",
                    "ArrearsDate",
                    "MaturityDate",
                    "Notes"
                }, new List<string>()
                {
                    "Банк",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Примечания"
                });


                //LongPrivateLoans
                InitHeader("LongPrivateLoans", new List<string>()
                {
                    "Name",
                    "Sum",
                    "ArrearsDate",
                    "MaturityDate",
                    "IsRelatedCompany",
                    "Notes",

                }, new List<string>()
                {

                    "Кредитор",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Аффилирован.",
                    "Примечания"
                });

                //LongCredit
                InitHeader("LongCredit", new List<string>()
                {

                    "Name",
                    "Sum",
                    "ArrearsDate",
                    "MaturityDate",
                    "Notes"
                }, new List<string>()
                {
                    "Банк",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Примечания"
                });


                //OtherLiabilities
                InitHeader("OtherLiabilities", new List<string>()
                {
                    "Name",
                    "Sum",
                    "ArrearsDate",
                    "MaturityDate",
                    "IsRelatedCompany",
                    "Notes",

                }, new List<string>()
                {

                    "Кредитор",
                    "Сумма",
                    "Дата возникновения",
                    "Дата погашения",
                    "Аффилирован.",
                    "Примечания"
                });

                #endregion
            }
            catch (Exception e)
            {
                
            }
        }
        /// <summary>
        /// export description table
        /// </summary>
        private static void ExportDescriptionTable(Body body,string name, string title, object rows)
        {
            try
            {
                if (rows==null) return;
                
                dynamic r = rows;
                if (r.Count ==0) return;
                
                var fElement = r[0];

                if (fElement==null ) return;

                List<string> fields = new List<string>();
                JObject attributesAsJObject = fElement;
                Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                foreach (string key in values.Keys)
                {
                    if (key!="$$hashKey")
                    fields.Add(key);
                }

                var header = headers.FirstOrDefault(x => x.TableName.Equals(name));
                if (header==null) return;


                //insert text before table
                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Bold,
                    Text =tableIndex.ToString()+". " +title
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);
                //insert headers
                TableRow tHeader = new TableRow();
                foreach (var hElement in header.Elements)
                {
                    TemplateElement tElement = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };

                    tElement.Paragraph = new TemplateParagraph()
                    {
                        TextAlign = TextAlign.Center,
                        FontWeight = FontWeight.Bold,
                        Text = hElement.Title
                    };

                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(tElement, FormattingHelper.FormatTableElements(tElement, tElement.Paragraph.Text));
                    tc.Append(paragraph);

                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    tHeader.Append(tc);
                }
                table.Append(tHeader);
                // insert body

                foreach (var row in r)
                {
                    TableRow bodyRow = new TableRow();
                    foreach (var e in header.Elements)
                    {
                        JValue value = row[e.Name];
                        string re = "";
                        if (value != null)
                        {
                            if (value.Value!=null)
                            re = value.Value.ToString();
                        }



                        string tName = "String";

                        if (value != null)
                        {
                            tName = value.Type.ToString();

                            if (tName.Equals("Date"))
                            {
                                re = ValueConverter.ConvertDate(value.Value.ToString());
                            }

                            if (tName.Equals("Float"))
                            {
                                re = ValueConverter.ConvertFloat(value.Value.ToString());
                            }

                            if (tName.Equals("Boolean"))
                            {
                                re = ValueConverter.ConvertBoolean(value.Value.ToString());
                            }
                        }

                        TemplateElement bElement = new TemplateElement()
                            {
                                ElementType = ElementType.Текст
                            };
                        
                        bElement.Paragraph = new TemplateParagraph()
                        {
                            TextAlign = TextAlign.Center,
                            FontWeight = FontWeight.Normal,
                            Text = re
                        };

                        var tc = new TableCell();
                        Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(bElement, FormattingHelper.FormatTableElements(bElement, bElement.Paragraph.Text));
                        tc.Append(paragraph);

                        // Assume you want columns that are automatically sized.
                        tc.Append(new TableCellProperties(
                            new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                        bodyRow.Append(tc);
                    }

                    table.Append(bodyRow);
                }

                body.Append(table);
                Run run = new Run();
                run.Append(new Break());

                var tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);
                tableIndex++;
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// export description tables
        /// </summary>
        public static void ExportDescriptionTables(Body body,BalanceModel model)
        {
            try
            {
                tableIndex = 1;
                InitBalanceHeaders();
                var balance =model.CompanyBalances.LastOrDefault();
                if (balance == null) return;

                #region actives
                ExportDescriptionTable(body,"Checkout","Касса",balance.Assets.Checkout.Rows);
                ExportDescriptionTable(body, "CurrentAccount", "Расчетный счет", balance.Assets.CurrentAccount.Rows);
                ExportDescriptionTable(body, "Savings", "Сбережения", balance.Assets.Savings.Rows);
                ExportDescriptionTable(body, "Deposit", "Депозит", balance.Assets.Deposit.Rows);
                ExportDescriptionTable(body, "Recievables", "Дебиторская задолженность", balance.Assets.Recievables.Rows);
                ExportDescriptionTable(body, "OtherRecievables", "Прочая дебиторская задолженность", balance.Assets.OtherRecievables.Rows);
                ExportDescriptionTable(body, "Inventories", "ТМЗ", balance.Assets.Inventories.Rows);
                ExportDescriptionTable(body, "Hardware", "Оборудование", balance.Assets.Hardware.Rows);
                ExportDescriptionTable(body, "MotorTransport", "Автотранспорт", balance.Assets.MotorTransport.Rows);
                ExportDescriptionTable(body, "RealEstate", "Недвижимость компании", balance.Assets.RealEstate.Rows);
                ExportDescriptionTable(body, "Investments", "Инвестиции Компании", balance.Assets.Investments.Rows);
                #endregion

                #region actives
                ExportDescriptionTable(body, "PayableAccounts", "Счета к оплате", balance.Liabilities.PayableAccounts.Rows);
                ExportDescriptionTable(body, "ShortPrivateLoans", "Частные займы (не более 12 мес.)", balance.Liabilities.ShortPrivateLoans.Rows);
                ExportDescriptionTable(body, "ShortCredit", "Банковские кредиты (не более 12 мес.)", balance.Liabilities.ShortCredit.Rows);
                ExportDescriptionTable(body, "ShortFixedAssetsCredit", "Банковские кредиты (не более 12 мес.) на основные средства", balance.Liabilities.ShortFixedAssetsCredit.Rows);
                ExportDescriptionTable(body, "LongPrivateLoans", "Частные займы (более 12 мес.)", balance.Liabilities.LongPrivateLoans.Rows);
                ExportDescriptionTable(body, "LongCredit", "Банковские кредиты (более 12 мес.)", balance.Liabilities.LongCredit.Rows);
                ExportDescriptionTable(body, "OtherLiabilities", "Прочие пассивы (сроком погашения более 12 мес.)", balance.Liabilities.OtherLiabilities.Rows);
                
                #endregion
            }
            catch (Exception e)
            {
            }

        }
    }
}
