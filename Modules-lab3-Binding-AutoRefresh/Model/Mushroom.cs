using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modules_lab3_Binding_AutoRefresh
{
    public class Mushroom : INotifyPropertyChanged
    {
        private int id;
        public int ID 
        {  
            get
            {
                return id;
            } 
            set
            {
                id = value;
                OnPropertyChanged("ID");
            } 
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private string colour;
        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
                OnPropertyChanged("Colour");
            }
        }
        private bool edibility;
        public bool Edibility
        {
            get
            {
                return edibility;
            }
            set
            {
                edibility = value;
                OnPropertyChanged("Edibility");
            }
        }
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                OnPropertyChanged("Height");
            }
        }
        private double cap_radius;
        public double Cap_Radius
        {
            get
            {
                return cap_radius;
            }
            set
            {
                cap_radius = value;
                OnPropertyChanged("Cap Radius");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return $"{Name} - {Weight} - {Height} - {Cap_Radius}";
        }

        public Mushroom(int id, string name, string colour, bool edibility, double weight, double height, double cap_radius)
        {
            ID = id;
            Name = name;
            Colour = colour;
            Edibility = edibility;
            Weight = weight;
            Height = height;
            Cap_Radius = cap_radius;
        }

        public Mushroom()
        {
        }
    }
}
