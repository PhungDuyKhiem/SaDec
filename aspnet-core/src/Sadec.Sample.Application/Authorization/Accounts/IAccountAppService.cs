using System.Threading.Tasks;
using Abp.Application.Services;
using Sadec.Sample.Authorization.Accounts.Dto;

namespace Sadec.Sample.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
