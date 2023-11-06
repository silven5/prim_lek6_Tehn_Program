using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim1_lek6.Class
{
    internal class Calculator:ICalculator,ITaxCalculator
    {
        public double A {  get; set; }
        public double B { get; set; }
        public Calculator (double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        public double Add()
        { return A + B; }
        public double Subtrackt()
        {
            return A - B;
        }
        public double Multiple()
        {
            return A * B;
        }
        public double Divide()
        { try
            {
                return A / B;
            }
           catch
            { throw new DivideByZeroException("Divide by Zero"); }
        }
        //Додаємо явну реалізацію
        double ITaxCalculator.Add()
        {
            return A + 0.5 * B;
        }
        double ITaxCalculator.Subtrackt()
        {
            return A - 0.5 * B;
        }
        
    }
}
