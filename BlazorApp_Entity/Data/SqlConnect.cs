using BlazorApp_Entity.Server;
using Blazui.Component;
using Blazui.Component.Table;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp_Entity.Data
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
        [TableColumn(Text = "表名")]
        public string TableName { get; set; }
        public string Schema { get; set; }
        [TableColumn(Text = "表描述")]
        public string Describe { get; set; }
    }
    public class SqlConnect : ComponentBase
    {
        protected BTable table;
        public List<TableInfo> tables = new List<TableInfo>();

        protected int currentPage = 1;
        protected int pageSize = 5;

        [Inject]
        public DialogService _DialogService { get; set; }
        internal int CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                tables = GetAllList().Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            }
        }
        private string connectionstr = "Data Source=SHARING\\SQLEXPRESS;Initial Catalog=edu_zjzj;User ID=sa;Password=123;MultipleActiveResultSets=true";
        public List<TableInfo> GetAllList()
        {
            //string connection = $"server={Info.IpAdress};port={Info.Port};uid={Info.Account};pwd={Info.Pwd};database={Info.Database}";
            //string connection = $"Data Source=LAPTOP-FG0SOM1N;Initial Catalog=test;User ID=sa;Password=123;MultipleActiveResultSets=true";
            var TableList = new DBServer(connectionstr).db.SqlQueryable<TableInfo>(@"select top 1000
                                    ROW_NUMBER() OVER (ORDER BY a.name) AS No, 
                                    a.name AS TableName,
                                    CONVERT(NVARCHAR(100),isnull(g.[value],'-')) AS Describe
                                    ,c.name [Schema]
                                    from
                                    sys.tables a left join sys.extended_properties g
                                    on (a.object_id = g.major_id AND g.minor_id = 0)
                                    left join sys.schemas c on a.schema_id=c.schema_id")
                .ToList();

            return TableList;
        }
        public List<TableInfo> GetDatabaseList(ConnectionInfo Info)
        {
            //string connection = $"server={Info.IpAdress};port={Info.Port};uid={Info.Account};pwd={Info.Pwd};database={Info.Database}";
            string connection = $"Data Source=LAPTOP-FG0SOM1N;Initial Catalog=test;User ID=sa;Password=123;MultipleActiveResultSets=true";
            var TableList = new DBServer(connectionstr).db.SqlQueryable<TableInfo>(@"select top 1000
                                    ROW_NUMBER() OVER (ORDER BY a.name) AS No, 
                                    a.name AS TableName,
                                    CONVERT(NVARCHAR(100),isnull(g.[value],'-')) AS Describe
                                    ,c.name [Schema]
                                    from
                                    sys.tables a left join sys.extended_properties g
                                    on (a.object_id = g.major_id AND g.minor_id = 0)
                                    left join sys.schemas c on a.schema_id=c.schema_id")
                .ToList();

            return TableList.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
