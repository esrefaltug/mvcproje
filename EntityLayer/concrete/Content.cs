using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Content
    {
        public int ContenID { get; set; }
        public string ConventValue { get; set; }
        public DateTime ContentDate { get; set; }
        // ContentYazar
        //ContentBaşlık
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
