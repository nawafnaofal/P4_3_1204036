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

namespace P4_3_1204036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "Betul!");
            }
            else
            {
                epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }

            
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
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
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");

                }
            }
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if ((txtEmail.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");

                }
            }
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");

                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
            }
            else
            {
                epWrong.SetError(txtAngka, "Inputan hanya boleh huruf!");
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email Salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void Angka1_Leave(object sender, EventArgs e)
        {
            {
                if (Angka2.Text != "")
                {
                    if ((int.Parse(Angka1.Text) >= int.Parse(Angka2.Text)))
                    {
                        epWarning.SetError(Angka1, "Kolom Angka 1 tidak boleh lebih besar dari kolom Angka 2");
                        epWrong.SetError(Angka1, "");
                        epCorrect.SetError(Angka1, "");
                    }
                    else { }
                }
            }
        }

        private void Angka2_Leave(object sender, EventArgs e)
        {

            if ((int.Parse(Angka1.Text) >= int.Parse(Angka2.Text)))
            {
                epWarning.SetError(Angka2, "Kolom Angka 1 tidak boleh lebih besar dari kolom Angka 2.");
                epWrong.SetError(Angka2, "");
                epCorrect.SetError(Angka2, "");
            }
            else { }        
            }
    }
}
