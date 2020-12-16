using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using WebMES.Service.Interface.Andon;

namespace saastemplate.HttpApi.Client.ConsoleTestApp
{
    public class ClientDemoService : ITransientDependency
    {
        private readonly IProfileAppService _profileAppService;
        private readonly IAndonService _andonService;

        public ClientDemoService(IProfileAppService profileAppService, IAndonService andonService)
        {
            _profileAppService = profileAppService;
            _andonService = andonService;
        }

        public async Task RunAsync()
        {
            var output = await _profileAppService.GetAsync();
            Console.WriteLine($"UserName : {output.UserName}");
            Console.WriteLine($"Email    : {output.Email}");
            Console.WriteLine($"Name     : {output.Name}");
            Console.WriteLine($"Surname  : {output.Surname}");
            var value = _andonService.GetAndonAsync("1", "1", "1");
            Console.WriteLine(JsonConvert.SerializeObject(value));
        }
    }
}