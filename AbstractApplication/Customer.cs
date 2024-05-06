using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplication
{
    public class Customer
    {
        int _Custid;
        bool _Status;
        String _Cname,_City;
        Double _Balance;
        public Customer(int Custid,bool Status, String Cname, Double Balance,string City)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
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
                if(_Status == true)
                _Cname = value; }
        }
        public Double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if(value>=500)
                    _Balance = value;
                }
            }
        }
        public String City
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                {
                    if(value=="Kathmandu"||value=="Pokhara"||value=="Lalitpur"||value=="Illam"||value=="Bhaktapur"||value=="Gulmi")

                    _City = value;
                }
            }
        }
    }
}
