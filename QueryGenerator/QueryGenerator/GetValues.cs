using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryGenerator
{
    class GetValues
    {
        public string GetValue(List<string> arr)
        {
            string value = "";
            int countRow = arr.Count();

            if (countRow == 1)
            {
                    value = arr[0];
            }
            else
            {
                for (int i = 0; i < countRow-1; i++)
                {  
                        value += arr[i] + ", ";
                }
                value += arr[countRow - 1]; ;
            }
            return value;
        }
        public string GetWhere(List<string> arr)
        {
            string value = "";
            int countRow = arr.Count();

            if (countRow == 1)
            {
                    value = arr[0];
            }
            else
            {
                for (int i = 0; i < countRow - 1; i++)
                {
                        value += arr[i] + " AND ";
                }
                value += arr[countRow - 1]; ;
            }
            return value;
        }

        public List<string> ParseList(ListBox listBox)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                list.Add(listBox.Items[i].ToString());
            }
            return list;
        }
    }
}
