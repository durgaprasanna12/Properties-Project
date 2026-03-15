using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Project
{
    public class Customer
    {
        int _CustID;
        bool _Status;
        string _Cname, _State;
        double _Balance;
        Cities _City;
        public Customer(int CustID, bool Status, string Cname, double Balance, Cities City, string State,string Country)
        {
            _CustID = CustID;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
            _State = State;
            this.Country = Country;
        }
        public int CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get
            {
                return _Cname;
            }
            set
            {
                if (_Status == true)
                    _Cname = value;
            }
        }
        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)
                    {
                        _Balance = value;
                    }
                }
            }
        }
        public Cities City
        {
            get
            {
                return _City;
            }
            set
            {
                if (_Status == true)
                {
                    _City = value;
                }
            }

        }
        public string State
        {
            get
            {
                return _State;
            }
             protected set
            {
                if (_Status == true)
                {
                    _State = value;
                }
            }
        }
        public string Country //Auto-implemented or Automatic property 3.0
                              //Auto Property initializer 6.0
        { get; } = "India";

    }
}
        
    

   

