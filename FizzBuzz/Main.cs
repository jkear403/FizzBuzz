using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class FizzBuzz : Form
    {
        public FizzBuzz()
        {
            InitializeComponent();
        }

        private void FizzBuzz_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                if (i % 3 == 0)
                { output += "Fizz"; }

                if (i % 5 == 0)
                { output += "Buzz"; }

                if (output == "")
                { output += i.ToString(); }

                lsbFizzBuzz.Items.Add(output);
            }
        }
    }
}
