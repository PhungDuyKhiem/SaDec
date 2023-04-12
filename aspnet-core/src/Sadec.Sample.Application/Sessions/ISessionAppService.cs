using System.Threading.Tasks;
using Abp.Application.Services;
using Sadec.Sample.Sessions.Dto;

namespace Sadec.Sample.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
