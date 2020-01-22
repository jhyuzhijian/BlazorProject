using BlazorApp_Entity.Server;
using System.Collections.Generic;

namespace BlazorApp_Entity.Data
{
    public class SqlConnect
    {
        public class ConnectionInfo
        {
            public string IpAdress { get; set; }
            public string Port { get; set; }
            public string Account { get; set; }
            public string Pwd { get; set; }
            public string Database { get; set; }
        }
        public class TableInfo
        {
            public string TableName { get; set; }
            public string Schema { get; set; }
            public string Describe { get; set; }
        }
        public List<TableInfo> GetDatabaseList(ConnectionInfo Info)
        {
            string connection = $"server={Info.IpAdress};port={Info.Port};uid={Info.Account};pwd={Info.Pwd};database={Info.Database}";
            var TableList = new DBServer(connection).db.Queryable<TableInfo>(@"select top 1000
                                    ROW_NUMBER() OVER (ORDER BY a.name) AS No, 
                                    a.name AS 表名,
                                    CONVERT(NVARCHAR(100),isnull(g.[value],'-')) AS 说明
                                    ,c.name 架构名
                                    from
                                    sys.tables a left join sys.extended_properties g
                                    on (a.object_id = g.major_id AND g.minor_id = 0)
                                    left join sys.schemas c on a.schema_id=c.schema_id")
                .ToList();

            return TableList;
        }
    }
}
