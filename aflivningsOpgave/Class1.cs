using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aflivningsOpgave
{
    class User : INotifyPropertyChanged
    {
        private int id;
        private String name;
        private int age;
        private int score;

        public User(string data)
        {
            string[] textFile = data.Split(';');
            this.id = int.Parse(textFile[0]);
            this.name = textFile[1];
            this.age = int.Parse(textFile[2]);
            this.score = int.Parse(textFile[3]);
        }

        public int Id
        {
            get { return id; }
            set 
            { 
                id = value;
                NotifyPropertyChanged("Id");
            } 
        }
        public string Name
        {
            get { return name; }
            set
            {
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

        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                NotifyPropertyChanged("Score");
            }
        }

        public override string ToString()
        {
            return $"{name},   {id},  {age},   {score}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
