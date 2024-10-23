using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            //this.DataContext = this;

            
        }

        //private void RemoveButton_Click(object sender, RoutedEventArgs e)
        //{
        //    mushrooms.RemoveAt(LV_Mushrooms.SelectedIndex);
        //}

        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //int.TryParse(TB_ID.Text, out int id);
        //    //string name = TB_Name.Text;
        //    //string colour = TB_Colour.Text;
        //    //bool edibility = Convert.ToBoolean(ChB_Edibility.IsChecked);
        //    //double.TryParse(TB_Weight.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out double weight);
        //    //double.TryParse(TB_Height.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out double height);
        //    //double.TryParse(TB_Cap_Radius.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out double cap_radius);
        //    //mushrooms.Add(new Mushroom(id, name, colour, edibility, weight, height, cap_radius));
        //    mushrooms.Add(new Mushroom(ioMush.ID, ioMush.Name, ioMush.Colour, ioMush.Edibility, ioMush.Weight, ioMush.Height, ioMush.Cap_Radius));
        //}

        //private void LV_Mushrooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ListView view = (ListView)sender;
        //    ioMush = view.SelectedItem as Mushroom;
        //    //ioMush.ID = mushrooms[LV_Mushrooms.SelectedIndex].ID;
        //    //ioMush.Name = mushrooms[LV_Mushrooms.SelectedIndex].Name;
        //    //ioMush.Colour = mushrooms[LV_Mushrooms.SelectedIndex].Colour;
        //    //ioMush.Edibility = mushrooms[LV_Mushrooms.SelectedIndex].Edibility;
        //    //ioMush.Weight = mushrooms[LV_Mushrooms.SelectedIndex].Weight;
        //    //ioMush.Height = mushrooms[LV_Mushrooms.SelectedIndex].Height;
        //    //ioMush.Cap_Radius = mushrooms[LV_Mushrooms.SelectedIndex].Cap_Radius;
            
        //}
    }
}
