﻿using System;
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
    public partial class Administration : MetroFramework.Forms.MetroForm
    {
        List<Category> categories = new List<Category>();
        List<Book> books = new List<Book>();
        ItemCreator _items =new ItemCreator();
        public Administration()
        {
            InitializeComponent();
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddEditCategory frm = new AddEditCategory(null))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadCategories();
                    LoadBooks();
                    categoryBindingSource.MoveLast();
                }
            }
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            categories = _items.GetAllCategories();
            categoryBindingSource.DataSource = categories;
        }
        private void LoadBooks()
        {
            books = _items.GetBooksByCategory(categoryBindingSource.Current as Category);
            bookBindingSource.DataSource = books;
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Category obj = categoryBindingSource.Current as Category;
            using (AddEditCategory frm = new AddEditCategory(obj))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadCategories();
                }
                
            }
        }

        private void miAddBook_Click(object sender, EventArgs e)
        {
            using (AddEditBook frm = new AddEditBook(null))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadBooks();
                }
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void bookgrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Book obj = bookBindingSource.Current as Book;
            using (AddEditBook frm = new AddEditBook(obj))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadBooks();
                }

            }
        }
    }
}
