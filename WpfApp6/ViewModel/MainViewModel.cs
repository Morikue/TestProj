using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp6.Model;


namespace WpfApp6.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string helloString;

        public event PropertyChangedEventHandler PropertyChanged;

        public string HelloString
        {
            get { return helloString; }
            set { helloString = value;
                OnPropertyChanged();
            }
        }

        private string helloStringOutput;
        public string HelloStringOutput
        {
            get { return helloStringOutput; }
            set
            {
                helloStringOutput = value;
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainViewModel()
        {
            PushButton = new RelayCommand(GetName);
        }
        //Кнопка
        private ICommand m_pushButton;

        public ICommand PushButton
        {
            get { return m_pushButton; }
            set { m_pushButton = value; }
        }

        private void GetName()
        {
            helloStringOutput = helloString;
            MessageBox.Show(helloString);
        }



    }
}
