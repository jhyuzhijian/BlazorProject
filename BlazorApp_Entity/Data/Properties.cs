using BlazorApp_Entity.Model;
using BlazorApp_Entity.Server;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_Entity.Data
{
    public class Properties : ComponentBase
    {
        [Parameter]
        public string TableName { get; set; }
        protected int currentPage;
        protected List<PropertyInfo> Datas = new List<PropertyInfo>();
        protected override void OnInitialized()
        {
            Datas = GetProperties(TableName);
        }
        public List<PropertyInfo> GetProperties(string tableName)
        {
            string sql = $@"SELECT TOP (100) PERCENT
            --(case when a.colorder=1 then d.name else null end) 表名,  
            --a.colorder 字段序号,
            a.name PropertyName,--字段名,
            --(case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '√'else '' end) 标识, 
            --(case when (SELECT count(*) FROM sysobjects  
            --WHERE (name in (SELECT name FROM sysindexes  
            --WHERE (id = a.id) AND (indid in  
            --(SELECT indid FROM sysindexkeys  
            --WHERE (id = a.id) AND (colid in  
            --(SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))  
            --AND (xtype = 'PK'))>0 then '√' else '' end) 主键,
            --a.length 占用字节数,  
            --COLUMNPROPERTY(a.id,a.name,'PRECISION') as 长度,  
            --isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then '√'else '' end) 允许空,  
            --isnull(e.text,'') 默认值,
            b.name PropertyType,--类型,
            isnull(g.[value], ' ') AS PropertyDescribe--[说明]
            FROM  syscolumns a 
            left join systypes b on a.xtype=b.xusertype  
            inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties' 
            left join syscomments e on a.cdefault=e.id  
            left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
            left join sys.extended_properties f on d.id=f.class and f.minor_id=0
            where b.name is not null
            and d.name='{tableName}' --如果只查询指定表,加上此条件
            order by a.id,a.colorder";

            //string connection = $"Data Source=LAPTOP-FG0SOM1N;Initial Catalog=test;User ID=sa;Password=123;MultipleActiveResultSets=true";
            string connection = "Data Source=SHARING\\SQLEXPRESS;Initial Catalog=edu_zjzj;User ID=sa;Password=123;MultipleActiveResultSets=true";
            var TableList = new DBServer(connection).db.SqlQueryable<PropertyInfo>(sql).ToList();

            return TableList;
        }
    }
}
