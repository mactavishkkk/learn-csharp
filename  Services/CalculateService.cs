using System;

namespace PrimeiroProjeto.Services
{
    class CalculateService
    {
        public G Max<G>(List<G> list) where G : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            G max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]CompareTo(max) > 0)
                {
                    max = list[i]
                }
            }

            return max;
        }
    }
}