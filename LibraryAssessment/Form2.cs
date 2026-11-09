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

namespace LibraryAssessment
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        private void showPage(Form page)
        {
            page.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the library, Goodbye!");
            Environment.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();//hides previous page
            AddBook AddBook = new AddBook();
            AddBook.Show();//shows the add page
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides previous page
            
            //path to point to the file located in the same folder as the .cs files
            /*StreamReader myReader = new StreamReader(@"..\..\Books.txt");
            string line = "";
            while (!myReader.EndOfStream)//Keep on reading data until end of file is reached
            {
                line += myReader.ReadLine() + "\n";
            }
            myReader.Close();*/
            
            AllBooks allBooks = new AllBooks();

            //Adding the data to the listbox
            //add range adds line by line.
            //allBooks.lstBooks.Items.AddRange(line.Split('\n'));


            allBooks.Show();//shows all books page
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();//hides previous page
            Search searchBooks = new Search();
            searchBooks.Show();//shows search page
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();//hides previous page
            DeleteBook deleteBook = new DeleteBook();
            deleteBook.Show();//shows delete book page
        }
    }
}
