using System;
using System.Text;

namespace Yeniden
{
    class Program
    {
        static void Main(string[] args)
        {
            #region yeniden1
            //int count = 0;
            //int[] array = { 1, 2, 3, 4, 7, 90, 56 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 10)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region yeniden2
            //int count = 0;
            //for (int i = 0; i < 45; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region yeniden3
            //double num = 40;
            //double test = square_root(num);
            //Console.WriteLine(test);
            #endregion
            #region yeniden4
            //int[] arrays = { 12, 45, 67, 23, 100 };
            //Console.Write("Max element-");
            //Console.WriteLine(Maxelement(arrays));
            //Console.Write("Min element-");
            //Console.WriteLine(Minelement(arrays));
            #endregion
            #region yeniden5
            //int num = 7;
            //Console.WriteLine(Binary(num));
            #endregion
            #region yeniden6
            //string array = "salam bash";
            //char axtarilan = 'a';
            //int indexx = 3;
            //int miktar = 7;
            //Indexoff(array, axtarilan, indexx);
            #endregion
            #region yeniden7
            //string sentence = "Salam dunya";

            //Console.WriteLine(ReverseText(sentence));
            #endregion
            #region yeniden8
            //int[] arrays = { 4, 5, 6, 7 };
            //int c = 18;
            //arrays = AddNum(ref arrays, ref c);
            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    Console.WriteLine(arrays[i]);
            //}
            #endregion
            

        }
        #region yeniden5
        //static int Binary(int a)
        //{
        //    int b = a;
        //    int count = 0;
        //    while (b != 0)
        //    {
        //        if (a % 2 == 1)
        //        {
        //            count++;
        //            b = b / 2;
        //        }
        //        else
        //        {
        //            b = b / 2;
        //        }

        //    }

        //    return count;
        #endregion
        #region yeniden3

        //public static double square_root(double myNumber)
        //{
        //    double precision = 0.00001;
        //    double low = 0;
        //    double high = myNumber;
        //    double mid = 0;
        //    while ((high - low) > precision)
        //    {
        //        mid = (double)((low + high) / 2);
        //        if ((mid - precision) >= mid * mid && mid * mid <= (precision + mid))
        //        {
        //            break;
        //        }
        //        else if (mid * mid < myNumber)
        //        {
        //            low = mid;
        //        }
        //        else
        //        {
        //            high = mid;
        //        }
        //    }
        //    return mid;
        //}
        #endregion
        #region yeniden4
        //static int Maxelement(int[] array)
        //{
        //    int max = array[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (max < array[i])
        //        {
        //            max = array[i];
        //        }

        //    }
        //    return max;
        //}
        //static int Minelement(int[] massiv)
        //{
        //    int min = massiv[0];
        //    for (int i = 0; i < massiv.Length; i++)
        //    {
        //        if (min > massiv[i])
        //        {
        //            min = massiv[i];
        //        }
        //    }
        //    return min;
        //}
        #endregion
        #region yeniden6
        //static void Indexoff(string str1, char a)
        //{
        //    bool Isex = false;
        //    int i = 0;

        //    for (i = 0; i < str1.Length; i++)
        //    {
        //        if (a == str1[i])
        //        {
        //            Isex = true;
        //            break;
        //        }

        //    }
        //    if (Isex != false)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    else
        //    {
        //        Console.WriteLine(-1);
        //    }
        //}
        //static void Indexoff(string str1, char a, int index)
        //{
        //    int i;
        //    bool Isex = false;
        //    for (i = index; i < str1.Length; i++)
        //    {
        //        if (a == str1[i])
        //        {
        //            Isex = true;
        //            break;
        //        }
        //    }
        //    if (Isex != false)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    else
        //        Console.WriteLine(-1);
        //}
        //static void Indexoff(string str1, char a, int index, int count)
        //{
        //    int i;
        //    bool Isex = false;
        //    for (i = index; i < str1[count]; i++)
        //    {
        //        if (a == str1[i])
        //        {
        //            Isex = true;
        //            break;
        //        }
        //    }
        //    if (Isex != false)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    else
        //        Console.WriteLine(-1);
        //}
        #endregion
        #region yeniden7
        //static stringbuilder reversetext(string text)
        //{
        //    int index = 0;
        //    stringbuilder newtext = new stringbuilder();
        //    for (int i = 0; i < text.length; i++)
        //    {
        //        if (text[i] == ' ' || i == text.length - 1)
        //        {
        //            if (i == text.length - 1)
        //            {
        //                i += 1;
        //            }
        //            reverseandmerge(newtext, text, i - 1, index);
        //            addspace(newtext, text, i);
        //            index = i + 1;
        //        }
        //    }
        //    return newtext;
        //}

        //static void reverseandmerge(stringbuilder result, string text, int endındex, int initındex)
        //{
        //    for (int j = endındex; j >= initındex; j--)
        //    {
        //        result.append(text[j]);
        //    }
        //}

        //static void addspace(stringbuilder result, string text, int index)
        //{
        //    if (index != text.length)
        //        result.append(' ');
        //}
        #endregion
        #region yeniden8
        //static int[] AddNum(ref int[] array,ref int a)
        //{
        //    int[] array1 = new int[array.Length];
        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        array1[i] = array[i];
        //    }
        //    array1[array1.Length - 1]=a;
        //    return array1;
        //}
        #endregion
       

    }
}

