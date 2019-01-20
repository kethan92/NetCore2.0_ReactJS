using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class DynamicTable
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
    }
}
