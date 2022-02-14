using System;

namespace CabInvoiceGenerator
{
    internal class InvoiceGenerator
    {
        private object nORMAL;

        public InvoiceGenerator(object nORMAL)
        {
            this.nORMAL = nORMAL;
        }

        internal double CalculateFare(double v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}