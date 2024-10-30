using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modules_lab3_Binding_AutoRefresh
{
    internal class MushroomVM : PropertyChangedClass
    {
        private RelayCommand addComm;
        public RelayCommand AddComm 
        {  
            get
            {
                return addComm ?? (addComm = new RelayCommand(obj => 
                {
                    var mush = new Mushroom(0, "New Mushroom", "Colour", false, 0, 0, 0);
                    mushrooms.Add(mush);
                }));
            } 
        }
        private RelayCommand remComm;
        public RelayCommand RemComm
        {
            get
            {
                return remComm ?? (remComm = new RelayCommand(obj =>
                {
                    var mush = obj as Mushroom;
                    mushrooms.Remove(mush);
                }));
            }
        }

        private Mushroom selectedMushroom;
        public Mushroom SelectedMushroom 
        { 
            get
            {
                return selectedMushroom;
            }
            set
            {
                selectedMushroom = value;
                OnPropertyChanged("SelectedMushroom");
            }
        }

        public MushroomVM()
        {
            mushrooms = new ObservableCollection<Mushroom>()
            {
                new Mushroom(1, "Name1", "Colour1", true, 24.5, 32.4, 86.3),
                new Mushroom(2, "Name2", "Colour2", true, 24.5, 32.4, 86.3),
                new Mushroom(3, "Name3", "Colour3", true, 24.5, 32.4, 86.3)
            };
        }
        public ObservableCollection<Mushroom> mushrooms { get; set; }
    }
}