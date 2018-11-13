using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using InclusionMetods;
using System.Windows.Input;

namespace DuplicatesFinderPlus
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string enteredPath = "Enter the path or disc name for searching";
        public string EnteredPath
        {
            get
            { return enteredPath; }
            set
            {
                if (enteredPath != value)
                {
                    enteredPath = value;
                    RaisePropertyChanged("enteredPath");
                }
                ;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public Model GoFindIt { get; set; }
        public DuplicatesViewModel DublObject { get; set; }


        public MainViewModel()
        {
            GoFindIt = new Model();
            DublObject = new DuplicatesViewModel();
        }

        private ICommand onClick;
        public ICommand OnClick
        {
            get
            {
                return onClick ?? (onClick = new RelayCommand((r) =>
                {
                    GoFindIt.PathFromUser = EnteredPath;
                    //DublObject.HaveFoundDublicates = GoFindIt.FindDuplicatesMetod();
                    DublObject.Divide(GoFindIt.FindDuplicatesMetod());
                }
                ));
            }
        }

    }
}
