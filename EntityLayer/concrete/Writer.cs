using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Writer
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public String WriterImage { get; set; }
        public string WriterMail { get; set; }
        public String WriterPassword { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
