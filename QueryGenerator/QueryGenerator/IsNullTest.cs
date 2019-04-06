using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryGenerator
{
    static class IsNullTest
    {
        public static bool ComboBox(params ComboBox[] list)
        {
            bool result = true;
            foreach(ComboBox c in list)
            {
                if (c.Text == "")
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool TextBox(params TextBox[] text)
        {
            bool result = true;
            foreach (TextBox t in text)
            {
                if (t.Text == "")
                {
                    result = false;
                    t.BackColor = System.Drawing.Color.FromArgb(252, 220, 220);
                }
            }
            if (result)
            {
                foreach (TextBox t in text)
                {
                    t.BackColor = System.Drawing.Color.White;
                }
            }
            return result;
        }

        public static bool ListBox(params ListBox[] list)
        {
            bool result = true;
            foreach(ListBox l in list)
            {
                if(l.Items.Count == 0)
                {
                    result = false;
                    l.BackColor = System.Drawing.Color.FromArgb(252,220,220);
                }
            }
            if (result)
            {
                foreach (ListBox l in list)
                {
                    l.BackColor = System.Drawing.Color.White;
                }
            }
            return result;
        }
    }
}
