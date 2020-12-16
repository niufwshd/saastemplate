using System.Collections.Generic;
using System.Threading.Tasks;
using FarVision.Mes.DTO;
using Volo.Abp.Application.Services;

namespace WebMES.Service.Interface.Andon
{
    public interface IAndonService:IApplicationService
    {

        /// <summary>
        /// 根据工位获取andon类型
        /// </summary>
        /// <param name="CallType">安灯类型</param>
        /// <param name="WorkStation">工位</param>
        /// <returns></returns>
        List<AndonVM> GetAndonAsync(string callType, string workStation, string processNo);

        /// <summary>
        /// 根据工位获取安灯数量（安灯类型分组）
        /// </summary>
        /// <param name="WorkStation">工位</param>
        /// <returns></returns>
        //BooleanValue<DataTable> GetAndonNubmer(string WorkStation, string processNo);


        //BooleanValue<DataTable> GetAndonNumber(string callStatus, string workStation, string processNo);
    }
}
