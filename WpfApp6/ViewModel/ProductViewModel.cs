using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp6.Model;

namespace WpfApp6.ViewModel
{
    internal class ProductViewModel
    {
        private IList<Product> m_Products;

        public IList<Product> Products
        {
            get
            {
                return m_Products;
            }
            set
            {
                m_Products = value;
            }
        }
        public ProductViewModel()
        {
            Product product2 = new Product();
            m_Products = new List<Product>();
            m_Products = product2.getShittyProducts();
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {
                MessageBox.Show("Ok");
            }
        }
    }
}
