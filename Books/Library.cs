using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.Business;
using Books.Business;
using Books.Core;
using Dapper; 

namespace Books
{
   /// <summary>
   /// Represents the user interface
   /// </summary>
    public partial class Library : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        public Library()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pdfLibraryBindingSource.DataSource = PdfLibraryService.GetAll();
                bookBindingSource.DataSource = BookService.GetAll();
                ControlContainer.Enabled = false; ///not being able to write anything in the textboxes

            }
            ///throwing an exception if not connected to database
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Adds a new book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) 
        {
            objState = EntityState.Added;
            ControlContainer.Enabled = true;
            bookBindingSource.Add(new Core.Book());
            bookBindingSource.MoveLast();  ///new book is going at last place
            txtBookName.Focus();

        }

        /// <summary>
        /// The user updates already existing data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)  ///Update function
        {
            objState = EntityState.Changed;
            ControlContainer.Enabled = true;  ///we can change information when container is enabled
            txtBookName.Focus();
        }
         
        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e) ///when any part of cell is clicked
        {
        }

        /// <summary>
        /// The user deletes an entry from books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) 
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record>", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ///sending a "Are you sure" message ?"
            {
                try
                {
                    Core.Book obj = bookBindingSource.Current as Core.Book;
                    if (obj != null)
                    {
                        bookBindingSource.List.Remove(obj);
                        BookService.Delete(obj.id);
                        BooksMetroGrid.Refresh();
                    }
                }
                ///throwing an exception if not connected to database
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Saves the changes written in the textboxes(could be either adding a new entry or updating existing entry) to books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)  
        {
            try
            {
                ///handles update existing record
                Core.Book bookToUpdate = bookBindingSource.Current as Core.Book;

                Core.Book newBook = new Core.Book  ///getting the information from text boxes
                {
                    genre = metroTextBox1.Text,
                    book_name = txtBookName.Text,
                    book_author = txtBookAuthor.Text
                };

                if (bookToUpdate.id != 0)
                {
                    newBook.id = bookToUpdate.id;
                    BookService.Update(newBook, objState);
                    /// updating the binding source
                    bookBindingSource.DataSource = BookService.GetAll(); 
                    return;
                }
               
                if (newBook != null)  ///saving the new book
                {
                    newBook = BookService.Save(newBook, objState);
                    bookBindingSource.Add(newBook);
                    ///updating the data base
                    BooksMetroGrid.Refresh();
                    ControlContainer.Enabled = false;
                   
                }
                bookBindingSource.DataSource = BookService.GetAll(); ///updating the binding source
            }
            ///throwing an exception if not connected to database
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtBookID_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Browse button opens a file dialog from where the user can select a file to read
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            byte[] fileContent = null;
            var filePath = string.Empty;

            ///Opening the directory
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
              
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                         filePath = openFileDialog.FileName;
                         ///Read the contents of the file into a stream
                         var fileStream = openFileDialog.OpenFile();

                         using (StreamReader reader = new StreamReader(fileStream))
                         {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                reader.BaseStream.CopyTo(ms);
                                fileContent = ms.ToArray();
                            }
                         }
               }
             }
            ///File is going in the binding source
            PdfLibrary pdfLibrary = new PdfLibrary();
            pdfLibrary.file_name = filePath;
            pdfLibrary.content = fileContent;
            pdfLibraryBindingSource.Add(pdfLibrary);
            PdfLibraryService.Save(pdfLibrary, EntityState.Added);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }

        private void pdfLibraryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }
        /// <summary>
        /// If the user clicks on the Load button, the entry will be loaded
        /// If the user clicks on the Delete button the entry will be deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroGrid2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            const int loadIndex = 2;
            const int deleteIndex = 3;

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                PdfLibrary library = (PdfLibrary)pdfLibraryBindingSource.List[index];

                if (e.ColumnIndex == loadIndex)  ///pdf loader 
                {
                    
                    if (library.file_name != null)
                    {
                        string filePath = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
                        File.WriteAllBytes(filePath, library.content);

                        PDFreader.LoadFile(filePath);
                        PDFreader.src = filePath;

                        PDFreader.setShowToolbar(false); ///disable pdf toolbar.
                        PDFreader.Enabled = true;
                        PDFreader.Show();
                    }
                } else if(e.ColumnIndex == deleteIndex)  ///delete button 
                {

                    pdfLibraryBindingSource.List.Remove(library);
                    PdfLibraryService.Delete(library.id);
                    FilesMetroGrid.Refresh();

                }
               

            }
        }
    }
}
