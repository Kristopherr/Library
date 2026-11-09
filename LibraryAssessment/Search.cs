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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

       
        public void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a value to be searched");
            }

            if (radioBookName.Checked)
            {
                search("Book Name");
                //MessageBox.Show("Books");
            }
            else if (radioAuthor.Checked)
            {
                search("Author");
            }
            else if (radioISBN.Checked)
            {
                search("ISBN");
            }
            else if (radioSummary.Checked)
            {
                search("Summary");
            }

        }
        public void search(string searchCategory)
        {
            lstContent.Items.Clear(); //clear the list box from default text

            List<Books> foundBook = new List<Books>();
            bool found = false; //????
            string itemToSearch = txtSearch.Text; //Search through current books to match criteria 

            foreach (Books myBooks in Program.MYBOOKS)
            {
                if (searchCategory == "Book Name")
                {
                    //searches records for value "book name" this shall find books by name value
                    if (myBooks.NAME.ToLower().Contains(itemToSearch.ToLower()))
                    {
                        found = true;
                        foundBook.Add(myBooks);
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                        return;
                    }
                }
                else if (searchCategory == "Author")
                {
                    if (myBooks.AUTHOR.ToLower().Contains(itemToSearch.ToLower()))
                    {
                        found = true;
                        foundBook.Add(myBooks);
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                        return;
                    }

                }
                else if (searchCategory == "ISBN")
                {
                    if (myBooks.ISBN.ToLower().Contains(itemToSearch.ToLower()))
                    {
                        found = true;
                        foundBook.Add(myBooks);
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                        return;
                    }
                }
                else if (searchCategory == "Summary")
                {
                    if (myBooks.SUMMARY.ToLower().Contains(itemToSearch.ToLower()))
                    {
                        found = true;
                        foundBook.Add(myBooks);
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                        return;
                    }
                } else
                {
                    MessageBox.Show("Please Match criteria properly");
                }
            }

            if (!found)
            {
                lstContent.Items.Add("Search not found, Please try again");
            }
            else
            {
                //print search results 
                lstContent.Items.Add($"\n The Following books match the searched criteria");
                listBook(foundBook);
            }
        }
        public void listBook(List<Books> foundBook)
        {
            int counter = 1;
            Console.WriteLine($"Here are all Contacts.....");
            foreach (Books individualContact in foundBook)
            {
                lstContent.Items.Add($"{counter}. " +
                $"Name:{individualContact.NAME}  " +
                $"Author:{individualContact.AUTHOR}  " +
                $"ISBN:{individualContact.ISBN}  \n" +
                $"Summary:{individualContact.SUMMARY}  ");
                counter++;
            }
        }




        //use of whitespace
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();//takes back to previous page
        }

        private void radioSummary_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCriteria();
        }

        private void radioBookName_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCriteria();
        }

        private void radioISBN_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCriteria();
        }

        private void radioAuthor_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCriteria();
        }

        private void txtBoxCriteria()
        {
            //creating txtbox criteria function
            lstContent.Items.Clear();
            txtSearch.Visible = true;
            txtSearch.Clear();
            txtSearch.Focus();

        }

        private void lstContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
