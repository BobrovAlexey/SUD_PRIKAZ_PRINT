using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;


namespace SUD_PRIKAZ_PRINT
{

    public class Array_Element_Paste
    {
        public struct Element_Paste { public string Name, Value; };
        Element_Paste[] Array_Paste;
        public int Count
        {
            get { return this.Array_Paste.Length; }
            set { }
        }
        public Array_Element_Paste(int _Length) =>  this.ReSize(_Length);

        

        public void ReSize(int _Length)
        {
            if (this.Array_Paste == null)
                this.Array_Paste = new Element_Paste[_Length];
            else
            {
                if (this.Array_Paste.Length != _Length)
                    Array.Resize<Element_Paste>(ref this.Array_Paste, _Length);
            }
        }

        public void Add(int _Num, string _Name, string _Value) =>
        
            this.Array_Paste[_Num] = new Array_Element_Paste.Element_Paste() { Name = _Name, Value = _Value };
        

        


        public void Set(int _Num, string _Value, string _Name = null)
        {
            
            if (_Name != null)this.Array_Paste[_Num].Name = _Name;
            this.Array_Paste[_Num].Value = _Value;
        }

        

        public void AddRange( string[] _Str_Title, string[] _Value)
        {
            int _Number_Column;
            for (_Number_Column = 0; 
                _Number_Column  < this.Array_Paste.Length && _Number_Column < _Str_Title.Length && _Number_Column < _Value.Length; 
                _Number_Column++)
            this.Add(_Number_Column, _Str_Title[_Number_Column], _Value[_Number_Column]);
        }


        

        public void AddFromDictionary(ref Dictionary<string,string> _D)
        {
            int _i = 0;
            this.ReSize(_D.Count);
            foreach (string _L_key in _D.Keys) this.Add(_i++, _L_key, _D[_L_key]);
        }

        
        public int FindIndex(string _name, string _value = null)
        {
            if (_value == null)
                return Array.FindIndex(this.Array_Paste, p => String.Compare(p.Name, _name, true) == 0);
            else
                return Array.FindIndex(this.Array_Paste, p => String.Compare(p.Name, _name, true) == 0 && String.Compare(p.Value, _value, true) == 0);
        }
        public Element_Paste this[int _i]
        {
            get
            {
                return this.Array_Paste[_i];
            }
            set
            {
                this.Set(_i, value.Value);
               
                
            }

        }


        public Element_Paste this[string _name]
        {
            get
            {

                int _i = this.FindIndex(_name);
                if (_i== -1) 
                    return new Element_Paste ();
                else
                    return this.Array_Paste[_i];
                
                
            }
            set
            {
                int _i = this.FindIndex(_name);
                if (_i >= 0)  this.Set(_i, value.Value); 

            }

        }


        public Element_Paste this[string _name,string _value]
        {
            get
            {

                int _i = this.FindIndex(_name,_value);
                    if (_i >= 0) return this.Array_Paste[_i];
                else
                            return (Element_Paste)(object)null;
                


            }
            set
            {
            }

        }


    }

    public partial class FormMain : Form
    {

        
        public Array_Element_Paste GeneralPaste;
        public Dictionary<string, Array_Element_Paste> FromReestrPaste;
        public Dictionary<string, Array_Element_Paste> ListDeskPaste;
        public void DiscriptionPasteLoad()
        {
            this.LoadGeneralPaste(); // Загрузка основных вставок
            this.LoadReestr(); // Загрузка вставок из реестра
        }

