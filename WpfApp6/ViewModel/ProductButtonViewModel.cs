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
    internal class ProductButtonViewModel
    {
        private IList<Product> m_ProductsOnButton, DopProductsOnButton;

        public IList<Product> ProductsOnButton
        {
            get { return m_ProductsOnButton; }
            set { m_ProductsOnButton = value; }
        }

        private Product m_ProductForIdAll;

        public Product ProductForIdAll
        {
            get { return m_ProductForIdAll; }
            set { m_ProductForIdAll = value;}
        }

        private string m_ProductForId;

        public string ProductForId
        {
            get { return m_ProductForId; }
            set { m_ProductForId = value; }
        }

        private int m_ProductId;

        public int ProductId
        {
            get { return m_ProductId; }
            set { m_ProductId = value; }
        }




        //Кнопка
        private ICommand _showMessage;
        public ICommand ShowMessage
        {
            get { return _showMessage; }
            set { _showMessage = value; }
        }



        public ProductButtonViewModel()
        {
            Product product = new Product();
            DopProductsOnButton = product.getShittyProducts();
            ShowMessage = new RelayCommand(SetProductNameForId);
        }

        public void SetProductNameForId()
        {
            ProductForIdAll = DopProductsOnButton.Where(p => p.ID == ProductId).FirstOrDefault();
            if (ProductForIdAll != null)
                ProductForId = ProductForIdAll.Name.ToString();
            else
                ProductForId = "No one";
        }
        public void willShowMessage()
        {
            MessageBox.Show("Message!");
        }




    }
}
