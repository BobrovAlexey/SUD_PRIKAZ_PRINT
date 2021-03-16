using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SUD_PRIKAZ_PRINT
{

    public partial class FormConfigurate : Form
    {
        private FormMain ParentFormMain
        {

            get { return ((FormMain)Application.OpenForms["FormMain"]); }
        }


        public Dictionary<string, Array_Element_Paste> ListDeskPaste_Tmp;
        public FormConfigurate()
        {
            InitializeComponent();
            this.LoadValue();
        }

        private void LoadValue()
        {


            this.textBoxS_Start.Text = this.ParentFormMain.Sym_Start;
            this.textBoxS_End.Text = this.ParentFormMain.Sym_End;
            this.numericUpDownAddDays.Value = this.ParentFormMain.AddDays;
            this.textBoxName_File_Out_Template.Text = this.ParentFormMain.Name_File_Out_Template;
            this.textBoxName_Reestr.Text = this.ParentFormMain.Name_File_Reestr;
            this.textBoxInp.Text = this.ParentFormMain.Directory_Inp;
            this.textBoxOut.Text = this.ParentFormMain.Directory_Out;
            this.textBoxTemplates.Text = this.ParentFormMain.Directory_Tempalates;
            this.textBoxZPT.Text = this.ParentFormMain.Separator;
            this.textBoxRub.Text = this.ParentFormMain.Valuta;
            this.numericUpDownPadLeft.Value = this.ParentFormMain.Count_PadL;


            foreach (string _DeskKey in this.ParentFormMain.deskSud.Keys)
            {

                this.listViewDesk.Items.Add(_DeskKey).SubItems.Add(ParentFormMain.deskSud[_DeskKey]);

            }

            if (this.ParentFormMain.List_FileTemplateOut != null)
            {
                this.ParentFormMain.List_FileTemplateOut.ForEach(x =>
                   this.listViewDocTemplate.Items.Add(x.TypeFile)
                   .SubItems.AddRange(new string[4] { x.NameFileOutput, x.NameFileTemlate, x.Prefix, x.Postfix }));
            }

            this.ListDeskPaste_Tmp = this.ParentFormMain.ListDeskPaste;

        }

        private void SaveValue()
        {

            this.ParentFormMain.Sym_Start = this.textBoxS_Start.Text;
            this.ParentFormMain.Sym_End = this.textBoxS_End.Text;
            this.ParentFormMain.AddDays = Convert.ToByte(this.numericUpDownAddDays.Value);
            this.ParentFormMain.Name_File_Out_Template = this.textBoxName_File_Out_Template.Text;
            this.ParentFormMain.Name_File_Reestr = this.textBoxName_Reestr.Text;
            this.ParentFormMain.Directory_Inp = this.textBoxInp.Text;
            this.ParentFormMain.Directory_Out = this.textBoxOut.Text;
            this.ParentFormMain.Directory_Tempalates = this.textBoxTemplates.Text;
            this.ParentFormMain.Separator = this.textBoxZPT.Text;
            this.ParentFormMain.Valuta = this.textBoxRub.Text;
            this.ParentFormMain.Count_PadL = Convert.ToByte(this.numericUpDownPadLeft.Value);

            if (this.ParentFormMain.deskSud == null)
            {
                this.ParentFormMain.deskSud = new Dictionary<string, string>();
            } else
                this.ParentFormMain.deskSud.Clear();
            this.listViewDesk.Sort();
            foreach (ListViewItem _DeskKey in this.listViewDesk.Items)
            {
                this.ParentFormMain.deskSud.Add(_DeskKey.Text, _DeskKey.SubItems[1].Text);
                
            }

            

            if (this.ParentFormMain.List_FileTemplateOut == null)
            {
                this.ParentFormMain.List_FileTemplateOut = new List<FileForPrintOut>();
            }
            else
            this.ParentFormMain.List_FileTemplateOut.Clear();
            this.listViewDocTemplate.Sort();
            foreach (ListViewItem _DocKey in this.listViewDocTemplate.Items)
            {

                FileForPrintOut _item = new FileForPrintOut(_DocKey.Text, _DocKey.SubItems[1].Text)
                {
                    NameFileTemlate = _DocKey.SubItems[2].Text,
                    Prefix = _DocKey.SubItems[3].Text,
                    Postfix = _DocKey.SubItems[4].Text
                };
                
                this.ParentFormMain.List_FileTemplateOut.Add(_item);

            }


            this.ParentFormMain.ListDeskPaste = this.ListDeskPaste_Tmp;

         //   this.ParentFormMain.LoadDiscriptionFilePaste();

          //  this.ParentFormMain.SaveValue();

        }



        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            this.SaveValue();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditInItemDesk(int Old_Item_Before_Add = -1)
        {
            using (FormListViewDeskEdit _F = new FormListViewDeskEdit())
            {
                int _i = -1;


                if (this.listViewDesk.SelectedIndices.Count > 0)
                {
                    _i = this.listViewDesk.SelectedIndices[0];
                    if (_F.ShowDialog() == DialogResult.Cancel && Old_Item_Before_Add >= 0)
                    {
                        this.listViewDesk.Items[_i].SubItems.Clear();
                        this.listViewDesk.Items.RemoveAt(_i);
                        _i = Old_Item_Before_Add;


                    }

                    if (_i >= 0 && _i < this.listViewDesk.Items.Count)
                        this.listViewDesk.Items[_i].Selected = true;
                }
                this.listViewDesk.Sort();
            }
        }

        
        private void DeleteInItemDesk()
        { 
            if (this.listViewDesk.Items.Count > 0)
                this.listViewDesk.Items.RemoveAt(this.listViewDesk.SelectedIndices[0]);
        }


        private void AddInItemDesk()
        {
            int Old_Item_Before_Add = -1;
               if(this.listViewDesk.SelectedIndices.Count > 0) 
                Old_Item_Before_Add =this.listViewDesk.SelectedIndices[0];
            ListViewItem _item = new ListViewItem { Text = "Новый код" };
            _item.SubItems.Add("Новое имя");
            this.listViewDesk.Items.Add(_item);
            _item.EnsureVisible(); // делает видимой последнюю строку
            _item.Selected = true; // делает выделенной последнюю строку
            if (Old_Item_Before_Add == -1 &&  this.listViewDesk.SelectedIndices.Count > 0)
                Old_Item_Before_Add = this.listViewDesk.SelectedIndices[0];
            EditInItemDesk(Old_Item_Before_Add);
        }
        
        private void DeskToolStripMenuItemEdit_Click(object sender, EventArgs e) => EditInItemDesk();
        private void ListViewDesk_DoubleClick(object sender, EventArgs e) => this.EditInItemDesk();

        private void DeskToolStripMenuItemDel_Click(object sender, EventArgs e) => DeleteInItemDesk();


        private void DeskToolStripMenuItemAdd_Click(object sender, EventArgs e) => AddInItemDesk();
        

        private void EditInItemDoc(int Old_Item_Before_Add = -1)
        {
            if (this.listViewDocTemplate.SelectedIndices.Count > 0)
            {
                using (FormListViewDocEdit _F = new FormListViewDocEdit())
                {

                    int _i = this.listViewDocTemplate.SelectedIndices[0];
                    if (_F.ShowDialog() == DialogResult.Cancel && Old_Item_Before_Add >= 0)
                    {
                        this.listViewDocTemplate.Items[_i].SubItems.Clear();
                        this.listViewDocTemplate.Items.RemoveAt(_i);
                        _i = Old_Item_Before_Add;
                    }

                    if (_i >= 0 && _i < this.listViewDocTemplate.Items.Count )
                        this.listViewDocTemplate.Items[_i].Selected = true;
                                        
                }
                this.listViewDocTemplate.Sort();
            }
        }

        private void AddItemInDoc()
        {
            int Old_Item_Before_Add = -1;
            if(this.listViewDocTemplate.SelectedIndices.Count > 0)
                Old_Item_Before_Add=this.listViewDocTemplate.SelectedIndices[0];
            ListViewItem _item = new ListViewItem { Text = "Новый код" };
            _item.SubItems.AddRange(new string[4] { "Новое имя", "", "", "" });
            this.listViewDocTemplate.Items.Add(_item);
            _item.EnsureVisible(); // делает видимой последнюю строку
            _item.Selected = true; // делает выделенной последнюю строку
            if(Old_Item_Before_Add == -1 && this.listViewDocTemplate.SelectedIndices.Count > 0) 
                Old_Item_Before_Add = this.listViewDocTemplate.SelectedIndices[0];
            EditInItemDoc(Old_Item_Before_Add);
        }

        private void DeleteItemInDoc()
        {
            if (this.listViewDocTemplate.Items.Count > 0)
                this.listViewDocTemplate.Items.RemoveAt(this.listViewDocTemplate.SelectedIndices[0]);
        }
        private void DocStripMenuItemEdit_Click(object sender, EventArgs e) => EditInItemDoc();
        
        private void ListViewDocTemplate_DoubleClick(object sender, EventArgs e) => this.EditInItemDoc();



        private void DocStripMenuItemDel_Click(object sender, EventArgs e) => this.DeleteItemInDoc();
        private void DoclStripMenuItemAdd_Click(object sender, EventArgs e) => this.AddItemInDoc();
      
        private void LabelNameReestr_Click(object sender, EventArgs e)
        {

            string _ret = FormMain.OpenDialogFile(
                this.ParentFormMain.Fortmating_Directory(this.textBoxName_Reestr.Text),
                "Excel файлы (*.xlsx;*.xls)|*.xlsx;*.xls|Все файлы (*.*)|*.*",
                "Выбор файла реестра");
            if (_ret != null) this.textBoxName_Reestr.Text = FormMain.InitalFile(_ret, false);
        }

        private void LabelInp_Click(object sender, EventArgs e)
        {

            string _ret =
            FormMain.OpenDialogDirectory(this.ParentFormMain.Fortmating_Directory(this.textBoxInp.Text),
            "Выбор входящего каталога");

            if (_ret != null) this.textBoxInp.Text = FormMain.InitalFile(_ret);

        }

        private void LabelOut_Click(object sender, EventArgs e)
        {
            string _ret =
            FormMain.OpenDialogDirectory(this.ParentFormMain.Fortmating_Directory(this.textBoxOut.Text),
            "Выбор исходящего каталога");

            if (_ret != null) this.textBoxOut.Text = FormMain.InitalFile(_ret);
        }

        private void LabelTemplates_Click(object sender, EventArgs e)
        {
            string _ret =
            FormMain.OpenDialogDirectory(this.ParentFormMain.Fortmating_Directory(this.textBoxTemplates.Text),
            "Выбор каталога c шаблонами");


            if (_ret != null) this.textBoxTemplates.Text = FormMain.InitalFile(_ret);
        }

        public static void Static_Label_MouseHover(Label _Obj)
        {
            _Obj.Font = new Font(_Obj.Font.FontFamily, _Obj.Font.Size, FontStyle.Underline | FontStyle.Bold, _Obj.Font.Unit);
            _Obj.ForeColor = Color.DarkSlateGray;
        }

        public static void Static_Label_MouseLeave(Label _Obj)
        {
            _Obj.Font = new Font(_Obj.Font.FontFamily, _Obj.Font.Size, FontStyle.Regular, _Obj.Font.Unit);
            _Obj.ForeColor = SystemColors.ControlText;
        }

        private void LabelNameReestr_MouseHover(object sender, EventArgs e) => Static_Label_MouseHover((Label)sender);

        private void LabelNameReestr_MouseLeave(object sender, EventArgs e) => Static_Label_MouseLeave((Label)sender);

        private void LabelInp_MouseHover(object sender, EventArgs e) => Static_Label_MouseHover((Label)sender);

        private void LabelInp_MouseLeave(object sender, EventArgs e) => Static_Label_MouseLeave((Label)sender);

        private void LabelOut_MouseHover(object sender, EventArgs e) => Static_Label_MouseHover((Label)sender);


        private void LabelOut_MouseLeave(object sender, EventArgs e) => Static_Label_MouseLeave((Label)sender);

        private void LabelTemplates_MouseHover(object sender, EventArgs e) => Static_Label_MouseHover((Label)sender);

        private void LabelTemplates_MouseLeave(object sender, EventArgs e) => Static_Label_MouseLeave((Label)sender);

                
       
        

        private void ListViewDesk_KeyDown(object sender, KeyEventArgs e)
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
                    this.EditInItemDesk();
                    break;
            }
        }

        private void ListViewDocTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    this.DeleteItemInDoc();
                    break;

                case Keys.Insert:
                    this.AddItemInDoc();
                    break;

                case Keys.Enter:
                    this.EditInItemDoc();
                    break;
            }

        }
    }

}
