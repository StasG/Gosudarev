using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab_2
{
    
    class VM : INotifyPropertyChanged
    {
        public ObservableCollection<String> Model { get; set; }
        private String _SModel;
        public String SModel
        {
            get { return _SModel; }
            set
            {
                _SModel = value;
                FirstSel(Model, _SModel);
                DoPropertyChanged(nameof(SModel));
            }
        }
        public ObservableCollection<String> Volume { get; set; }
        private String _SVolume;
        public String SVolume
        {
            get { return _SVolume; }
            set
            {
                _SVolume = value;
                DoPropertyChanged(nameof(SVolume));
            }
        }
        public ObservableCollection<String> Box { get; set; }
        private String _SBox;
        public String SBox
        {
            get { return _SBox; }
            set
            {
                _SBox = value;
                DoPropertyChanged(nameof(SBox));
            }
        }
        public ObservableCollection<String> Tran { get; set; }
        private String _STran;
        public String STran
        {
            get { return _STran; }
            set
            {
                _STran = value;
                DoPropertyChanged(nameof(STran));
            }
        }
        public Dictionary<String, Color> Col { get; set; }
        private KeyValuePair<String, Color> _SCol;
        public KeyValuePair<String, Color> SCol
        {
            get { return _SCol; }
            set
            {
                _SCol = value;
                DoPropertyChanged(nameof(SCol));
                switch (value.Key)
                {
                    case "Зелёный":
                        {
                            CarCol = Brushes.Green;
                        }
                        break;
                    case "Красный":
                        {
                            CarCol = Brushes.Red;
                        }
                        break;
                    case "Синий":
                        {
                            CarCol = Brushes.Blue;
                        }
                        break;
                    case "Серый":
                        {
                            CarCol = Brushes.Gray;
                        }
                        break;
                    default:
                        {
                            CarCol = Brushes.Orange;
                        }
                        break;
                }
            }
        }
        public ObservableCollection<String> Park { get; set; }
        private String _SPark;
        public String SPark
        {
            get { return _SPark; }
            set
            {
                _SPark = value;
                DoPropertyChanged(nameof(SPark));
            }
        }
        private Brush _col;
        public Brush CarCol
        {
            get { return _col; }
            set {
                _col = value;
                DoPropertyChanged(nameof(CarCol));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(String Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }
        private bool _CliCon;
        public bool CliCon
        {
            get { return _CliCon; }
            set
            {
                _CliCon = value;
                DoPropertyChanged(nameof(CliCon));
            }
        }
        private bool _Heat;
        public bool Heat
        {
            get { return _Heat; }
            set
            {
                _Heat = value;
                DoPropertyChanged(nameof(Heat));
            }
        }
        private bool _Rain;
        public bool Rain
        {
            get { return _Rain; }
            set
            {
                _Rain = value;
                DoPropertyChanged(nameof(Rain));
            }
        }
        private bool _EPark;
        public bool EPark
        {
            get { return _EPark; }
            set
            {
                _EPark = value;
                DoPropertyChanged(nameof(EPark));
            }
        }
        private bool _EnableCliCon;
        public bool EnableCliCon
        {
            get { return _EnableCliCon; }
            set
            {
                _EnableCliCon = value;
                DoPropertyChanged(nameof(EnableCliCon));
            }
        }
        private bool _EnableHeat;
        public bool EnableHeat
        {
            get { return _EnableHeat; }
            set
            {
                _EnableHeat = value;
                DoPropertyChanged(nameof(EnableHeat));
            }
        }
        private bool _EnableRain;
        public bool EnableRain
        {
            get { return _EnableRain; }
            set
            {
                _EnableRain = value;
                DoPropertyChanged(nameof(EnableRain));
            }
        }
        private bool _EnablePark;
        public bool EnablePark
        {
            get { return _EnablePark; }
            set
            {
                _EnablePark = value;
                DoPropertyChanged(nameof(EnablePark));
            }
        }

        public int Total;
        public void FirstSel(ObservableCollection<String> Mod, string SMod)
        {
            switch (SMod)
            {
                case "Taus Mk.1":
                    Volume.Clear();
                    Volume.Add("17,5 мл");
                    Volume.Add("50 л");
                    Volume.Add("200,1 л");
                    Box.Clear();
                    Box.Add("Автомат");
                    Box.Add("Механика");
                    Box.Add("Дистанционное управление");
                    Tran.Clear();
                    Tran.Add("Задний");
                    Tran.Add("Передний");
                    Tran.Add("4х4");
                    Park.Clear();
                    Park.Add("Спереди");
                    Park.Add("Сзади");
                    Park.Add("По всему кузову");
                    EnableCliCon = true;
                    EnableHeat = true;
                    EnableRain = true;
                    EnablePark = true;
                    Total = 350;
                    break;
                case "Taus Mk.2":
                    Volume.Clear();
                    Volume.Add("17,5 мл");
                    Volume.Add("50 л");
                    Volume.Add("200,1 л");
                    Box.Clear();
                    Box.Add("Автомат");
                    Box.Add("Механика");
                    Box.Add("Дистанционное управление");
                    Tran.Clear();
                    Tran.Add("Задний");
                    Tran.Add("Передний");
                    Tran.Add("4х4");
                    Park.Clear();
                    Park.Add("Спереди");
                    Park.Add("Сзади");
                    Park.Add("По всему кузову");
                    EnableCliCon = true;
                    EnableHeat = true;
                    EnableRain = true;
                    EnablePark = true;
                    Total = 600;
                    break;
                case "Copper":
                    Volume.Clear();
                    Volume.Add("17,5 мл");
                    Volume.Add("50 л");
                    Volume.Add("200,1 л");
                    Box.Clear();
                    Box.Add("Механика");
                    Box.Add("Дистанционное управление");
                    Tran.Clear();
                    Tran.Add("Задний");
                    Tran.Add("Передний");
                    Park.Clear();
                    Park.Add("Спереди");
                    Park.Add("Сзади");
                    EnableCliCon = true;
                    EnableHeat = true;
                    EnableRain = true;
                    EnablePark = true;
                    Total = 10;
                    break;
                case "Дон":
                    Volume.Clear();
                    Volume.Add("50 л");
                    Box.Clear();
                    Box.Add("Механика");
                    Tran.Clear();
                    Tran.Add("Задний");
                    Tran.Add("Передний");
                    Park.Clear();
                    Park.Add("Спереди");
                    EnableCliCon = true;
                    EnableHeat = true;
                    EnableRain = true;
                    EnablePark = true;
                    Total = 465;
                    break;
                case "Клязьма":
                    Volume.Clear();
                    Volume.Add("17,5 мл");
                    Box.Clear();
                    Box.Add("Механика");
                    Box.Add("Дистанционное управление");
                    Tran.Clear();
                    Tran.Add("Задний");
                    Tran.Add("4х4");
                    Park.Clear();
                    Park.Add("Спереди");
                    Park.Add("Сзади");
                    Park.Add("По всему кузову");
                    EnableCliCon = true;
                    EnableHeat = true;
                    EnableRain = true;
                    EnablePark = true;
                    Total = 210;
                    break;
                case "ОБЧР":
                    Volume.Clear();
                    Volume.Add("Смерть человекам!");
                    Box.Clear();
                    Box.Add("Смерть человекам!");
                    Tran.Clear();
                    Tran.Add("Смерть человекам!");
                    Park.Clear();
                    Park.Add("Смерть человекам!");
                    EnableCliCon = false;
                    EnableHeat = false;
                    EnableRain = false;
                    EnablePark = false;
                    CliCon = false;
                    Heat = false;
                    Rain = false;
                    EPark = false;
                    Total = 20000;
                    break;
                default:
                    EnableCliCon = false;
                    EnableHeat = false;
                    EnableRain = false;
                    EnablePark = false;
                    Volume.Clear();
                    Volume.Add("Тут ошибка");
                    Box.Clear();
                    Box.Add("Тут ошибка");
                    Tran.Clear();
                    Tran.Add("Тут ошибка");
                    Park.Clear();
                    Park.Add("Тут ошибка");
                    break;
            }
        }
        private bool _CanExecute;
        public ICommand Cancel { get; set; }
        public void Strt()
        {
            Model = new ObservableCollection<string>() { "Taus Mk.1", "Taus Mk.2", "Copper", "ОБЧР", "Дон", "Клязьма" };
            Volume = new ObservableCollection<string>() { "17,5 мл", "50 л", "200,1 л" };
            Box = new ObservableCollection<string>() { "Автомат", "Механика", "Дистанционное управление" };
            Tran = new ObservableCollection<string>() { "Задний", "Передний", "4х4" };
            Col = new Dictionary<string, Color>();
            Col.Add("Зелёный", Color.FromRgb(00,99,00));
            Col.Add("Красный", Color.FromRgb(99, 00, 00));
            Col.Add("Синий", Color.FromRgb(00, 00, 99));
            Col.Add("Серый", Color.FromRgb(50, 50, 50));
            Park = new ObservableCollection<string>() { "Спереди", "Сзади", "По всему кузову" };
            CliCon = false;
            Heat = false;
            Rain = false;
            EPark = false;
            EnableCliCon = true;
            EnableHeat = true;
            EnableRain = true;
            EnablePark = true;
        }
        public static void PushLine(string dModel, string dVolume, string dBox, string dTran, string dCol, bool dCliCon, bool dHeat, bool dRain, bool dEPark, string dPark, int dTotal)
        {
            using (SqlConnection cn = new SqlConnection("Server = OWNER-HOME\\SQLEXPRESS; Database = dub; Trusted_Connection = True;"))
            {
                cn.Open();
                string sql = string.Format("USE dub INSERT INTO dbo.Table1Dub VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}', '{9}', '{10}')", dModel, dVolume, dBox, dTran,  dCol, dCliCon, dHeat, dRain, dEPark, dPark, dTotal);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        private ICommand _Count;
        public ICommand Count
        {
            get
            {
                string Color = SCol.Key;
                return _Count ?? (_Count = new CommandHandler(() => PushLine(SModel, SVolume, SBox, STran, Color, CliCon, Heat, Rain, EPark, SPark, Total), _CanExecute));
            }
        }
        public class CommandHandler : ICommand
        {
            private Action _action;
            private bool _canExecute;
            public CommandHandler(Action action, bool canExecute)
            {
                _action = action;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return _canExecute;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                _action();
            }
        }
            public VM()
        {
            Total = 0;
            Strt();
            _CanExecute = true;

        }
    }
}
