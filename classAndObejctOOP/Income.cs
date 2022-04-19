using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObejctOOP
{
    class Income
    {
        private int _income = 45000;

        public int income { 
            get { return _income; } 
            set { 
                if(value <= 0)
                {
                    _income = 0;
                }
                else if(value > 45000)
                {
                    _income = 45000;
                }
                else
                {
                    _income = value;
                }
            } }

        //public int income { get { return _income; } set { _income = value; } }
        
        public void debit(int moneySpent)
        {
            _income = _income - moneySpent;
        }
    }
}
