using System;
using System.Collections.Generic;
using System.Text;

using Volo.Abp;
using Volo.Abp.Testing;

namespace Scorpio.Abp.Dapper
{
    public abstract class DapperTestBase:AbpIntegratedTest<TestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options) => options.UseAutofac();
    }
}
