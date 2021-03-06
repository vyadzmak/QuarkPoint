﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.TemplateModels.TableModels
{
    public class HeaderModel:RowModel
    {
        #region constructor
        /// <summary>
        /// constrcuctor
        /// </summary>
        public HeaderModel()
        {
            try
            {
                Style = new TemplateStyle()
                {
                    BackgroundColor = "#ffffff",
                    FontName = FontName.Times,
                    FontSize = 10,
                    FontWeight = FontWeight.Bold,
                    ForegroundColor = "#000000",
                    TextAlign = TextAlign.Center,
                    UnderLine = false
                };
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region fields

        /// <summary>
        /// style
        /// </summary>
        public TemplateStyle Style { get; set; }
        #endregion
    }
}
