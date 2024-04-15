using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkVendingMachineNew
{
    class Drink
    {
        
        private string _name;       
        private decimal _cost;      // The drinks name cost and initial amount
        private int _amount;        

       
        public Drink()
        {
            _name = "";
            _cost = 0m;
            _amount = 0;
        }

     
        public Drink(string name, decimal cost, int amount)
        {
            _name = name;
            _cost = cost;
            _amount = amount;
        }

       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 

        
        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        } 

        
        public int StartAmount
        {
            get { return _amount; }
        }
    }
}