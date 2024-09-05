using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress_demo
{
    internal class DummyData
    {
        public static DataTable Table1 { get; private set; }

        public static DataTable Table2 { get; private set; }

        static DummyData()
        {
            Table1 = new DataTable("Table1");
            Table1.Columns.Add("Name", typeof(string));
            Table1.Columns.Add("Age", typeof(int));

            Table1.Rows.Add("John Doe", 30);
            Table1.Rows.Add("Jane Smith", 25);

            Table2 = new DataTable("Table2");
            Table2.Columns.Add("Code", typeof(string));
            Table2.Columns.Add("Name", typeof(string));

            Table2.Rows.Add("A001", "Product A");
            Table2.Rows.Add("B002", "Product B");
        }
    }
}
