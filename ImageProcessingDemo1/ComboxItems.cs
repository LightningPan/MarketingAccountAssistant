using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingDemo1
{
    class ComboxItems
    {
        public string text { get; set; }
        public object value { get; set; }

        public ComboxItems(string text, object value)
        {
            this.text = text;
            this.value = value;
        }

    }
}
