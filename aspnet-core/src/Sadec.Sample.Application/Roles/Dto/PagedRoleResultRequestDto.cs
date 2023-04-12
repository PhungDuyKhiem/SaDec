using Abp.Application.Services.Dto;

namespace Sadec.Sample.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

