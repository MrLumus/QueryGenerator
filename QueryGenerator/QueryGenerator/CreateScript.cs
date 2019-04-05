using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryGenerator
{
    class CreateScript
    {
        public string CreateQueryNonWhere(string items, string tables)
        {
            string Query = $"SELECT {items} FROM {tables}";
            return Query;
        }
        public string CreateQueryWhere(string items, string tables, string where)
        {
            string Query = $"SELECT {items} FROM {tables} WHERE {where}";
            return Query;
        }
    }
}
