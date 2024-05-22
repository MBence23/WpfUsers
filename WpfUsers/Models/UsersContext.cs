using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfUsers.Models 
{
    public class Users:INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string name;
        public  string Name
        {
            get { return name; }
            set 
            { 
                name = value; 
                OnPropertyChanged();
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public User()
        {
            Id =0;
        }
     
        public User(string name, string email)
        {
            Id = 0;
            Name = name;
            Email = email;
        }

        public override string? ToString()
        {
            return $"{Name} ({Email})";
        }


    }
}
