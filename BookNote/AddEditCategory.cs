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
    public partial class AddEditCategory : MetroFramework.Forms.MetroForm
    {
        ItemCreator _category = new ItemCreator();
        bool isNewObject;
        private Category current;

        public AddEditCategory(Category obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                isNewObject = true;
            }
            else
            {
                //We editing an existing one
                current = obj;
                tbCategoryName.Text = obj.Name;
                isNewObject = false;
            }
        }

        private void AddEditCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tbCategoryName.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter the category name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCategoryName.Focus();
                    e.Cancel = true;
                    return;
                }
                SaveCategory();
                
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void SaveCategory()
        {
            if (isNewObject)
            {
                current = new Category();
                current.Name = tbCategoryName.Text.Trim();
                _category.InsertCategory(current);
            }
            else
            {
                current.Name = tbCategoryName.Text.Trim();
                _category.UpdateCategory(current);
            }
        }

      
    }
}
