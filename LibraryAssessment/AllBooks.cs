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
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
            listBooks();
        }

        private void listBooks()
        {
            int counter = 1;
            foreach (Books myBooks in Program.MYBOOKS)
            {
                lstBooks.Items.Add($"{counter}. " +
                $"Name: {myBooks.NAME} " +
                $"Author: {myBooks.AUTHOR} " +
                $"ISBN:{myBooks.ISBN} ");
                counter++;

                //This displays all the books and info except the summary.
            }


        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();//takes back to previous page
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            //This will display all the info about the book as well as return an error if data is insufficient.
            if (txtDetails.Text == "")
            {
                MessageBox.Show("You must enter a value in the text box");
                txtDetails.Focus();
            }
            else
            {
                if (int.TryParse(txtDetails.Text, out int index))
                {
                    if (index < 1 || index > Program.MYBOOKS.Count)
                    {
                        MessageBox.Show($"No such index..\nPlease enter a number between 1 and {Program.MYBOOKS.Count}");
                        txtDetails.Clear();
                        txtDetails.Focus();
                    }
                    else
                    {
                        // Display the selected Books's details
                        var selectedBook = Program.MYBOOKS[index - 1];
                        string booksDetails = $"Name: {selectedBook.NAME}\nAuthor: {selectedBook.AUTHOR}\nISBN: {selectedBook.ISBN}\n Summary:{selectedBook.SUMMARY}"; // Customize this as needed
                        MessageBox.Show($"Selected Book details:\n{booksDetails}");
                        txtDetails.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                    txtDetails.Clear();
                    txtDetails.Focus();
                }
            }
        }
    }
}
