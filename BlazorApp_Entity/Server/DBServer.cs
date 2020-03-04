using Microsoft.Extensions.DependencyInjection;
using SqlSugar;

namespace BlazorApp_Entity.Server
{
    public class DBServer
    {
        public string ConStr = "";
        public SqlSugarClient db => GetInstance();

        SqlSugarClient GetInstance()
        {
            var db = new SqlSugarClient(
               new ConnectionConfig
               {
                   ConnectionString = string.IsNullOrEmpty(ConStr) ? "Data Source=LAPTOP-FG0SOM1N;Initial Catalog=test;User ID=sa;Password=123;MultipleActiveResultSets=true" : ConStr,
                   DbType = DbType.SqlServer,
                   IsShardSameThread = true,
                   IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                   InitKeyType = InitKeyType.SystemTable //从实体特性中读取主键自增列信息
               }
           );
            return db;
        }

    }
}
