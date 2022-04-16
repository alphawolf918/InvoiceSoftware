using System;

namespace InvoiceSoftware.Lib {
    public class Finances {
        public static double CalcTotal(double amountDue, double discount, double tax) {
            double val = (amountDue - (amountDue * discount));
            val += (val * tax);
            return Math.Round(val, 2);
        }

        public static double CalcTax(double amountDue, double discount, double tax) {
            double val = (amountDue - (amountDue * discount));
            double res = (val * tax);
            return Math.Round(res, 2);
        }

        public static double CalcSavings(double amountDue, double discount, double tax) {
            double totalWithDiscount = Finances.CalcTotal(amountDue, discount, tax);
            double totalWithoutDiscount = Finances.CalcTotal(amountDue, 0.00, tax);
            return Math.Round(totalWithoutDiscount - totalWithDiscount, 2);
        }
    }
}