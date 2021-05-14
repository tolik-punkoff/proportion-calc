using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PropCalc
{
    public static class calc
    {
        public static string ErrorMessage { get; private set; }
        private static double? ToDouble(string Number)
        {
            if (Number == null) return null;
            Number = Number.Trim();
            if (Number == string.Empty) return 0;
            Number = Number.Replace(',', '.');
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";
            return Convert.ToDouble(Number, format);
        }

        private static double CalcProp(double? A, double? B, double? C, double? D)
        {
            ErrorMessage = "";
            double X = 0;

            if (A == null)
            {
                if (D == 0)
                {
                    ErrorMessage = "Divide by zero!";
                    DrawFormula.SetStrings(B.ToString(), C.ToString(), D.ToString(), "0");
                    return 0;
                }
                X = (double)((B * C) / D);
                DrawFormula.SetStrings(B.ToString(), C.ToString(), D.ToString(), X.ToString());
                return X;
            }

            if (B == null)
            {
                if (C == 0)
                {
                    ErrorMessage = "Divide by zero!";
                    DrawFormula.SetStrings(A.ToString(), D.ToString(), C.ToString(), "0");
                    return 0;
                }
                X = (double)((A * D) / C);
                DrawFormula.SetStrings(A.ToString(), D.ToString(), C.ToString(), X.ToString());
                return X;
            }

            if (C == null)
            {
                if (B == 0)
                {
                    ErrorMessage = "Divide by zero!";
                    DrawFormula.SetStrings(A.ToString(), D.ToString(), B.ToString(), "0");
                    return 0;
                }
                X = (double)((A * D) / B);
                DrawFormula.SetStrings(A.ToString(), D.ToString(), B.ToString(), X.ToString());
                return X;
            }

            if (D == null)
            {
                if (A == 0)
                {
                    ErrorMessage = "Divide by zero!";
                    DrawFormula.SetStrings(B.ToString(), C.ToString(), A.ToString(), "0");
                    return 0;
                }
                X = (double)((B * C) / A);
                DrawFormula.SetStrings(B.ToString(), C.ToString(), A.ToString(), X.ToString());
                return X;
            }

            return 0;
        }

        public static string PropCalc(string sA, string sB, string sC, string sD)
        {
            double? A = ToDouble(sA);
            double? B = ToDouble(sB);
            double? C = ToDouble(sC);
            double? D = ToDouble(sD);

            double X = CalcProp(A, B, C, D);
            if ((X == 0) && (ErrorMessage != string.Empty))
            {
                return ErrorMessage;
            }

            string Ans = Convert.ToString(X).Replace(',', '.');

            string[] numbuf = Ans.Split('.');
            if (numbuf.Length > 1)
            {
                if (Convert.ToDouble(numbuf[1]) == 0)
                {
                    return numbuf[0];
                }
            }

            return Ans;
        }

        public static string CalcPayWithCommission(string sPayment, string sComission, bool Okr)
        {
            double? P = ToDouble(sPayment);
            double? C = ToDouble(sComission);

            if (C >= 100)
            {
                return "Комиссия >= 100 процентов, беги оттуда!";
            }

            double Res = (double)(P / (1 - C / 100));

            if (Okr)
            {
                Res = Math.Ceiling(Res);
            }

            return Convert.ToString(Res).Replace(',', '.');
        }
        
    }
}
