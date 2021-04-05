using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpf_mvvm_intro.Commands;
using wpf_mvvm_intro.Models;

namespace wpf_mvvm_intro.ViewModels
{
    class CustomerViewModel
    {
        public CustomerViewModel()
        {
            customer = new Customer("Daniel");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        private Customer customer;

        public Customer Customer
        {
            get
            {
                return customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        public bool CanUpdate { 
            get { 
                if (Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        public void SaveChanges()
        {
            MessageBox.Show(String.Format("Customer name is updated to {0}.\nDatebase connection was to be implemented.", Customer.Name), "To be implemented");
            // Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
        }
    }
}
