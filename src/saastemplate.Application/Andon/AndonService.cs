using FarVision.Mes.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebMES.Service.Interface.Andon;

namespace FarVision.Mes.Andon
{
    public class AndonService : IAndonService
    {
        public AndonService()
        {

        }
        public List<AndonVM> GetAndonAsync(string callType, string workStation, string processNo)
        {
            string sql = string.Empty;
            var lst = new List<AndonVM>();
            lst.Add( new AndonVM { CAIID = 1, ID = 1, SEB_NAME = "1" });
            return lst;
        }
    }
}
