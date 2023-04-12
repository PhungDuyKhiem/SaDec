using Abp.Application.Services;
using Sadec.Sample.MultiTenancy.Dto;

namespace Sadec.Sample.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

