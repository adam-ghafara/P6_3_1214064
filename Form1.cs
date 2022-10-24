using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_1214064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Text Box Tidak boleh Kosong");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "Input Hanya Boleh Huruf");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtAngka, "Text Box Tidak boleh Kosong");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtAngka, "Input Hanya Boleh Angka!");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtEmail, "Text Box Tidak boleh Kosong");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, ""); ;
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtEmail, "Format Email Salah!\nContoh: a@b.c");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Angka Tidak boleh Kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Angka 2 Tidak boleh Kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else if (Int64.Parse(txtAngka1.Text) > Int64.Parse(txtAngka2.Text))
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, ""); ;
                epCorrect.SetError(txtAngka1, "Betul!");
            }
            else if (Int64.Parse(txtAngka1.Text) < Int64.Parse(txtAngka2.Text))
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "Angka 1 Lebih kecil daripada Angka 2");
                epCorrect.SetError(txtAngka1, "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
               epWarning.SetError(txtAngka2, "Angka Tidak boleh Kosong");
               epWrong.SetError(txtAngka2, "");
               epCorrect.SetError(txtAngka2, "");
            }
            else if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Angka 1 Tidak boleh Kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else if (Int64.Parse(txtAngka1.Text) > Int64.Parse(txtAngka2.Text))
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, ""); ;
                epCorrect.SetError(txtAngka2, "Betul!");
            }
            else if (Int64.Parse(txtAngka1.Text) < Int64.Parse(txtAngka2.Text))
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "Angka 1 Lebih kecil daripada Angka 2");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
