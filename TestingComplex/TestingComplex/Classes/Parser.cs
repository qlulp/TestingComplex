using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingComplex.Classes.Entities;

namespace TestingComplex.Classes
{
    public static class Parser
    {
        public static List<TestBlock> ToTestBlocks(DataTable table)
        {
            var resultList = new List<TestBlock>();
            try
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var tempTestBlock = new TestBlock
                    (
                        id: table.Rows[i].Field<int>("Код блока"),
                        name: table.Rows[i].Field<string>("Название"),
                        dateOfCreation: new DateTime()
                    //table.Rows[i].Field<DateTime>("Дата создания").ToUniversalTime()
                    );
                    resultList.Add(tempTestBlock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultList;
        }
    }
}
