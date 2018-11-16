using Volo.Abp.Application.Services;

namespace MakoFxAbp
{
    public class AppService : ApplicationService
    {
        public string GetStuff()
        {
            return "Hello From AppService GetStuff";
        }
    }
}