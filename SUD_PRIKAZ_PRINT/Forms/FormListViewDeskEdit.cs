using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SUD_PRIKAZ_PRINT
{
    public partial class FormListViewDeskEdit : Form
    {
        private int Index;
        public FormListViewDeskEdit()
        {
            InitializeComponent();
            FormConfigurate _ParentFormMain = (FormConfigurate)System.Windows.Forms.Application.OpenForms["FormConfigurate"];
            if (_ParentFormMain.listViewDesk.SelectedItems.Count > 0)
            {
                this.TextBoxUCH.Text = _ParentFormMain.listViewDesk.SelectedItems[0].Text;
                this.TextBoxSUD.Text = _ParentFormMain.listViewDesk.SelectedItems[0].SubItems[1].Text;

                if (_ParentFormMain.ListDeskPaste_Tmp.ContainsKey(this.TextBoxUCH.Text))
                {
                    for (int _i = 0; _i < _ParentFormMain.ListDeskPaste_Tmp[this.TextBoxUCH.Text].Count; _i++)
                        this.ListViewDeskPaste.Items.Add(_ParentFormMain.ListDeskPaste_Tmp[this.TextBoxUCH.Text][_i].Name)
                            .SubItems.Add(_ParentFormMain.ListDeskPaste_Tmp[this.TextBoxUCH.Text][_i].Value);
                }
            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {


            FormConfigurate _ParentFormMain = (FormConfigurate)System.Windows.Forms.Application.OpenForms["FormConfigurate"];

        
            _ParentFormMain.ListDeskPaste_Tmp.Remove(_ParentFormMain.listViewDesk.SelectedItems[0].Text);
            Array_Element_Paste _ListDeskPaste_One = new Array_Element_Paste(this.ListViewDeskPaste.Items.Count);


            

            for(int _i=0; _i < this.ListViewDeskPaste.Items.Count;  _i++)
            {

            _ListDeskPaste_One.Add(_i, this.ListViewDeskPaste.Items[_i].SubItems[0].Text, this.ListViewDeskPaste.Items[_i].SubItems[1].Text);

            }
            

            _ParentFormMain.ListDeskPaste_Tmp.Add(this.TextBoxUCH.Text, _ListDeskPaste_One);
            _ParentFormMain.listViewDesk.SelectedItems[0].Text = this.TextBoxUCH.Text; 
            _ParentFormMain.listViewDesk.SelectedItems[0].SubItems[1].Text = this.TextBoxSUD.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void EdititemListDesk()
        {
            if (this.ListViewDeskPaste.Items.Count > 0)
            {
                this.Index = this.ListViewDeskPaste.SelectedIndices[0];
                this.GroupBoxEdit.Visible = true;
                this.TextBoxPaste.Text = this.ListViewDeskPaste.Items[this.Index].Text;
                this.TextBoxDescription.Text =
                    this.ListViewDeskPaste.Items[this.Index].SubItems[1].Text;
                this.TextBoxPaste.Focus();
            }

        }

        private void AddInItemDesk()
        {
            ListViewItem _item = new ListViewItem { Text = "Новый код" };
            _item.SubItems.Add("Новое имя");
            this.ListViewDeskPaste.Items.Add(_item);
            _item.EnsureVisible(); // делает видимой последнюю строку
            _item.Selected = true; // делает выделенной последнюю строку
            EdititemListDesk();
        }

        private void DeleteInItemDesk()
        {
            if (this.ListViewDeskPaste.Items.Count > 0)
                this.ListViewDeskPaste.Items.RemoveAt(this.ListViewDeskPaste.SelectedIndices[0]);
        }

        private void DeskToolStripMenuItemAdd_Click(object sender, EventArgs e) => this.AddInItemDesk();
       




        private void DeskToolStripMenuItemDel_Click_1(object sender, EventArgs e)=> this.DeleteInItemDesk();

        private void DeskToolStripMenuItemEdit_Click(object sender, EventArgs e) =>  EdititemListDesk();

        
        
        private void ListViewDeskPaste_SelectedIndexChanged(object sender, EventArgs e) =>  this.GroupBoxEdit.Visible = false;
            
                
       

        private void ListViewDeskPaste_DoubleClick(object sender, EventArgs e) => this.EdititemListDesk();
          

        private void ListViewDeskPaste_KeyDown(object sender, KeyEventArgs e)
        {

                           
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        this.DeleteInItemDesk();
                        break;

                    case Keys.Insert:
                        this.AddInItemDesk();
                        break;

                    case Keys.Enter:
                        this.EdititemListDesk();
                        break;
                }

            
        }

        private void TextBoxPaste_Enter(object sender, EventArgs e)
        {
           
        }

        private void TextBoxPaste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.ListViewDeskPaste.Items.Count > 0)
                    this.ListViewDeskPaste.Items[this.Index].Text = this.TextBoxPaste.Text;

                this.TextBoxDescription.Focus();
            }

            
        }

        private void TextBoxDescription_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (this.ListViewDeskPaste.Items.Count > 0)
                    this.ListViewDeskPaste.Items[this.Index].SubItems[1].Text = this.TextBoxDescription.Text;
                                
                this.ListViewDeskPaste.Focus();
                this.GroupBoxEdit.Visible = false;
            }

        }

     

    }
}
