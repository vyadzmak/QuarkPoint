using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Opiu
{
    public class OpiuCommentsModel
    {
        public OpiuCommentsModel(string title, string value)
        {
            try
            {
                Title = title;
                Value = value;

            }
            catch (Exception e)
            {
            }
        }

        public string Title { get; set; }

        public string Value { get; set; }
    }
}
