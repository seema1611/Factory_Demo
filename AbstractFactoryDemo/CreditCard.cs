using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
