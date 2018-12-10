using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB16
{
    class Vector
    {
        Random rand = new Random();
        public List<int> vector = new List<int>();
        public Vector(int size)
        {
            for (int i=0; i>size; i++)
            {
                vector.Add(rand.Next(size));
            }
        }

        public int Length { get { return vector.Count; } }

        public int this[int number]
        {
            get { return vector[number]; }
            set { vector[number] = value; }
        }

        public void Print()
        {
            foreach (var n in vector)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;
            for (int i=0; i<vector.Count;i++)
            {
                sum += vector[i];
            }
            return sum;
        }

        public static Vector operator *(Vector vec, int n)
        {
            for (int i=0; i<vec.vector.Count; i++)
            {
                vec.vector[i] *= n;
            }
            return vec;
        }
    }
}
