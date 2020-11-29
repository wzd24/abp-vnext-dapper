using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Kogel.Dapper.Extension;
using Kogel.Dapper.Extension.Extension;

namespace Scorpio.Abp.Dapper
{
    public class AbpDapperContext
    {
        public IDbConnection  DbConnection { get; set; }

      
    }
}
