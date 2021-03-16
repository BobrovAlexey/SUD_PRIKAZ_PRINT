using System;
using System.Windows.Forms;
using Configuration_Files;
namespace SUD_PRIKAZ_PRINT
{
    public partial class FormListViewDocEdit : Form
    {
        private FormConfigurate ParentFormMain
        {

            get { return ((FormConfigurate)Application.OpenForms["FormConfigurate"]); }
            set { }
        }
        
        public FormListViewDocEdit()
        {
            InitializeComponent();

            if (this.ParentFormMain.listViewDocTemplate.SelectedItems.Count > 0)
            {
                this.textBoxDOC.Text = this.ParentFormMain.listViewDocTemplate.SelectedItems[0].Text;
                this.textBoxDocName.Text = this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[1].Text;


                this.textBoxTemplate.Text = this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[2].Text;
                this.textBoxPrefix.Text = this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[3].Text;
                this.textBoxPostfix.Text = this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[4].Text;
            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {


            FormConfigurate _ParentFormMain = (FormConfigurate)System.Windows.Forms.Application.OpenForms["FormConfigurate"];

            _ParentFormMain.listViewDocTemplate.SelectedItems[0].Text = this.textBoxDOC.Text; ;
            _ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[1].Text = this.textBoxDocName.Text; ;


            this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[2].Text = this.textBoxTemplate.Text;
            this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[3].Text = this.textBoxPrefix.Text ;
            this.ParentFormMain.listViewDocTemplate.SelectedItems[0].SubItems[4].Text = this.textBoxPostfix.Text ;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LabelDocTemplate_Click(object sender, EventArgs e)
        {
            string _ret = FormMain.OpenDialogFile(
                ((FormMain)Application.OpenForms["FormMain"]).Fortmating_Directory
                (this.textBoxTemplate.Text),
                "Word файлы (*.dotx;*.dot;*.doc;*.docx)|*.dotx;*.dot;*.doc;*.docx|Все файлы (*.*)|*.*",
                "Выбор файла для шаблона " + this.textBoxDocName.Text);
            if (_ret != null) this.textBoxTemplate.Text = FormMain.InitalFile(_ret,false);

        }

        private void LabelDocTemplate_MouseHover(object sender, EventArgs e) => FormConfigurate.Static_Label_MouseHover((Label)sender);
        

        private void LabelDocTemplate_MouseLeave(object sender, EventArgs e) => FormConfigurate.Static_Label_MouseLeave((Label)sender);
    }
}
