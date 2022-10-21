using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAandToS
{
    internal class _1Var
    {
       static void Main(string[] args) 
        {
            string s;
            s = System1FirstMethod();
            Console.WriteLine(s);
            s = System2FirstMethod();
            Console.WriteLine(s);
            s = System3FirstMethod();
            Console.WriteLine(s);
            s = System1SecondMethod();
            Console.WriteLine(s);
            s = System2SecondMethod();
            Console.WriteLine(s);
            s = System3SecondMethod();
            Console.WriteLine(s);
        }
        public static string System1FirstMethod()
        {
            int c1El = 83;
            int c2El = 71;
            int c3El = 50;
            int c4El = 166;
            int c5El = 148;
            int c6El = 63;
            int N;
            N = c1El + c2El + c3El + c4El + c5El + c6El;
            int countRoutes = 1666;
            double alfa;
            double del = N * (N - 1);
            alfa = countRoutes / del;
            double seniorityMax = 11;
            double seniorEx1 = 10 / seniorityMax;
            double seniorEx2 = 5 / seniorityMax;
            double seniorEx3 = 2 / seniorityMax;
            double seniorEx4 = 6 / seniorityMax;
            double seniorEx5 = 8 / seniorityMax;
            double seniorEx6 = 11 / seniorityMax;
            double seniorEx7 = 9 / seniorityMax;
            double seniorEx8 = 4 / seniorityMax;

            double comp1El = (seniorEx1 * 7) +
                (seniorEx2 * 5) + (seniorEx3 * 3) +
                (seniorEx4 * 7) + (seniorEx5 * 8) +
                (seniorEx6 * 4) + (seniorEx7 * 4) + (seniorEx8 * 4);
            double comp2El = (seniorEx1 * 3) +
                (seniorEx2 * 8) + (seniorEx3 * 5) +
                (seniorEx4 * 4) + (seniorEx5 * 9) +
                (seniorEx6 * 5) + (seniorEx7 * 8) + (seniorEx8 * 4);
            double comp3El = (seniorEx1 * 1) +
                (seniorEx2 * 3) + (seniorEx3 * 5) +
                (seniorEx4 * 3) + (seniorEx5 * 8) +
                (seniorEx6 * 6) + (seniorEx7 * 2) + (seniorEx8 * 9);
            double comp4El = (seniorEx1 * 8) +
                (seniorEx2 * 2) + (seniorEx3 * 6) +
                (seniorEx4 * 9) + (seniorEx5 * 8) +
                (seniorEx6 * 1) + (seniorEx7 * 7) + (seniorEx8 * 7);
            double comp5El = (seniorEx1 * 4) +
                (seniorEx2 * 4) + (seniorEx3 * 8) +
                (seniorEx4 * 8) + (seniorEx5 * 2) +
                (seniorEx6 * 3) + (seniorEx7 * 3) + (seniorEx8 * 3);
            double comp6El = (seniorEx1 * 6) +
                (seniorEx2 * 1) + (seniorEx3 * 2) +
                (seniorEx4 * 4) + (seniorEx5 * 9) +
                (seniorEx6 * 7) + (seniorEx7 * 5) + (seniorEx8 * 8);

            double complRoutes = (seniorEx1 * 0.8) +
                (seniorEx2 * 0.6) + (seniorEx3 * 0.5) +
                (seniorEx4 * 0.3) + (seniorEx5 * 0.7) +
                (seniorEx6 * 0.6) + (seniorEx7 * 0.9) + (seniorEx8 * 0.7);
            double gamma = complRoutes;
            double SUM = (comp1El * c1El) + (comp2El * c2El) + (comp3El * c3El) + (comp4El * c4El) + (comp5El * c5El) + (comp6El * c6El);


            double SystemCompl = (1 + (alfa * gamma)) * SUM;
            string s = $"Complicity of 1 system: {SystemCompl}";
           return s;
        }
        public static string System2FirstMethod()
        {
            int c1El = 177;
            int c2El = 127;
            int c3El = 91;
            int c4El = 22;
            int c5El = 97;
            int c6El = 260;
            int N;
            N = c1El + c2El + c3El + c4El + c5El + c6El;
            int countRoutes = 1167;
            double alfa;
            double del = N * (N - 1);
            alfa = countRoutes / del;
            double seniorityMax = 11;
            double seniorEx1 = 10 / seniorityMax;
            double seniorEx2 = 5 / seniorityMax;
            double seniorEx3 = 2 / seniorityMax;
            double seniorEx4 = 6 / seniorityMax;
            double seniorEx5 = 8 / seniorityMax;
            double seniorEx6 = 11 / seniorityMax;
            double seniorEx7 = 9 / seniorityMax;
            double seniorEx8 = 4 / seniorityMax;

            double comp1El = (seniorEx1 * 5) +
                (seniorEx2 * 1) + (seniorEx3 * 3) +
                (seniorEx4 * 3) + (seniorEx5 * 1) +
                (seniorEx6 * 2) + (seniorEx7 * 1) + (seniorEx8 * 5);
            double comp2El = (seniorEx1 * 6) +
                (seniorEx2 * 3) + (seniorEx3 * 7) +
                (seniorEx4 * 4) + (seniorEx5 * 3) +
                (seniorEx6 * 7) + (seniorEx7 *4) + (seniorEx8 * 4);
            double comp3El = (seniorEx1 * 7) +
                (seniorEx2 * 5) + (seniorEx3 * 6) +
                (seniorEx4 * 7) + (seniorEx5 * 6) +
                (seniorEx6 * 3) + (seniorEx7 * 5) + (seniorEx8 * 7);
            double comp4El = (seniorEx1 * 4) +
                (seniorEx2 * 7) + (seniorEx3 * 7) +
                (seniorEx4 * 8) + (seniorEx5 * 9) +
                (seniorEx6 * 8) + (seniorEx7 * 9) + (seniorEx8 * 7);
            double comp5El = (seniorEx1 * 9) +
                (seniorEx2 * 9) + (seniorEx3 * 8) +
                (seniorEx4 * 9) + (seniorEx5 * 9) +
                (seniorEx6 * 9) + (seniorEx7 * 8) + (seniorEx8 * 7);
            double comp6El = (seniorEx1 * 2) +
                (seniorEx2 * 4) + (seniorEx3 * 2) +
                (seniorEx4 * 5) + (seniorEx5 * 4) +
                (seniorEx6 * 1) + (seniorEx7 * 3) + (seniorEx8 * 1);

            double complRoutes = (seniorEx1 * 1.1) +
                (seniorEx2 * 1.2) + (seniorEx3 * 0.9) +
                (seniorEx4 * 1) + (seniorEx5 * 1) +
                (seniorEx6 * 0.9) + (seniorEx7 * 1) + (seniorEx8 * 0.8);
            double gamma = complRoutes;
            double SUM = (comp1El * c1El) + (comp2El * c2El) + (comp3El * c3El) + (comp4El * c4El) + (comp5El * c5El) + (comp6El * c6El);


            double SystemCompl = (1 + (alfa * gamma)) * SUM;
            string s = $"Complicity of 2 system 1 method: {SystemCompl}";
            return s;
        }
        public static string System3FirstMethod()
        {
            int c1El = 185;
            int c2El = 240;
            int c3El = 254;
           
            int N;
            N = c1El + c2El + c3El;
            int countRoutes = 1821;
            double alfa;
            double del = N * (N - 1);
            alfa = countRoutes / del;
            double seniorityMax = 11;
            double seniorEx1 = 10 / seniorityMax;
            double seniorEx2 = 5 / seniorityMax;
            double seniorEx3 = 2 / seniorityMax;
            double seniorEx4 = 6 / seniorityMax;
            double seniorEx5 = 8 / seniorityMax;
            double seniorEx6 = 11 / seniorityMax;
            double seniorEx7 = 9 / seniorityMax;
            double seniorEx8 = 4 / seniorityMax;

            double comp1El = (seniorEx1 * 4) +
                (seniorEx2 * 3) + (seniorEx3 * 1) +
                (seniorEx4 * 8) + (seniorEx5 * 2) +
                (seniorEx6 * 6) + (seniorEx7 * 4) + (seniorEx8 * 1);
            double comp2El = (seniorEx1 * 5) +
                (seniorEx2 * 6) + (seniorEx3 * 8) +
                (seniorEx4 * 1) + (seniorEx5 * 4) +
                (seniorEx6 * 6) + (seniorEx7 * 6) + (seniorEx8 * 5);
            double comp3El = (seniorEx1 * 4) +
                (seniorEx2 * 8) + (seniorEx3 * 9) +
                (seniorEx4 * 9) + (seniorEx5 * 4) +
                (seniorEx6 * 9) + (seniorEx7 * 7) + (seniorEx8 * 2);
            

            double complRoutes = (seniorEx1 * 0.9) +
                (seniorEx2 * 0.4) + (seniorEx3 * 0.5) +
                (seniorEx4 * 0.6) + (seniorEx5 * 0.7) +
                (seniorEx6 * 0.8) + (seniorEx7 * 0.6) + (seniorEx8 * 0.6);
            double gamma = complRoutes;
            double SUM = (comp1El * c1El) + (comp2El * c2El) + (comp3El * c3El);


            double SystemCompl = (1 + (alfa * gamma)) * SUM;
            string s = $"Complicity of 3 system 1 method: {SystemCompl}";
            return s;
        }
        public static string System1SecondMethod()
        {
            int c1El = 83;
            int c2El = 71;
            int c3El = 50;
            int c4El = 166;
            int c5El = 148;
            int c6El = 63;
            int N;
            N = c1El + c2El + c3El + c4El + c5El + c6El;
            int countRoutes = 1666;
            double alfa;
            double del = N * (N - 1);
            alfa = countRoutes / del;
            double seniorEx1 = 10;
            double seniorEx2 = 5;
            double seniorEx3 = 2;
            double seniorEx4 = 6;
            double seniorEx5 = 8;
            double seniorEx6 = 11;
            double seniorEx7 = 9;
            double seniorEx8 = 4;
            double AllYears = 10 + 5 + 2 + 6 + 8 + 11 + 9 + 4;
            double comp1El = (seniorEx1 * 7) +
               (seniorEx2 * 5) + (seniorEx3 * 3) +
               (seniorEx4 * 7) + (seniorEx5 * 8) +
               (seniorEx6 * 4) + (seniorEx7 * 4) + (seniorEx8 * 4);
            double comp2El = (seniorEx1 * 3) +
                (seniorEx2 * 8) + (seniorEx3 * 5) +
                (seniorEx4 * 4) + (seniorEx5 * 9) +
                (seniorEx6 * 5) + (seniorEx7 * 8) + (seniorEx8 * 4);
            double comp3El = (seniorEx1 * 1) +
                (seniorEx2 * 3) + (seniorEx3 * 5) +
                (seniorEx4 * 3) + (seniorEx5 * 8) +
                (seniorEx6 * 6) + (seniorEx7 * 2) + (seniorEx8 * 9);
            double comp4El = (seniorEx1 * 8) +
                (seniorEx2 * 2) + (seniorEx3 * 6) +
                (seniorEx4 * 9) + (seniorEx5 * 8) +
                (seniorEx6 * 1) + (seniorEx7 * 7) + (seniorEx8 * 7);
            double comp5El = (seniorEx1 * 4) +
                (seniorEx2 * 4) + (seniorEx3 * 8) +
                (seniorEx4 * 8) + (seniorEx5 * 2) +
                (seniorEx6 * 3) + (seniorEx7 * 3) + (seniorEx8 * 3);
            double comp6El = (seniorEx1 * 6) +
                (seniorEx2 * 1) + (seniorEx3 * 2) +
                (seniorEx4 * 4) + (seniorEx5 * 9) +
                (seniorEx6 * 7) + (seniorEx7 * 5) + (seniorEx8 * 8);

            double fin1El = comp1El / AllYears;
            double fin2El = comp2El / AllYears;
            double fin3El = comp3El / AllYears;
            double fin4El = comp4El / AllYears;
            double fin5El = comp5El / AllYears;
            double fin6El = comp6El / AllYears;
            double complRoutes = ((10 * 0.8) +
                (5 * 0.6) + (2 * 0.5) +
                (6 * 0.3) + (8 * 0.7) +
                (11 * 0.6) + (9 * 0.9) + (4 * 0.7)) / AllYears;
            double gamma = complRoutes;
            double SUM = (fin1El * c1El) + (fin2El * c2El) + (fin3El * c3El) + (fin4El * c4El) + (fin5El * c5El) + (fin6El * c6El);


            double SystemCompl = (1 + (alfa * gamma)) * SUM;
            string s = $"Complicity of 1 system 2 method: {SystemCompl}";
            return s;
        }
        public static string System2SecondMethod()
        {
            int c1El = 177;
            int c2El = 127;
            int c3El = 91;
            int c4El = 22;
            int c5El = 97;
            int c6El = 260;
            int N;
            N = c1El + c2El + c3El + c4El + c5El + c6El;
            int countRoutes = 1167;
            double alfa;
            double del = N * (N - 1);
            alfa = countRoutes / del;
            double seniorEx1 = 10;
            double seniorEx2 = 5;
            double seniorEx3 = 2;
            double seniorEx4 = 6;
            double seniorEx5 = 8;
            double seniorEx6 = 11;
            double seniorEx7 = 9;
            double seniorEx8 = 4;
            double AllYears = 10 + 5 + 2 + 6 + 8 + 11 + 9 + 4;
            double comp1El = (seniorEx1 * 5) +
                (seniorEx2 * 1) + (seniorEx3 * 3) +
                (seniorEx4 * 3) + (seniorEx5 * 1) +
                (seniorEx6 * 2) + (seniorEx7 * 1) + (seniorEx8 * 5);
            double comp2El = (seniorEx1 * 6) +
                (seniorEx2 * 3) + (seniorEx3 * 7) +
                (seniorEx4 * 4) + (seniorEx5 * 3) +
                (seniorEx6 * 7) + (seniorEx7 * 4) + (seniorEx8 * 4);
            double comp3El = (seniorEx1 * 7) +
                (seniorEx2 * 5) + (seniorEx3 * 6) +
                (seniorEx4 * 7) + (seniorEx5 * 6) +
                (seniorEx6 * 3) + (seniorEx7 * 5) + (seniorEx8 * 7);
            double comp4El = (seniorEx1 * 4) +
                (seniorEx2 * 7) + (seniorEx3 * 7) +
                (seniorEx4 * 8) + (seniorEx5 * 9) +
                (seniorEx6 * 8) + (seniorEx7 * 9) + (seniorEx8 * 7);
            double comp5El = (seniorEx1 * 9) +
                (seniorEx2 * 9) + (seniorEx3 * 8) +
                (seniorEx4 * 9) + (seniorEx5 * 9) +
                (seniorEx6 * 9) + (seniorEx7 * 8) + (seniorEx8 * 7);
            double comp6El = (seniorEx1 * 2) +
                (seniorEx2 * 4) + (seniorEx3 * 2) +
                (seniorEx4 * 5) + (seniorEx5 * 4) +
                (seniorEx6 * 1) + (seniorEx7 * 3) + (seniorEx8 * 1);


            double fin1El = comp1El / AllYears;
            double fin2El = comp2El / AllYears;
            double fin3El = comp3El / AllYears;
            double fin4El = comp4El / AllYears;
            double fin5El = comp5El / AllYears;
            double fin6El = comp6El / AllYears;
            double complRoutes = ((seniorEx1 * 1.1) +
                (seniorEx2 * 1.2) + (seniorEx3 * 0.9) +
                (seniorEx4 * 1) + (seniorEx5 * 1) +
                (seniorEx6 * 0.9) + (seniorEx7 * 1) + (seniorEx8 * 0.8)) / AllYears;
            double gamma = complRoutes;
            double SUM = (fin1El * c1El) + (fin2El * c2El) + (fin3El * c3El) + (fin4El * c4El) + (fin5El * c5El) + (fin6El * c6El);


            double SystemCompl = (1 + (alfa * gamma)) * SUM;
            string s = $"Complicity of 2 system 2 method: {SystemCompl}";
            return s;
        }
        public static string System3SecondMethod()
        {
            int c1El = 185;
            int c2El = 240;
            int c3El = 254;

            int N;
            N = c1El + c2El + c3El;
            int countRoutes = 1821;
            double alfa;
            double del = N * (N - 1);
            alfa = countRoutes / del;
            double seniorEx1 = 10;
            double seniorEx2 = 5;
            double seniorEx3 = 2;
            double seniorEx4 = 6;
            double seniorEx5 = 8;
            double seniorEx6 = 11;
            double seniorEx7 = 9;
            double seniorEx8 = 4;

            double AllYears = 10 + 5 + 2 + 6 + 8 + 11 + 9 + 4;

            double comp1El = (seniorEx1 * 4) +
                (seniorEx2 * 3) + (seniorEx3 * 1) +
                (seniorEx4 * 8) + (seniorEx5 * 2) +
                (seniorEx6 * 6) + (seniorEx7 * 4) + (seniorEx8 * 1);
            double comp2El = (seniorEx1 * 5) +
                (seniorEx2 * 6) + (seniorEx3 * 8) +
                (seniorEx4 * 1) + (seniorEx5 * 4) +
                (seniorEx6 * 6) + (seniorEx7 * 6) + (seniorEx8 * 5);
            double comp3El = (seniorEx1 * 4) +
                (seniorEx2 * 8) + (seniorEx3 * 9) +
                (seniorEx4 * 9) + (seniorEx5 * 4) +
                (seniorEx6 * 9) + (seniorEx7 * 7) + (seniorEx8 * 2);

            double fin1El = comp1El / AllYears;
            double fin2El = comp2El / AllYears;
            double fin3El = comp3El / AllYears;

            double complRoutes = ((seniorEx1 * 0.9) +
                (seniorEx2 * 0.4) + (seniorEx3 * 0.5) +
                (seniorEx4 * 0.6) + (seniorEx5 * 0.7) +
                (seniorEx6 * 0.8) + (seniorEx7 * 0.6) + (seniorEx8 * 0.6)) / AllYears;
            double gamma = complRoutes;
            double SUM = (fin1El * c1El) + (fin2El * c2El) + (fin3El * c3El);


            double SystemCompl = (1 + (alfa * gamma)) * SUM;
            string s = $"Complicity of 3 system 2 method: {SystemCompl}";
            return s;
        }
    }
}
