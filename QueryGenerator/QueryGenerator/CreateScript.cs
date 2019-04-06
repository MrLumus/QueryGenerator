using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryGenerator
{
    class CreateScript
    {
        public string CreateQuerySelectNonWhere(string items, string tables)
        {
            string Query = $"SELECT {items} FROM {tables}";
            return Query;
        }
        public string CreateQuerySelectWhere(string items, string tables, string where)
        {
            string Query = $"SELECT {items} FROM {tables} WHERE {where}";
            return Query;
        }

        public string CreateQueryInsertNonWhere(string tableName, string items, string values)
        {
            string Query = $"INSERT INTO {tableName}({items}) VALUES ({values})";
            return Query;
        }
        public string CreateQueryInsertWhere(string tableName, string items, string values, string where)
        {
            string Query = $"INSERT INTO {tableName}({items}) VALUES ({values}) WHERE {where}";
            return Query;
        }
    }
}