        private void LoadGeneralPaste()
        {
            //this.GeneralPaste = new Dictionary<string, string>();
            
            
            DateTime _CurenDate = DateTime.Today;
            DateTime _DateDoc = _CurenDate.AddDays(Convert.ToDouble(this.AddDays));

            this.GeneralPaste = new Array_Element_Paste(2);

            //вставка для даты документа (текст)
            this.GeneralPaste.Add (0, "ДАТА ДОКУМЕНТА(ТЕКСТ)",  _DateDoc.ToLongDateString());
            //вставка для даты документа 
            this.GeneralPaste.Add(1, "ДАТА ДОКУМЕНТА", _DateDoc.ToShortDateString());
        }
        private void LoadReestr()
        {
             Excel.Workbook  _WB_Reestr;
             Excel.Worksheet _WS_Reestr;
                       
            

            try
            {
                string _File_Restr = this.Fortmating_Directory(this.Name_File_Reestr);
                _WB_Reestr = this.AppXL.Workbooks.Open(_File_Restr);
                _WS_Reestr = (Excel.Worksheet)_WB_Reestr.Worksheets[1];

            }
            catch (Exception _exp)
            {
                MessageBox.Show(_exp.Message.ToString(), "Ошибка открытия реестра",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.AddUsedRange(ref _WS_Reestr);

            
            
            
            _WB_Reestr.Close(false );
        }






        private void AddUsedRange(ref Excel.Worksheet _WS_Reestr)

        {
            int _Number_Column_Count, _Number_Str_Count, _Number_Column, _Number_Str, _Uch_Column;
            string  _Value,_Title, _INN, _Uch;
            
                                 
            
            Excel.Range _UsedRange = (Excel.Range)_WS_Reestr.UsedRange;

            _Number_Column_Count = _UsedRange.Columns.Count;
            _Number_Str_Count = _UsedRange.Rows.Count;
            //MessageBox.Show(_Number_Column_Count.ToString(), _Number_Str_Count.ToString());
            if (_Number_Column_Count < 7 || _Number_Str_Count < 2)
            {
                _Number_Column_Count = _WS_Reestr.Range[_WS_Reestr.Cells[1], _WS_Reestr.Cells[1]].Find("").Column;
                _Number_Str_Count = _WS_Reestr.Range[_WS_Reestr.Cells[1, 1], _WS_Reestr.Cells[_WS_Reestr.Rows.Count, 1]].Find("").Row;
                MessageBox.Show(_Number_Column_Count.ToString(), _Number_Str_Count.ToString());
                if (_Number_Column_Count < 7 || _Number_Str_Count < 2) return;
                _UsedRange = _WS_Reestr.Range[_WS_Reestr.Cells[1, 1], _WS_Reestr.Cells[_Number_Str_Count, _Number_Column_Count]];
                
            }

            
           
            Excel.Range _Uch_Column_Cell =  _UsedRange.Range[_UsedRange.Cells[1, 1], _UsedRange.Cells[1, _UsedRange.Column]].Find("УЧАСТОК");
            _Uch_Column = _Uch_Column_Cell == null ?  0: _Uch_Column_Cell.Column;
            this.FromReestrPaste = new Dictionary<string, Array_Element_Paste>();

            for (_Number_Str = 2; _Number_Str <= _Number_Str_Count; _Number_Str++)
            {

                Array_Element_Paste _Str_One = new Array_Element_Paste(_Number_Column_Count + (_Uch_Column == 0 ? 1 : 0));
                
                for (_Number_Column = 1; _Number_Column <= _Number_Column_Count; _Number_Column++)
                {
                    _Title =  ((Excel.Range)_UsedRange[1,_Number_Column]).Text.ToString().ToUpper();
                    _Value = ((Excel.Range)_UsedRange[_Number_Str, _Number_Column]).Text.ToString().Replace("0:00:00", "");
                    _Str_One.Add(_Number_Column-1, _Title, _Value);
             
                }
                if (_Uch_Column == 0) _Str_One.Add(_Number_Column_Count, "УЧАСТОК", this.Number_Uch_Default);
                else
                {
                    _Uch = _Str_One["УЧАСТОК"].Value;
                    if (String.IsNullOrEmpty(_Uch ) || !this.deskSud.ContainsKey(_Uch ) )
                    _Str_One.Set(_Uch_Column-1, this.Number_Uch_Default, "УЧАСТОК");
                }
                
                _INN = _Str_One["ИНН"].Value;
                if ((!String.IsNullOrEmpty(_INN)) && (!this.FromReestrPaste.ContainsKey(_INN)))
                {
                    this.FromReestrPaste.Add(_INN, _Str_One);
                }

            }

           



        }

       
        private bool Control_Paste()
        {

            bool _ret1, _ret2= true;

            bool _ret = this.FromReestrPaste != null;
                _ret &= this.FromReestrPaste.Count > 0;
            if (! _ret )
            {
                this.Mark_Execution = false;
                this.toolStripProgressBar.Visible = this.Mark_Execution;
                MessageBox.Show("Реестр со значениями пуст ", "Ошибка определения вставок из реестра",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _ret;

            }
            _ret1 = this.ListDeskPaste != null;
            _ret1 &= this.ListDeskPaste.Count > 0;
            _ret1 &= this.deskSud.Count > 1;

            if (!_ret1)
            {
                this.Mark_Execution = false;
                this.toolStripProgressBar.Visible = this.Mark_Execution;
                MessageBox.Show("Список вставок участка пуст ", "Ошибка определения вставок из описания участков",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }

            _ret1 = this.List_FileTemplateOut != null;
            _ret1 &= this.List_FileTemplateOut.Count > 0;

            if (!_ret1)
            {
                this.Mark_Execution = false;
                this.toolStripProgressBar.Visible = this.Mark_Execution;
                MessageBox.Show("Список шаблонов пуст ", "Ошибка определения описания шаблонов",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            if (this.Number_Uch_Default == "0")
            {
                foreach (string _INN in this.FromReestrPaste.Keys)
                {
                    if (!this.deskSud.ContainsKey(this.FromReestrPaste[_INN]["Участок"].Value)) _ret2 = false;
                }
                
                if (_ret2 == false)
                {
                    this.Mark_Execution = false;
                    this.toolStripProgressBar.Visible = this.Mark_Execution;
                    MessageBox.Show("В реестре присутсвуют строки с неверным участком. Укажите участок по умолчанию", "Ошибка определения вставок",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            

            

            return _ret&&_ret1&&_ret2;
        }

    }
}