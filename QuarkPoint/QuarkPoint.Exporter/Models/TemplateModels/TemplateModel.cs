using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    public class TemplateModel
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateModel()
        {
            try
            {
                Elements  = new List<TemplateElement>();
                CreatedDate = DateTime.Now;
                Changed = false;
            }
            catch (Exception e)
            {

            }
        }
        #endregion

        #region fields
        /// <summary>
        /// template name
        /// </summary>
        [JsonProperty("name")]

        public string Name { get; set; }

        /// <summary>
        /// created date
        /// </summary>
        [JsonProperty("created_date")]

        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// changed
        /// </summary>
        [JsonProperty("changed")]
        public bool Changed { get; set; }

        /// <summary>
        /// elements
        /// </summary>
        [JsonProperty("elements")]
        public List<TemplateElement> Elements { get; set; }
        #endregion

        #region methods
        /// <summary>
        /// save template
        /// </summary>
        /// <param name="templatePath"></param>
        public bool Save(string templatePath)
        {
            try
            {
                using (StreamWriter file = File.CreateText(templatePath))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.QuoteChar = '"';

                    JsonSerializer ser = new JsonSerializer();
                    ser.Serialize(writer, this);
                }
                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }
        #endregion

    }
}
