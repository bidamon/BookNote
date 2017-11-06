using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookNote
{
    public partial class AddEditBook : MetroFramework.Forms.MetroForm
    {
        ItemCreator _book = new ItemCreator();
        bool isNewObject;
        private Book currentBook;
        List<Category> categories = new List<Category>();
        private string imageUrl =null;
        public AddEditBook(Book obj)
        {
            InitializeComponent();
            //Get all the categories we need that for the dropdown
            categories = _book.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "CategoryID";

            if (obj == null)
            {
                isNewObject = true;
            }
            else
            {
                //new to populate the form
                tbTitle.Text = obj.Title;
                tbAuthor.Text = obj.Author;
                cbCategory.SelectedValue = obj.CategoryID;
                picture.Image = Image.FromFile(obj.ImageUrl);
                isNewObject = false;
            }
        }

        private void AddEditBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbAuthor.Text)|| (int)cbCategory.SelectedValue <=0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter the category name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbTitle.Focus();
                    e.Cancel = true;
                    return;
                }
                SaveBook();

                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void SaveBook()
        {
            if (isNewObject)
            {
                currentBook = new Book();
                currentBook.Title = tbTitle.Text.Trim();
                currentBook.Author = tbAuthor.Text.Trim();
                currentBook.CategoryID = (int)cbCategory.SelectedValue;
                currentBook.ImageUrl = imageUrl;
                _book.InsertBook(currentBook);
            }
            else
            {
                currentBook.Title = tbTitle.Text.Trim();
                currentBook.Author = tbAuthor.Text.Trim();
                currentBook.CategoryID = (int)cbCategory.SelectedValue;
                _book.UpdateBook(currentBook);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picture.Image = Image.FromFile(ofd.FileName);
                    if (currentBook != null)
                        currentBook.ImageUrl = ofd.FileName;
                    else
                        imageUrl = ofd.FileName;
                }
            }
        }

        
    }
}
