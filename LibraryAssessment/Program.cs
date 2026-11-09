using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAssessment
{
    internal static class Program
    {
        /// <summary>
        /// Kristopher Mann
        /// Small scale app dev
        /// 13/05/2024
        /// Building an app that acts like a library with the addition of new book entries as well as searching and removing.
        /// The main entry point for the application.
        /// </summary>
        /// 

        private static List<Books> myBooks = new List<Books>();
        public static List<Books> MYBOOKS { get; set; }
        [STAThread]
        static void Main()
        {


           
           StreamReader myReader = new StreamReader(@"..\..\Books.txt");
           while (!myReader.EndOfStream)//Keep on reading data until end of file is reached
           {
                string line = myReader.ReadLine();
                string[] dataArray = line.Split(',');
                if(dataArray.Length >= 4)
                {
                    for(int i = 0; i < dataArray.Length; i++)
                    {
                        dataArray[i] = dataArray[i].Trim();
                    }
                }
                Books aBook = new Books(dataArray[0], dataArray[1], dataArray[2], dataArray[3]);
                myBooks.Add(aBook);
           }
            myReader.Close();

            


            MYBOOKS = myBooks;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
