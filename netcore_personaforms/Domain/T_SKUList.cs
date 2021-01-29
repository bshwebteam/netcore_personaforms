using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_personaforms.Domain
{
    public class T_SKUList
    {
        public int id { get; set; }
        public string modelNum { get; set; }
        public string description { get; set; }
        public string blueknobModelNum { get; set; }
        public string blueknobPartNum { get; set; }
        public string url { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }

    }
}
