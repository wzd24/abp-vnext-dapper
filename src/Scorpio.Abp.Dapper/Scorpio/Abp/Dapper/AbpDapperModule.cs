using System;
using System.Collections.Generic;
using System.Text;

using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Scorpio.Abp.Dapper
{
    [DependsOn(typeof(AbpDddDomainModule))]
    public class AbpDapperModule:AbpModule
    {
    }
}
