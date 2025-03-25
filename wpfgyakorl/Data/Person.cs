using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wpfgyakorl.Data
{
    public class Person
    {
        public string FirstName { get; set; } = "Konfúcijusz";
        public string LastName { get; set; } = "Kleiszthenész";
        private int _age;
        public string Age { get { return _age.ToString(); } set { _age = Convert.ToInt32(value); } }

        public void TwoThousandYearsLater()
        {
            MessageBox.Show($"{FirstName} {LastName} iz {_age + 2000} jír óld", "Utalás");
        }
    }
}
