﻿using System.Security.Claims;

namespace SQA_Assign
{

    // an interface defines a reference type that has no implementation.
    // users of the interface need know nothing about its implemenation
    // program will run with any implemenation
    public interface IDiscountService
    {
        int GetDiscount();
    }

    public class InsuranceService
    {
        private readonly IDiscountService _discountService;

        public InsuranceService(IDiscountService discountService)
        {
            _discountService = discountService;
        }





        public double CalcPremium(int age, string location)
        {
            double premium;

            if (location == "rural")
            {
                if ((age >= 18) && (age < 30))
                {
                    premium = 5.0;
                }
                else if (age >= 31)
                {
                    premium = 2.50;
                }
                else
                {
                    premium = 0.0;
                }
            }
            else if (location == "urban")
            {
                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0;
                }
                else if (age >= 36)
                {
                    premium = 5.0;
                }
                else
                {
                    premium = 0.0;
                }
            }
            else
            {
                premium = 0.0;
            }
           
            double discount = _discountService.GetDiscount();
            if (age >= 50)
            {
                premium = premium * discount;
            }
            return premium;
        }
    }
}
