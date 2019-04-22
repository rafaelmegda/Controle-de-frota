using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View 
{
    public class PreencherAnoCB : ComboBox
    {
        public PreencherAnoCB()
        {
            for (int cont = DateTime.Now.Year + 1; cont >= 1925; cont--)
            {
                this.Items.Add(cont);
            }
            this.Items[0] = "";
        }
    }
}
