using System;
using System.Text.RegularExpressions;

namespace DomainPrimitives
{

    public class CPR
    {
        private string cpr;

        public CPR(string cpr)
        {
            IsCprValid(cpr);
            this.cpr = cpr;
        }

        public string GetValue()
        {
            return cpr;
        }

        private void IsCprValid(string cpr)
        {
            if(cpr == null)
            {
                throw new ArgumentException("cpr cannot be null");
            }
            string pattern = @"^(0[1-9]|[12]\d|3[01])(0[1-9]|1[0-2])\d{2}[-]?\d{4}$";
            Regex rg = new Regex(pattern);

            if(!rg.IsMatch(cpr))
            {
                throw new ArgumentException("CPR must be valid");
            } 
        }

    }

}

