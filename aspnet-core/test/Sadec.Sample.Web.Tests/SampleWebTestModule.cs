using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Sadec.Sample.EntityFrameworkCore;
using Sadec.Sample.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Sadec.Sample.Web.Tests
{
    [DependsOn(
        typeof(SampleWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SampleWebTestModule : AbpModule
    {
        public SampleWebTestModule(SampleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SampleWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SampleWebMvcModule).Assembly);
        }
    }
}