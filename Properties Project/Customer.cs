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
            string _Cname;
            double _Balance;
            public Customer(int CustID, bool Status, string Cname, double Balance)
            {
                _CustID = CustID;
                _Status = Status;
                _Cname = Cname;
                _Balance = Balance;
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
        }
    }

    internal class Customer
    {
        static void Main(string[] args)
        {
        }
    }

