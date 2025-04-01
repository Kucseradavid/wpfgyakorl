using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wpfgyakorl.Data
{
    public class Sum
    {
        private int _sz1;
        public string Sz1 { get { return _sz1.ToString(); } set { _sz1 = ell(value); } }

        private int _sz2;
        public string Sz2 { get { return _sz2.ToString(); } set { _sz2 = ell(value); } }

        private int _sz3;
        public string Sz3 { get { return _sz3.ToString(); } set { _sz3 = ell(value); } }

        private int ell(string v) //European Locomotive Leasing
        {
            try
            {
                int s = Convert.ToInt32(v);
                return s;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt: " + e.Message + "\n" + "A hibás érték(ek) lecserélve nullára.", "Hiba");
                return 0;
            }
        }

        public void osszead()
        {
            if (_sz1 == 0 || _sz2 == 0 || _sz3 == 0)
            {
                MessageBox.Show("Nem megfelelő értékek", "Hiba");
                return;
            }
            MessageBox.Show($"{_sz1} meg {_sz2} és {_sz3} eggyellő {_sz1 + _sz2 + _sz3}", "összeg vala");
        }
    }
}
