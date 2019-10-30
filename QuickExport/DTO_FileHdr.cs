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

        public List<DTO_FileDtl> DtoFileDtlList = new List<DTO_FileDtl>();

        public DataValidatorReturn AddToFileDtlList(DTO_FileHdr dTO_FileHdr)
        {
            if (dTO_FileHdr.HeaderFields > 0)
            {
                for (int i = 1; i <= dTO_FileHdr.HeaderFields; i++)
                {
                    DTO_FileDtl dtl = new DTO_FileDtl()
                    {
                        FieldType = "HEADER",
                        FieldNo = i
                    };

                    dTO_FileHdr.DtoFileDtlList.Add(dtl);
                }
            }

            if (dTO_FileHdr.PostingFields > 0)
            {
                for (int i = 1; i <= dTO_FileHdr.PostingFields; i++)
                {
                    DTO_FileDtl dtl = new DTO_FileDtl()
                    {
                        FieldType = "POSTING",
                        FieldNo = i
                    };

                    dTO_FileHdr.DtoFileDtlList.Add(dtl);
                }
            }

            if (dTO_FileHdr.ClearingFields > 0)
            {
                for (int i = 1; i <= dTO_FileHdr.ClearingFields; i++)
                {
                    DTO_FileDtl dtl = new DTO_FileDtl()
                    {
                        FieldType = "CLEARING",
                        FieldNo = i
                    };

                    dTO_FileHdr.DtoFileDtlList.Add(dtl);
                }
            }

            if (dTO_FileHdr.InterCompanyFields > 0)
            {
                for (int i = 1; i <= dTO_FileHdr.InterCompanyFields; i++)
                {
                    DTO_FileDtl dtl = new DTO_FileDtl()
                    {
                        FieldType = "ICLEARING",
                        FieldNo = i
                    };

                    dTO_FileHdr.DtoFileDtlList.Add(dtl);
                }
            }

            if (dTO_FileHdr.TaxFields > 0)
            {
                for (int i = 1; i <= dTO_FileHdr.TaxFields; i++)
                {
                    DTO_FileDtl dtl = new DTO_FileDtl()
                    {
                        FieldType = "TAX",
                        FieldNo = i
                    };

                    dTO_FileHdr.DtoFileDtlList.Add(dtl);
                }
            }

            return new DataValidatorReturn(); 
        }
        
    }
}
