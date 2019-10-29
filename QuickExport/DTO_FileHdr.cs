using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProcesses
{
    public class DTO_FileHdr
    {
        public int WOHdrId { get; set; }
        public string ActivityName { get; set; }
        public string FileProduceTypeId { get; set; }
        public string FileDelimiterId { get; set; }
        public int HeaderFields { get; set; }
        public int PostingFields { get; set; }
        public int TaxFields { get; set; }
        public int ClearingFields { get; set; }
        public int InterCompanyFields { get; set; }
        
    }
}
