using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SUD_PRIKAZ_PRINT
{
    class InputFileWithPaste
    {
        //  public string INN;
        //  public int Number_File;

        private FormMain ParentFormMain
        {

            get { return ((FormMain)System.Windows.Forms.Application.OpenForms["FormMain"]); }
            set { }
        }


        private Excel.Workbook WB_Input;
        private readonly Excel.Worksheet WS_Input;
        private Array_Element_Paste FromPrilPaste;
        public InputFileWithPaste(string _Inp, int _Num)
        {

            string _INN = "";
            this.OpenFileXls(_Inp);

            try
            {


                this.WS_Input = this.WB_Input.Worksheets[1] as Excel.Worksheet;
                _INN = Put_Parameters();



            }
            catch (Exception _exp)
            {

                this.ParentFormMain.Error_During_Execution = true;
                FormMain.Static_StatusStripMessage("Ошибка получения информации из файла приложения " + _Inp);
                MessageBox.Show(_exp.Message.ToString(),
                "Ошибка получения информации из файла приложения " + _Inp,
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.CloseFileXls(_Inp);
            }

            if (this.ParentFormMain.Error_During_Execution == true) return;

            if (this.ParentFormMain.FromReestrPaste.ContainsKey(_INN))

            {

                //FileOutFromInp _File_Out = 
                    new FileOutFromInp(_Num, _INN, ref this.FromPrilPaste);

               
            }
            else
            {
                FormMain.Static_StatusStripMessage("Должника с ИНН " + _INN + " из файла " + _Inp + " в реестре");
            }

        }


        private void CloseFileXls(string _Name_File)
        { 
        try
        {

                this.WB_Input.Close(0);

            }
        catch (Exception _exp)
        {
                this.ParentFormMain.Error_During_Execution = true;
                MessageBox.Show(_exp.Message.ToString(),
                "Ошибка закрытия входящего Excel документа "+ _Name_File,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

        }
    private void OpenFileXls(string _Name_File)
    {

        try
        {

            this.WB_Input = this.ParentFormMain.AppXL.Workbooks.Open(_Name_File);
                
        }
        catch (Exception _exp)
        {
                this.ParentFormMain.Error_During_Execution = true;
                MessageBox.Show(_exp.Message.ToString(), 
                "Ошибка открытия входящего Excel документа "+ _Name_File,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

        // Получение и ввод данных

        private string Put_Parameters()
        {
            Excel.Range _UsedRange;
            int _Num_Column, _CoordX, _CoordY, _X_Max, _Y_Max;
            decimal _Total_Sum,_Total_Nalog=0,_Total_Peni=0,_Total_Shtraf=0;
            bool _right_border;
            string VbCrlF = "\n\t";
            string _INN = "", _FIO_INN, _Value, _Text_Str = "", _Text_Poluch = "";
            string Name_Nalog_Str, Sum_Nalog_Str, Sum_Peni_Str, Sum_Shtraf_Str, KBK_Str,KBK_ALL,N_KBK="", OKTMO_Str, UFK_Str, INN_Str;
            string _Total_Sum_Str , _Total_Nalog_Str , _Total_Peni_Str , _Total_Shtraf_Str ;


            _UsedRange = (Excel.Range)this.WS_Input.UsedRange;
            _X_Max = _UsedRange.Columns.Count;
            _Y_Max= _UsedRange.Rows.Count;


            _CoordY = this.ExcelFindretRow(@"ИНН",4);
           _FIO_INN = this.Ret_StringInCellsRange(_CoordY, 5,2 ,"ИНН");
            int _P_END = this.ExcelFindretRow(@"НАЧАЛЬНИК", _Y_Max); // Если нет признака конца проверить как минимум это количество
            int _P_EXIST_TAB_1 = this.ExcelFindretRow(@"НАЛОГИ (СБОРЫ), А ТАКЖЕ ПЕНИ И ШТРАФЫ, ЗАЧИСЛЯЕМЫЕ НА СЧЕТА ОРГАНОВ ФЕДЕРАЛЬНОГО КАЗНАЧЕЙСТВА");
            int _P_EXIST_TAB_2 = this.ExcelFindretRow(@"НАЛОГИ (СБОРЫ), А ТАКЖЕ ПЕНИ И ШТРАФЫ, ЗАЧИСЛЯЕМЫЕ НА СЧЕТА ФИНАНСОВЫХ ОРГАНОВ СУБЪЕКТОВ РФ");


            if (_FIO_INN.Length > 18)  _INN = _FIO_INN.Substring(_FIO_INN.Length - 12);
            _CoordY++;
            
            do
            {

                Name_Nalog_Str = ""; Sum_Nalog_Str = ""; Sum_Peni_Str = ""; Sum_Shtraf_Str = "";
                KBK_Str = ""; OKTMO_Str = ""; KBK_ALL=""; INN_Str=""; UFK_Str="";

                if (_CoordY == _P_EXIST_TAB_1 || _CoordY == _P_EXIST_TAB_2) _CoordY += 2;
                _CoordY++;

                                
                _Num_Column = -1;
                _CoordX = 0;
                
                do
                {
                    _CoordX++;

                    
                    _Value = ((Excel.Range)_UsedRange[_CoordY, _CoordX]).Text.ToString().Replace("0:00:00", "").Trim();
                    _right_border = 
                       (Excel.XlLineStyle)((Excel.Range)_UsedRange[_CoordY, _CoordX]).Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle 
                       == Excel.XlLineStyle.xlContinuous;
                    
                    if (_right_border) _Num_Column++;
                        switch (_Num_Column)
                        {
                            case 1:
                                Name_Nalog_Str = _Value;
                            break;

                            case 2:
                                _Total_Nalog += this.ToDecimal(_Value);
                                Sum_Nalog_Str = this.Format_Rub( _Value,this.ParentFormMain.Separator,this.ParentFormMain.Count_PadL);
                            break;
                            
                            case 3:
                                _Total_Peni += this.ToDecimal(_Value);
                                Sum_Peni_Str = this.Format_Rub(_Value, this.ParentFormMain.Separator, this.ParentFormMain.Count_PadL);
                            break;
                            
                            case 4:
                                _Total_Shtraf += this.ToDecimal(_Value);
                                Sum_Shtraf_Str = this.Format_Rub(_Value, this.ParentFormMain.Separator, this.ParentFormMain.Count_PadL);
                            break;

                            case 5:
                                KBK_Str = _Value;
                                KBK_ALL = KBK_Str.Substring(0, 13) + "00" + KBK_Str.Substring(15, 5);
                                _CoordX+= _P_EXIST_TAB_1 > 0 && _CoordY < _P_EXIST_TAB_2 ?  1 : 0;
                            break;

                            case 6:
                                OKTMO_Str = _Value;
                              break;

                            case 7:
                                 UFK_Str = _Value;
                                _CoordX += _P_EXIST_TAB_1 > 0 && _CoordY < _P_EXIST_TAB_2 ? 1 : 0;
                            break;

                            case 8:
                                INN_Str = _Value;
                            break;

                        }

                    
                    _CoordX+= ((Excel.Range)_UsedRange[_CoordY, _CoordX]).MergeArea.Count-1;
                }
                while (_Num_Column < 8 && _CoordX <=  _X_Max);    


                if ((!String.IsNullOrEmpty(Sum_Nalog_Str)) || (!String.IsNullOrEmpty(Sum_Peni_Str)) || (!String.IsNullOrEmpty(Sum_Shtraf_Str)))
                {




                    if (N_KBK != KBK_ALL)
                    {


                        if (!String.IsNullOrEmpty(_Text_Str))
                        {
                            _Text_Str = _Text_Str.Substring(0, _Text_Str.Length - 1);
                            if (!String.IsNullOrEmpty(_Text_Poluch))
                            {
                                _Text_Str +=  VbCrlF + _Text_Poluch + VbCrlF;
                            }
                           
                        }
                        if (!String.IsNullOrEmpty(Name_Nalog_Str))
                        {
                            _Text_Str +=  " - " + Name_Nalog_Str + " : ";
                        }
                    }



                    if (!String.IsNullOrEmpty(Sum_Nalog_Str))
                    {
                        _Text_Str += (VbCrlF + KBK_Str + "  " + OKTMO_Str + "  ( налог )  - ").PadRight(45)
                                      + Sum_Nalog_Str + " "+this.ParentFormMain.Valuta+" ,";
                    }


                    if (!String.IsNullOrEmpty(Sum_Peni_Str))
                    {
                        _Text_Str += (VbCrlF + KBK_Str + "  " + OKTMO_Str + "  ( пени  )  - ").PadRight(45)
                            + Sum_Peni_Str + " "+ this.ParentFormMain.Valuta + " ,";
                    }


                    if (!String.IsNullOrEmpty(Sum_Shtraf_Str))
                    {
                        _Text_Str += (VbCrlF + KBK_Str + "  " + OKTMO_Str + "  (штраф)  - ").PadRight(45)
                            + Sum_Shtraf_Str + " " + this.ParentFormMain.Valuta + " ,";
                    }


                    INN_Str = INN_Str.Replace("\t", "").Replace("\n", "");
                    UFK_Str = UFK_Str.Replace("\t", "").Replace("\n", "");

                    _Text_Poluch = "Реквизиты счета и получателя : " + VbCrlF + INN_Str + "," + UFK_Str+"." + VbCrlF;
                    _Text_Poluch = _Text_Poluch.Replace(",",", ");
                    

                }
                
                N_KBK = KBK_ALL;
            } while (_CoordY < _P_END );

           
            if (!String.IsNullOrEmpty(_Text_Str))_Text_Str = _Text_Str.Substring(0, _Text_Str.Length - 1);

            _Text_Str += VbCrlF + _Text_Poluch;

            _Total_Sum = _Total_Nalog + _Total_Peni + _Total_Shtraf;

            _Total_Sum_Str = this.Format_Rub(_Total_Sum.ToString("#.##"), this.ParentFormMain.Separator, this.ParentFormMain.Count_PadL) +
                " " + this.ParentFormMain.Valuta;

            _Total_Nalog_Str = this.Format_Rub(_Total_Nalog.ToString("#.##"), this.ParentFormMain.Separator, this.ParentFormMain.Count_PadL) +
                " " + this.ParentFormMain.Valuta;

            _Total_Peni_Str = this.Format_Rub(_Total_Peni.ToString("#.##"), this.ParentFormMain.Separator, this.ParentFormMain.Count_PadL) +
                " " + this.ParentFormMain.Valuta;

            _Total_Shtraf_Str = this.Format_Rub(_Total_Shtraf.ToString("#.##"), this.ParentFormMain.Separator, this.ParentFormMain.Count_PadL) +
                " " + this.ParentFormMain.Valuta;


            if (this.FromPrilPaste == null) this.FromPrilPaste = new Array_Element_Paste(5);
            else this.FromPrilPaste.ReSize(5);

            this.FromPrilPaste.Add(0, "Налог_Сумма", _Text_Str);
            this.FromPrilPaste.Add(1, "Общая_Сумма", _Total_Sum_Str);
            this.FromPrilPaste.Add(2, "Общая_Сумма_Налог", _Total_Nalog_Str);
            this.FromPrilPaste.Add(3, "Общая_Сумма_Пени",  _Total_Peni_Str);
            this.FromPrilPaste.Add(4, "Общая_Сумма_Штраф", _Total_Shtraf_Str);
            return _INN;
        }



        private decimal ToDecimal(string _Value)
        {
            decimal _ret = 0;
           
                _Value = _Value.Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString());
                _Value = _Value.Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString());
                _Value = _Value.Replace(this.ParentFormMain.Separator,
                    System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString());

            
            if (!String.IsNullOrEmpty(_Value))  _ret=Convert.ToDecimal(_Value);
            return _ret;
        }
        private string Ret_StringInCellsRange(int _CoordY, int _CoordX, int _CoordX_range, string _Templ = null)
        {
            string _ret = "";
            for (int _i = _CoordX; _i < _CoordX+_CoordX_range; _i++)
            {
                string _value = this.Ret_Value(_CoordY, _i);
                if (!String.IsNullOrEmpty(_value))
                {
                    if (_Templ == null || _value.IndexOf(_Templ, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        _ret = _value;
                        break;
                    }
                }
            }

            return _ret;
        }

      

        private string Ret_Value(int _i, int _j)
        {
            string _ret;
            Excel.Range rng = (Excel.Range)this.WS_Input.get_Range(this.WS_Input.Cells[_i, _j],
                this.WS_Input.Cells[_i, _j]);
            _ret = ((rng == null) || (rng.Value == null) ? "" : rng.Value.ToString());
                      
            return _ret;

        }

        private int ExcelFindretRow(string _Stroka_Seek, int _Def = 0)
        {
            Excel.Range _r = this.WS_Input.Cells.Find(_Stroka_Seek);
            return _r == null ? _Def : _r.Row;
        }

        // процедура форматирования суммы с 2 знаками после запятой.
        // _PadL (Выравнивание по правому краю, из скольки смволов должно сотоять  значение) 
        // PadL= 0 -  или меньше числа сиволов  - выравнивание по левому краю
        // _Sym_Razd = "," - без разделителя 000
        // _Sym_Razd = " ," - пробел разделитель 000
        private string Format_Rub(string _Sum_Rub, string _Sym_Razd = ",", byte _PadL = 0)
        {
            string _Sym_T="",_S_Sym;
            int _k;
            char[] _Arr_Separator = { '.', ',' ,' ',' '};
            this.ParentFormMain.Separator.Substring(this.ParentFormMain.Separator.Length - 1).ToCharArray().CopyTo(_Arr_Separator, 2);
            System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToCharArray().CopyTo(_Arr_Separator, 3);
            
            if (_Sym_Razd.Length > 1)
            {
                _Sym_T    = _Sym_Razd.Substring(0, _Sym_Razd.Length-1);
                _Sym_Razd = _Sym_Razd.Substring(_Sym_Razd.Length-1, 1);
            }

            if (_Sym_Razd.Length == 0) _Sym_Razd = ",";
            
                string _S_Rub, _S_Kop, _S_Sum = "";
            if (!String.IsNullOrEmpty(_Sum_Rub))
            {
                string[] _Sum_Rub_split = _Sum_Rub.Split(_Arr_Separator);

                if (_Sum_Rub_split.Length==1 || String.IsNullOrEmpty(_Sum_Rub_split[1]))
                {
                    _S_Rub = _Sum_Rub;
                    _S_Kop = "00";
                }
                else
                {
                    _S_Rub = _Sum_Rub_split[0].Trim();
                    _S_Kop = _Sum_Rub_split[1].PadLeft(2, '0');
                }


                if (_Sym_T.Length > 0)
                {
                    
                        _S_Sum = _S_Rub; _S_Rub = ""; _k = 0;
                        for (int _i = _S_Sum.Length - 1; _i >= 0; _i--)
                        {

                            _S_Sym = _S_Sum.Substring(_i, 1);
                            if (!"0123456789+-.,".Contains(_S_Sym)) continue; // Случай когда уже есть разделитель

                            if (_k++ == 3)
                            {
                                _S_Rub = _S_Sym + _Sym_T + _S_Rub;
                                _k = 0;

                            }
                            else _S_Rub = _S_Sym + _S_Rub;

                        }

                }
                    _S_Sum = _S_Rub + _Sym_Razd + _S_Kop;

                if (_S_Sum.Length > 0 && _PadL > _S_Sum.Length)
                {
                    _k = 2;
                    for (int _i = _S_Sum.Length - 4; _i > 0; _i--)
                    {
                        if ("0123456789+-".Contains(_S_Sum.Substring(_i, 1))) _k++;
                    }


                    _k = _PadL +_PadL/2 - _S_Sum.Length - _k-1;
                    if (_k <= 0) _k = 0;
                    

                    _S_Sum = new string(' ',_k) + _S_Sum.Trim();
                }
            }
            return _S_Sum;
        }


       


    }
}
