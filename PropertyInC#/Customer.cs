using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInC_
{
    public class Customer
    {
        int _Custid;
        bool _Status;
        String _Cname,_State;
        Double _Balance;
        Cities _City; //is a enum

        public Customer(int Custid, bool Status, String Cname, Double Balance, Cities city,string State,string Country)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = city;
            _State = State;
            this.Country = Country;
        }
        public int Custid
        {
            get { return _Custid; }
            //set { _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public String Cname
        {
            get { return _Cname; }
            set
            {
                if (_Status == true)
                    _Cname = value;
            }
        }
        public Double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)
                        _Balance = value;
                }
            }
        }
        public Cities City {
            get { return _City; }
            set
            {
                if(_Status == true)
                    _City = value;
            }
        
        }
        public string State
        {
            get { return _State; }
          protected  set
            {
                if (Status == true)
                    _State = value;
            }
        }
    
        public string Country
        {
            get;set; //Auto-Implemented or Automatic Property-property without any fields
        }
    }
}

