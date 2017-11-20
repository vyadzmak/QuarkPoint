using System;

namespace QuarkPoint.Exporter.Models.TemplateModels.AdditionalTableModels
{
    public class ColumnEnabledModel
    {
        #region column enabled model

        /// <summary>
        ///     constructor
        /// </summary>
        public ColumnEnabledModel()
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
        /// checked
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
        #endregion
    }
}