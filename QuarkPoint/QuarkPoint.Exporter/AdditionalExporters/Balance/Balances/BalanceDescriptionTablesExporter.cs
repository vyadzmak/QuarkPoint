using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Linq;
using QuarkPoint.Exporter.AdditionalModels;
using QuarkPoint.Exporter.Models.HardModels.Balance;

namespace QuarkPoint.Exporter.AdditionalExporters.Balance.Balances
{
    public  static class BalanceDescriptionTablesExporter
    {
        private static List<BalanceHeaderModel> headers =new List<BalanceHeaderModel>();

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
            }
            catch (Exception e)
            {
                
            }
        }
        /// <summary>
        /// export description table
        /// </summary>
        private static void ExportDescriptionTable(string name, string title, object rows)
        {
            try
            {
                dynamic r = rows;

                var fElement = r[0];

                if (fElement==null) return;

                List<string> fields = new List<string>();
                JObject attributesAsJObject = fElement;
                Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                foreach (string key in values.Keys)
                {
                    if (key!="$$hashKey")
                    fields.Add(key);
                }
                


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
                InitBalanceHeaders();
                var balance =model.CompanyBalances.LastOrDefault();
                if (balance == null) return;

                #region actives
                ExportDescriptionTable("Checkout","Касса",balance.Assets.Checkout.Rows);
                ExportDescriptionTable("CurrentAccount", "Расчетный счет", balance.Assets.CurrentAccount.Rows);
                ExportDescriptionTable("Savings", "Сбережения", balance.Assets.Savings.Rows);
                ExportDescriptionTable("Deposit", "Депозит", balance.Assets.Deposit.Rows);
                ExportDescriptionTable("Recievables", "Дебиторская задолженность", balance.Assets.Recievables.Rows);
                ExportDescriptionTable("OtherRecievables", "Прочая дебиторская задолженность", balance.Assets.OtherRecievables.Rows);
                ExportDescriptionTable("Inventories", "ТМЗ", balance.Assets.Inventories.Rows);
                ExportDescriptionTable("Hardware", "Оборудование", balance.Assets.Hardware.Rows);
                ExportDescriptionTable("MotorTransport", "Автотранспорт", balance.Assets.MotorTransport.Rows);
                ExportDescriptionTable("RealEstate", "Недвижимость компании", balance.Assets.RealEstate.Rows);
                ExportDescriptionTable("Investments", "Инвестиции Компании", balance.Assets.Investments.Rows);
                #endregion

                #region actives
                ExportDescriptionTable("PayableAccounts", "Счета к оплате", balance.Liabilities.PayableAccounts.Rows);
                ExportDescriptionTable("ShortPrivateLoans", "Частные займы (не более 12 мес.)", balance.Liabilities.ShortPrivateLoans.Rows);
                ExportDescriptionTable("ShortCredit", "Банковские кредиты (не более 12 мес.)", balance.Liabilities.ShortCredit.Rows);
                ExportDescriptionTable("ShortFixedAssetsCredit", "Банковские кредиты (не более 12 мес.) на основные средства", balance.Liabilities.ShortFixedAssetsCredit.Rows);
                ExportDescriptionTable("LongPrivateLoans", "Частные займы (более 12 мес.)", balance.Liabilities.LongPrivateLoans.Rows);
                ExportDescriptionTable("LongCredit", "Банковские кредиты (более 12 мес.)", balance.Liabilities.LongCredit.Rows);
                ExportDescriptionTable("OtherLiabilities", "Прочие пассивы (сроком погашения более 12 мес.)", balance.Liabilities.OtherLiabilities.Rows);
                
                #endregion
            }
            catch (Exception e)
            {
            }

        }
    }
}
