using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAssessment
{
    public partial class Form1 : Form
    {
        private Form2 myForm2; //declaring myForm2 as a variable
        public Form1()
        {
            InitializeComponent();
            myForm2 = new Form2();
            
        }
        private void showPage(Form page)
        {
            page.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//closes on button click
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();//hides previous page
            showPage(myForm2);//displays 2nd page when button is clicked
        }
    }
}
