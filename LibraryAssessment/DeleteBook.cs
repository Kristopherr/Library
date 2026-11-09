using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAssessment
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
            listBooks();
        }

        private void listBooks()
        {
            int counter = 1;
            foreach (Books myBooks in Program.MYBOOKS)
            {
                lstContent.Items.Add($"{counter}. " +
                $"Name: {myBooks.NAME} " +
                $"Author: {myBooks.AUTHOR} " +
                $"ISBN:{myBooks.ISBN}");
                counter++;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();//takes back to previous page
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBookDelete.Text == "")
            {
                MessageBox.Show("You must enter a value in the text box");
                txtBookDelete.Focus();
            }
            else
            {
                if (int.TryParse(txtBookDelete.Text, out int index))
                {
                    if (index < 1 || index > Program.MYBOOKS.Count)
                    {
                        MessageBox.Show($"No such index..\nPlease enter a number between 1 and {Program.MYBOOKS.Count}");
                        txtBookDelete.Clear();
                        txtBookDelete.Focus();
                    }
                    else
                    {
                        Program.MYBOOKS.RemoveAt(index - 1);
                        MessageBox.Show("The selected contact was removed successfully");
                        txtBookDelete.Clear();
                        lstContent.Items.Clear();
                        // Display the updated List<Person> content in the listbox
                        listBooks();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                    txtBookDelete.Clear();
                    txtBookDelete.Focus();
                }
            }
        }

    }
}

