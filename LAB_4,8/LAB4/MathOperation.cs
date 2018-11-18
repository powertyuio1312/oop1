using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    static class MathOperation
    {
        public static int SearchMAX(List list) //поиск макс эл
        {
            int[] temp = new int[list.Count];
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                temp[i] = list.Pop();
            }
            return temp.Max();
        }

        public static int SearchMIN(List list)  //поиск мин эл
        {
            int[] temp = new int[list.Count];
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                temp[i] = list.Pop();
            }
            return temp.Min();
        }

        public static int CountOfEl(List list)   //подсчет количества эл
        {
            return list.Count;
        }

        //Добавьте к классу MathOperation методы расширения для типа string и  вашего типа из задания No1 ( поиск самого лдинного слова, удаление послед элемента из строки)

        public static int SearchTheLongest(this string[] str)
        {
            int max = str[0].Length;
            int k = 0;
            for (int i = 0; i< str.Length; i++)
            {
                if (max <= str[i].Length)
                {
                    max = str[i].Length;
                    k = i;
                }
            }
            return k;
        }

        public static List DelLastWord(this List List)
        {
            List.Pop();
            return List;
        }
    }
}
