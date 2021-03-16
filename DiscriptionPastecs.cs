using System;

public class DiscriptionPaste
{

    private FormMain ParentFormMain;
    

    private string S_Start   // конец вставки
    {
        get { return (this.ParentFormMain.S_Start); }

    }

    private string S_End   // конец вставки
    {
        get { return (this.ParentFormMain.S_End); }

    }

    private string Number_Uch_Default  //номер участка по умолчанию
    {
        get { return (this.ParentFormMain.Number_Uch_Default); }

    }

    Dictionary <string,string> GeneralPaste;
    Dictionary <string, string> FromReestrPaste;
    //Dictionary<string, string> ForDeskPaste;
    public DiscriptionPaste()
    {
    

    this.ParentFormMain= (FormMain)System.Windows.Forms.Application.OpenForms["FormMain"];
    
    }
}
