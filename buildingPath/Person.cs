using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingPath
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private int weight;
        private int score;
        private bool accepted;

        public Person(string name, int age, int weight, int score, bool accepted)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.score = score;
            this.accepted = false;
        }
        public string Name {
            get { return name; }
            set {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                NotifyPropertyChanged("Age");
            }
        }
    
        public int Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                NotifyPropertyChanged("Weight");
            }
        }

        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                NotifyPropertyChanged("Score");
            }
        }
        public bool Accepted
        {
            get { return accepted; }
            set
            {
                accepted = value;
                NotifyPropertyChanged("Accepted");
            }
        } 

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName) { 
            if (PropertyChanged != null) 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        }

        public override string ToString()
        {
            return String.Format("{0,-10} : {1,4} points, {2,4} years, {3,4} kg, {4,4} Accepted", Name, Score, Age, Weight, Accepted ? "" : "NOT");
        }
    }
}
