using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Model
{
    internal class Product : INotifyPropertyChanged
    {
        private int m_ID;
        private string m_Name;
        private double m_Price;
        #region INotifyPropertyChanged Members  
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public IList<Product> getShittyProducts()
        {
            IList<Product> products = new List<Product>
            {
                new Product
                {
                    m_Name = "Flower", m_Price = 123, m_ID = 1
                },
                new Product
                {
                    m_Name = "Gift", m_Price = 228, m_ID = 2
                }
            };
            return products;
                
        }
        #endregion

        public int ID
        {
            get
            {
                return m_ID;
            }
            set
            {
                m_ID = value;
                OnPropertyChanged("ID");
            }
        }
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                OnPropertyChanged("Name");
            }
        }
        public double Price
        {
            get
            {
                return m_Price;
            }
            set
            {
                m_Price = value;
                OnPropertyChanged("Price");
            }
        }
    }
}
