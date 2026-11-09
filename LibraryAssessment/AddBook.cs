using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryAssessment
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }      
        private void btnBack_Click(object sender, EventArgs e)
        {
            using (StreamWriter myWriter = new StreamWriter(@"..\..\Books.txt"))
            {
                foreach (Books myBooks in Program.MYBOOKS)
                {


                    myWriter.WriteLine($"Name: {myBooks.NAME},");
                    myWriter.WriteLine($"Author: {myBooks.AUTHOR},");
                    myWriter.WriteLine($"ISBN: {myBooks.ISBN},");
                    myWriter.WriteLine($"Summary: {myBooks.SUMMARY}");

                }
            }//writes to the file before closing, to save the inputed data
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();//takes back to previous page
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Books myBooks = new Books();
            myBooks.NAME = txtBookName.Text;
            myBooks.AUTHOR = txtAuthor.Text;
            myBooks.ISBN = txtISBN.Text;
            myBooks.SUMMARY = txtSummary.Text;

            //if (string.IsNullOrEmpty(myBooks.NAME))
            if(txtBookName.Text=="")
            {
                MessageBox.Show("Please add a book name");//requires box to be filled
                return;
            }

            //else if (string.IsNullOrEmpty(myBooks.AUTHOR))
            else if(txtAuthor.Text=="")
            {
                MessageBox.Show("Please add an Author");//requires box to be filled
                return;
            }

            //else if (string.IsNullOrEmpty(myBooks.ISBN))
            else if(txtISBN.Text=="")
            {
                MessageBox.Show("Please add an ISBN number for the book");//requires box to be filled
                return;
            }

            //else if (string.IsNullOrEmpty(myBooks.SUMMARY))
            else if(txtSummary.Text=="")
            {
                MessageBox.Show("Please add a Small summary");//requires box to be filled
                return;
            }

            else
            {
                MessageBox.Show("Book Added Successfully");
                Books newBook = new Books(txtBookName.Text, txtAuthor.Text, txtISBN.Text, txtSummary.Text);
                Program.MYBOOKS.Add(newBook);
            }
                        

            foreach (Control txt in this.Controls)//clears text box after submit button clicked
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                }
            }
        }
    }
}
