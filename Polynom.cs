using System.Collections.Generic;

namespace Task9_2
{
    class Polynom
    {
        List<int> polynom = new List<int>();
        int extent = 0;

        public Polynom(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                polynom.Add(items[i]);
            }
            extent = items.Length;
        }
        public Polynom(List<int> items)
        {
            polynom = items;
            extent = items.Count;
        }

        public int GetExtentPolynom
        {
            get { return extent; }
        }

        public List<int> GetItems()
        {
            return polynom;
        }

        public int this[int i]
        {
            get
            {
                if (i > polynom.Count - 1)
                {
                    return 0;
                }
                return polynom[i];
            }
            set
            {
                if (i > polynom.Count - 1)
                {
                    polynom[i] = value;
                }
            }
        }

        public static bool operator >(Polynom x, Polynom y)
        {
            if (x.GetExtentPolynom > y.GetExtentPolynom)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Polynom x, Polynom y)
        {
            return !(x > y);
        }

        public static Polynom operator +(Polynom x, Polynom y)
        {
            if (x < y)
            {
                Polynom tmp = new Polynom(x.GetItems());
                x = y;
                y = tmp;
            }
            List<int> ResItems = new List<int>();
            int offset = x.GetExtentPolynom - y.GetExtentPolynom;
            for (int i = 0; i < x.GetExtentPolynom; i++)
            {
                if (i >= offset)
                {
                    ResItems.Add(x[i] + y[i - offset]);
                }
                else
                {
                    ResItems.Add(x[i]);
                }
            }

            Polynom Res = new Polynom(ResItems);
            return Res;
        }

        public override string ToString()
        {
            string res = string.Empty;
            for (int i = 0; i < polynom.Count; i++)
            {
                res += polynom[i] +
                    ((polynom.Count - (i + 1) != 0) ? "x^" + (polynom.Count - (i + 1)).ToString() : "") +
                    (i != (polynom.Count - 1) ? "+" : "");
            }
            return res;
        }
    }
}
