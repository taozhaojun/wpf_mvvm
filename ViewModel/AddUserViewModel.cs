using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf_csharp.Commands;
using wpf_csharp.Models;

namespace wpf_csharp.ViewModel
{
    class AddUserViewModel
    {
        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }
        public ICommand AddUserCommand { get; set; }
        public string? Name { get; set;}
        public string? Email { get; set; }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User() { Name = Name, Email = Email });
        }
    }

}
