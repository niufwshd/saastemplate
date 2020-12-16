using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarVision.Mes.DTO
{
    public class AndonVM
    {
        public int ID {get;set;} 
        public string No {get;set;} 
        public string TypeName {get;set;} 
        public bool Enabled {get;set;} 
        public DateTime CALL_DATE {get;set;} 
        public string CALL_STA {get;set;} 
        public string SEB_NO {get;set;} 
        public String SEB_NAME {get;set;} 
        public string  SEB_SN {get;set;} 
        public string CALL_SAL_NAME {get;set;} 
        public int  CAIID {get;set;} 
        public string WorkStationCode {get;set;} 
        public string  WorkStationName { get; set; }
    }
}
