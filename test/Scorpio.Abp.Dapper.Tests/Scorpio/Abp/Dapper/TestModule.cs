using System;
using System.Collections.Generic;
using System.Text;

using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Scorpio.Abp.Dapper
{
    [DependsOn(
        typeof(AbpDapperModule),
        typeof(AbpTestBaseModule),
        typeof(AbpAutofacModule)
        )]
    public class TestModule : AbpModule
    {
    }
}
