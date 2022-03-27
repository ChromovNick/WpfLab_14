using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLab_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Сахар",
                ProdPrice = 100,
                ProdImage = "Data/sugar.jpg",
                productCategories = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Бананы",
                ProdPrice = 130,
                ProdImage = "Data/banana.jpg",
                productCategories = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Киви",
                ProdPrice = 99,
                ProdImage = "Data/qiwi.jpg",
                productCategories = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Фен",
                ProdPrice = 3750,
                ProdImage = "Data/fan.jpg",
                productCategories = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Тостер",
                ProdPrice = 6500,
                ProdImage = "Data/toaster.jpg",
                productCategories = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 43000,
                ProdImage = "Data/wmachine.jpg",
                productCategories = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }

    }
}
