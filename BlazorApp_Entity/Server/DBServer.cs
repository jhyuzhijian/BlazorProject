using Microsoft.Extensions.DependencyInjection;
using SqlSugar;

namespace BlazorApp_Entity.Server
{
    public class DBServer
    {
        public SqlSugarClient db;
        public DBServer(string ConneStr)
        {
            db = new SqlSugarClient(
           new ConnectionConfig
           {
               ConnectionString = ConneStr,
               DbType = DbType.SqlServer,//设置数据库类型
               IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
               InitKeyType = InitKeyType.SystemTable //从实体特性中读取主键自增列信息
           });
        }

        public static IServiceCollection AddDbContext(IServiceCollection services, string connectionStr)
        {
            services.AddScoped<DBServer>();
            return services;
        }

    }
}
