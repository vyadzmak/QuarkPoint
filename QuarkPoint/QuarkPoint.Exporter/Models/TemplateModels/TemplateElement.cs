﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    /// <summary>
    /// element type
    /// </summary>
    public enum ElementType { Текст =0, Таблица =1, Список =2}

    /// <summary>
    /// template element
    /// </summary>
    public class TemplateElement
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateElement()
        {
            try
            {

            }
            catch (Exception e)
            {

            }
        }
        #endregion

        #region fields
        /// <summary>
        /// index in list
        /// </summary>
        [JsonProperty("index")]

        public int Index { get; set; }    

        /// <summary>
        /// title element
        /// </summary>
        [JsonProperty("title")]

        public string Title { get; set; }

        /// <summary>
        /// element type
        /// </summary>
        [JsonProperty("element_type")]

        public ElementType ElementType { get; set; }

        /// <summary>
        /// table
        /// </summary>
        [JsonProperty("table")]

        public TemplateTable Table { get; set; }

        /// <summary>
        /// paragraph
        /// </summary>
        [JsonProperty("paragraph")]

        public TemplateParagraph Paragraph { get; set; }
        #endregion
    }
}