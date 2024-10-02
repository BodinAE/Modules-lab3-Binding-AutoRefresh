using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Modules_lab3_Binding_AutoRefresh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Mushroom> mushrooms { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            mushrooms = new List<Mushroom>()
            {
                new Mushroom(1, "Name", "Colour", true, 24.5, 32.4, 86.3),
                new Mushroom(2, "Name", "Colour", true, 24.5, 32.4, 86.3),
                new Mushroom(3, "Name", "Colour", true, 24.5, 32.4, 86.3)
            };
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
//            mushrooms.Remove(ListViewMushroom.SelectedItem);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TB_ID.Text, out int id);
            string name = TB_Name.Text;
            string colour = TB_Colour.Text;
            bool edibility = Convert.ToBoolean(ChB_Edibility.IsChecked);
            double.TryParse(TB_Weight.Text, out double weight);
            double.TryParse(TB_Height.Text, out double height);
            double.TryParse(TB_Cap_Radius.Text, out double cap_radius);
            mushrooms.Add(new Mushroom(id, name, colour, edibility, weight, height, cap_radius));
            
        }
    }
}
