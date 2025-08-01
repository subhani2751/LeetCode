﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Web.Services;
using System.Reflection;
using Spring.Context;
using Spring.Context.Support;
using Spring.Expressions;

namespace LeetCode
{
    //Download Spring.core from Nuget
    public class Factory
    {
        private static IApplicationContext _context;
        internal static IApplicationContext context
        {
            get 
            {
                if (_context == null)
                {
                    lock (ContextRegistry.SyncRoot)
                    {
                        _context = ContextRegistry.GetContext();
                    }
                }
                return _context;
            }
        }
        public static T GetObject<T>(string Name, params object[] Contrains)
        {
            try
            {
                object[] obj = null;
                if (Contrains.Length > 0)
                {
                    obj=new object[Contrains.Length];
                }
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i] = Contrains[i];
                }
                return (T)context.GetObject(Name, obj);

            }
            catch (Exception Ex)
            {
                return default(T);
            }
        }
    }
    internal class Program
    {
        private ListNode head;
        private static IApplicationContext Context; 
        static void Main(string[] args)
        {
            C2 c=new C2();
            c.One(1);
            //Context.GetObject("hola");
            //Activator.CreateInstance(Type.GetType("Program"), args);

            #region
            ////3174. Clear Digits
            //Console.WriteLine("Enter a string with numbers");
            //string s = Console.ReadLine();
            //int j = 0;
            //int count = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    j = 0;
            //    count = 1;
            //    if (s[i]=='0'|| s[i] == '1'|| s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9') //if (int.TryParse(s[i].ToString(), out j)) 
            //    {
            //        j = i;
            //        if (j > 0)
            //        {
            //            j = i - 1;
            //            count = 2;
            //        }
            //        s=s.Remove(j, count);
            //        i =i-count;
            //    }
            //}

            /* 1. Two Sum */
            //int target = 9;
            //int[] nums = new int[] { 2, 7, 11, 15 };
            //for (int firstnum = 0 ; firstnum < nums.Count(); firstnum++)
            //{
            //    for (int second = 1 ; second < nums.Count(); second++)
            //    {
            //        if (target == nums[firstnum] + nums[second])
            //        {
            //             nums = new int[]{ firstnum,second};
            //            break;
            //        }
            //    }

            //}
            /*9. number Palindrome Number*/
            //Console.WriteLine("Enter a  numbers");
            //int x = int.Parse(Console.ReadLine());
            //int reverse = 0;
            //    int num = x;
            //    while (x != 0 && x > 0)
            //    {
            //        reverse = (reverse * 10) + x % 10;
            //        x /= 10;
            //    }
            //string msg= reverse == num ? "is palindrom" : "is not palindrom";
            //Console.WriteLine(msg);


            //Console.WriteLine("Enter a  numbers");
            //int x = int.Parse(Console.ReadLine());
            //Program program = new Program();
            //int a = program.Reverse(x);
            //Console.WriteLine(a);

            //Console.WriteLine("Enter a  numbers");"21474836460" 2147483646
            ////string x = Console.ReadLine();
            //Program program = new Program();
            //int a = program.MyAtoi(" 1192820738r2");//2147483648 //91283472332
            //Console.WriteLine(a);


            //{ 'I',1},{ 'V',5},{ 'X',10},{ 'L',50},{ 'C',100},{ 'D',500},{ 'M',1000},{ 'IV',4},{ 'IX',9},{ 'XL',40},{ 'XC',90},{ 'CD',400},{ 'CM',900}
            //Program program = new Program();
            //int a = program.RomanToInt("MCMXCIV");//2147483648 //91283472332
            //Console.WriteLine(a);

            //Program program = new Program();
            //string a = program.IntToRoman(3749);//2147483648 //91283472332
            //Console.WriteLine(a);

            //Program program = new Program();
            //string[] strings = new string[] { "flower", "flow", "flight" };
            //string a = program.LongestCommonPrefix(strings);//2147483648 //91283472332
            //Console.WriteLine(a);

            //Program program = new Program();
            //int[] lst = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 125}; //9223372036854775807L
            //Array.Sort(lst);
            //for (int i = 0; i < lst.Length; i++)
            //{
            //    program.AddAtBeginning(lst[i]);
            //}
            //var t1 =program.sumofnode(program.head);
            //Program program1 = new Program();
            //int[] lst1 = new int[] {  4,6,5 };
            //for (int i = 0; i < lst1.Length; i++)
            //{
            //    program1.AddAtBeginning(lst1[i]);
            //}
            //var t2 = program.sumofnode(program1.head);
            //BigInteger total =  t1 + t2;
            //var retun = program.CreateListNode(total.ToString());
            //program.AddAtEnd(10);
            //program.AddAtPosition(3,20);

            //Program program= new Program();
            //program.IsValid("()");

            //Program program = new Program();
            //int[] lst = new int[] { 3, 2, 2, 3 };
            //int a = program.RemoveElement(lst, 3);

            //Program program = new Program();
            //int[] lst = new int[] { 1, 1, 2 };
            //int a = program.RemoveDuplicates(lst);

            //Program program = new Program();
            //int[] lst = new int[] { 1, 2, 3, 4, 5 };
            //int[] lst1 = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //var  a = program.FindMedianSortedArrays(lst, lst1);


            //Program program = new Program();
            //int[] lst = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1,0 };
            //var  a = program.PlusOne(lst);

            //Program program = new Program();
            //var a = program.IsAnagram("car","rat");

            //Program program = new Program();
            //var a = program.CountPrimes(499979);

            //Program program = new Program();
            //int[] a1 = new int[] { 3, 3, 3 };
            //var a = program.SearchRange(a1,3);

            //Program program = new Program();
            //int[] a1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //var a = program.MaxArea(a1);

            //Program program = new Program();
            //var a = program.LetterCombinations("23");

            //Program program = new Program();
            //var a = program.LengthOfLongestSubstring("pwwkew");

            //foreach (var num in GetEvenNumbers(0))
            //{
            //    Console.WriteLine(num); // Step into this line
            //}
            #endregion

            //ListNode head1 =new ListNode();
            //ListNode head2 = new ListNode(); ;

            //Program program = new Program();
            //int[] a1 = new int[] {4,2,1 };
            //int[] a2 = new int[] {1 };

            //head1= program.AddListnode(a1);
            //head2 = program.AddListnode(a2);
            //var a= program.MergeTwoLists(head1, head2);

            //1,2,3,4,5
            ListNode1 head1 = new ListNode1(1);
            head1.Next = new ListNode1(2);
            //head1.Next.Next = new ListNode1(3);
            //head1.Next.Next.Next = new ListNode1(4);
            //head1.Next.Next.Next.Next = new ListNode1(5);
            //Program program = new Program();
            //var a=program.RemoveNthFromEnd(head1,1);

            Program program = new Program();
            string s = "my name is mabu-subhani shaik";
            char[] chars = s.ToCharArray();
            string[] ss = s.Split(new char[] { ' ' });

        }
        public ListNode ReverseeLinkedlistnode(ListNode node)
        {
            if (node != null)
            {
                ListNode previous = null;
                ListNode next = null;
                while (node != null)
                {
                    next = node.Next;
                    node.Next = previous;
                    previous = node;
                    node = next;
                }
                return previous;
            }
            return null;
        }

        public ListNode CreateListNode(string stotal)
        {
            ListNode curent = new ListNode();
            for (int i = 0; i < stotal.Length; i++)
            {
                if (i == 0)
                {
                    curent.val = int.Parse(stotal[i].ToString());
                    continue;
                }
                ListNode newlst = new ListNode();
                newlst.val = int.Parse(stotal[i].ToString());
                newlst.Next = curent;
                curent = newlst;
            }
            return curent;
        }
        public BigInteger sumofnode(ListNode node)
        {
            string total = "";
            StringBuilder builder = new StringBuilder();
            if (node == null)
                return 0;
            ListNode curentnode = node;
            while (curentnode != null)
            {
                builder.Append(curentnode.val);
                if (curentnode.Next == null)
                {
                    break;
                }
                curentnode = curentnode.Next;
            }
            total = builder.ToString();
            builder = new StringBuilder();
            for (int i = total.Length - 1; i >= 0; i--)
            {
                builder.Append(total[i]);
            }
            return BigInteger.Parse(builder.ToString());
        }
        public ListNode AddListnode(int[] data)
        {
            ListNode newNode = null;
            ListNode loopNode = null;
            foreach (var i in data)
            {
                ListNode head1 = new ListNode();
                //if (newNode.Next != null)
                //{
                //    loopNode = newNode.Next;
                //}
                head1.val = i;
                head1.Next = newNode;
                newNode = head1;
            }
            return newNode;


        }
        public void AddAtBeginning(int data)
        {
            ListNode newNode = new ListNode();
            newNode.val = data;
            newNode.Next = head;
            head = newNode;
        }
        public void AddAtEnd(int data)
        {
            ListNode newNode = new ListNode();
            newNode.val = data;

            if (head == null)
            {
                head = newNode;
                return;
            }

            ListNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public int Reverse(int x)
        {
            int a = 0;
            while (x != 0)
            {
                a = a + (x % 10);
                x = x / 10;
                if (x != 0)
                {
                    if (a >= 2147483647 || a <= -2147483647)
                    {
                        return 0;
                    }
                    a = a * 10;
                }
            }
            return a;
        }

        public int MyAtoi(string s)
        {
            int Rvalue = 0;
            int isnegetive = 1;
            char c = ' ';
            bool isminus = false;
            char previouschar = ' ';
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                c = s[i];
                if ((c >= '1' && c <= '9') || (c == '0' && ((isminus && builder.Length > 1) || (!isminus && builder.Length >= 1))))
                {
                    builder.Append(c);
                }
                else if ((c != '0' && c != ' ' && c != '-' && c != '+') || (i != 0 && previouschar >= '0' && previouschar <= '9' && (c == ' ' || c == '-' || c == '+'))
                    || (i != 0 && ((previouschar == '+' && c == '-') || (previouschar == '-' && c == '+') || (previouschar == ' ' && c == '+') || (previouschar == '+' && c == ' '))))
                {
                    break;
                }
                else if (c == '-' && builder.Length == 0)
                {
                    isminus = true;
                    builder.Append(c);
                }
                previouschar = c;
            }
            if (builder.Length == 1 && isminus)
            {
                return 0;
            }
            if (builder.Length != 0)
            {
                //Rvalue = int.Parse(builder.ToString());
                string n = builder.ToString();
                if (n.Length >= 10)
                {
                    int maxvalue = int.MaxValue / 10;
                    int maxvalue1 = (maxvalue * 10) - 7;
                    //if ((n[0] == '-' && n.Length == 11)|| (n[0] != '-' && n.Length == 10))
                    //{
                    //    maxvalue = maxvalue * 10;
                    //}
                    for (int i = 0; i < n.Length; i++)
                    {
                        c = n[i];
                        if (c == '-')
                        {
                            isnegetive = -1;
                            continue;
                        }
                        if (Rvalue > maxvalue && Rvalue > maxvalue1 && n.Length - (i + 1) == 0 && c > '7')
                        {
                            Rvalue = int.MaxValue + (isnegetive < 0 ? 1 : 0);
                        }
                        else if (Rvalue > maxvalue && Rvalue > maxvalue1 && n.Length - i >= 1 && c > '7')
                        {

                        }
                        else
                        {
                            Rvalue = Rvalue + (c - 48);
                        }
                        if ((Rvalue > maxvalue && n.Length - (i + 1) == 0) || (i + 1 == n.Length))
                        {
                            break;
                        }
                        if (Rvalue > maxvalue && n.Length - i >= 1)
                        {
                            Rvalue = int.MaxValue - (isnegetive < 0 ? isnegetive : 0);
                            break;
                        }
                        Rvalue = Rvalue * 10;
                    }
                }
                else
                {
                    return int.Parse(n);
                }
            }
            if (Rvalue > 0)
            {
                Rvalue = Rvalue * isnegetive;
            }
            return Rvalue;
        }
        public void AddAtPosition(int position, int data)
        {
            if (position < 0)
                return;

            ListNode newNode = new ListNode();
            newNode.val = data;
            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            ListNode current = head;
            for (int i = 0; i < position - 1; i++)
            {
                if (current == null)
                    return;  // Position out of bounds
                current = current.Next;
            }

            if (current == null)
                return;  // Position out of bounds

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };
            int Rvalue = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((i > 0) && (((s[i] == 'V' || s[i] == 'X') && s[i - 1] == 'I') || ((s[i] == 'L' || s[i] == 'C') && s[i - 1] == 'X')
                    || ((s[i] == 'D' || s[i] == 'M') && s[i - 1] == 'C')))
                {
                    Rvalue -= (roman[s[i - 1]] * 2);
                }
                Rvalue += roman[s[i]];
            }
            return 0;
        }
        public string IntToRoman(int num)
        {
            string[] Romanvalues = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] lst = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var Rvalue = new StringBuilder();
            int value = 0;
            for (int a = 0; a < lst.Length; a++)
            {
                int div = lst[a];
                if (num >= div)
                {
                    value = num / div;
                    num = num % div;
                    while (value > 0)
                    {
                        Rvalue.Append(Romanvalues[a]);
                        value--;
                    }
                    if (num == 0)
                    {
                        break;
                    }
                }
            }
            return Rvalue.ToString();
        }

        public string LongestCommonPrefix1(string[] strs)
        {
            string prefix = "";
            string first = strs[0];
            bool isprefix = false;
            for (int i = 0; i < first.Length; i++)
            {

                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Length >= i && strs[j][i] == first[i])
                    {
                        isprefix = true;
                    }
                    else
                    {
                        isprefix = false;
                        break;
                    }
                }
                if (isprefix)
                {
                    prefix = prefix + first[i];
                }
                else
                {
                    break;
                }
            }
            var char1 = prefix.ToCharArray();
            return prefix;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                        return "";
                }
            }
            return prefix;
        }

        public bool IsValid(string s)
        {
            string a = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (a.Length >= 1)
                {
                    if (a[a.Length - 1] == '[' && s[i] == ']')
                    {
                        a = a.Remove(a.Length - 1, 1);
                    }
                    else if (a[a.Length - 1] == '{' && s[i] == '}')
                    {
                        a = a.Remove(a.Length - 1, 1);
                    }
                    else if (a[a.Length - 1] == '(' && s[i] == ')')
                    {
                        a = a.Remove(a.Length - 1, 1);
                    }
                    else
                    {
                        a += s[i];
                    }

                }
                else if (a.Length == 0)
                {
                    a += s[i];
                }
            }
            if (a.Length == 0)
            {
                return true;
            }
            return false;
        }
        public int RemoveElement1(int[] nums, int val)
        {
            int removeval = 101;
            int removecount = 0;
            List<int> new1 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    removecount++;
                }
                else
                {
                    new1.Add(nums[i]);
                }
            }
            for (int i = 0; i < removecount; i++)
            {
                new1.Add(-1);
            }
            nums = new1.ToArray();
            return nums.Length - removecount;
        }
        public int RemoveElement(int[] nums, int val)
        {
            int removeval = 101;
            int removecount = 0;
            int temp = 0;
            int length = 0;
            List<int> new1 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    length = nums.Length - 1;

                    while (length >= i && length > 0)
                    {
                        if (nums[length] == val)
                        {
                            length--;
                        }
                        else
                        {
                            removecount++;
                            nums[i] = nums[length];
                            nums[length] = val;
                            break;
                        }
                    }
                }
            }

            return nums.Length - removecount;
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int index = 1;
            int previuos = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (previuos != nums[i])
                {
                    previuos = nums[i];
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }

        public double FindMedianSortedArrays1(int[] nums1, int[] nums2)
        {
            double Rvalue = 0.0;
            int loopindex = nums1.Length + nums2.Length;
            int divtotal = loopindex / 2;
            int divtotal2 = loopindex % 2;
            int mainindex = 0;
            int[] newone = new int[loopindex];
            while (loopindex != 0)
            {
                if (nums1.Length >= mainindex + 1)
                {
                    newone[mainindex] = nums1[mainindex];
                    mainindex++;
                }
                else
                {
                    newone[mainindex] = nums2[mainindex - (nums1.Length)];
                    mainindex++;
                }
                loopindex--;
            }
            Array.Sort(newone);
            if (divtotal2 == 0)
            {
                Rvalue = (newone[divtotal] + newone[divtotal + 1]) / 2.00000;
            }
            else if (divtotal2 > 0)
            {
                Rvalue = newone[divtotal2];
            }
            return Rvalue;
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double Rvalue = 0.0;
            int loopindex = nums1.Length + nums2.Length;
            int mainindex = 0;
            int divtotal = loopindex / 2;
            int divtotal2 = loopindex % 2;
            int[] newone = new int[loopindex];
            while (loopindex != 0)
            {
                if (nums1.Length >= mainindex + 1)
                {
                    newone[mainindex] = nums1[mainindex];
                    mainindex++;
                }
                else
                {
                    newone[mainindex] = nums2[mainindex - (nums1.Length)];
                    mainindex++;
                }
                loopindex--;
            }
            if ((nums1.Length + nums2.Length) > 1)
            {
                Array.Sort(newone);
                if (divtotal2 == 0)
                {
                    Rvalue = (newone[divtotal - 1] + newone[divtotal]) / 2.00000;
                }
                else if (divtotal2 > 0)
                {
                    Rvalue = newone[divtotal];
                }
            }
            else
            {
                Rvalue = newone[0];
            }
            return Rvalue;
        }

        public int[] PlusOne(int[] digits)
        {

            int index = 0;
            BigInteger total = 0;
            string svalue = "";
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits.Length - 1 == i)
                {
                    total += digits[i] + 1;
                }
                else
                {
                    total += digits[i];
                    total *= 10;
                }
            }
            svalue = total.ToString();
            int[] ints = new int[svalue.Length];
            while (index < svalue.Length)
            {
                ints[index] = svalue[index] - '0';
                index++;
            }
            return ints;

        }

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int value = 0;
            Dictionary<char, int> dicchar = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dicchar.ContainsKey(s[i]))
                {
                    dicchar[s[i]]++;
                }
                else
                {
                    dicchar.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dicchar.ContainsKey(t[i]))
                {
                    value = dicchar[t[i]];
                    if (value == 0)
                    {
                        break;
                    }
                    dicchar[s[i]]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public int CountPrimes1(int n)
        {
            int count = 0;
            int maincount = 0;
            for (int i = 2; i < n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count > 2)
                    {
                        break;
                    }
                }
                if (count == 2)
                {
                    maincount++;
                }
            }
            return maincount;
        }
        public int CountPrimes(int n)
        {
            int maincount = 0;
            bool[] Prime = new bool[n + 10];
            for (int i = 2; i < n; i++)
            {
                Prime[i] = true;
            }
            for (int i = 2; 2 * i < n; i++)
            {
                for (int j = 2 * i; j <= n; j += i)
                {
                    Prime[j] = false;
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (Prime[i])
                {
                    maincount++;
                }
            }
            Span<bool> isPrime = stackalloc bool[n + 1];
            // int count=0;
            // int maincount=0;
            // for(int i = 2 ; i < n ; i++ )
            // {
            //     count=0;
            //     for( int j = 1 ; j < i ; j++ )
            //     {
            //             if(i % j == 0){
            //                 count++;
            //             }
            //             if(count>2){
            //                 break;
            //             }
            //     }
            //     if(count==2){
            //         maincount++;
            //     }
            // }
            return maincount;
        }
        public int[] SearchRange(int[] nums, int target)
        {
            int firstvalue = -1, lastvalue = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (firstvalue == -1)
                    {
                        firstvalue = i;
                    }
                    else if (lastvalue < nums[i])
                    {
                        lastvalue = i;
                    }
                }
            }
            if (firstvalue == -1 && lastvalue > -1)
            {
                firstvalue = lastvalue;
            }
            else if (firstvalue > -1 && lastvalue == -1)
            {
                lastvalue = firstvalue;
            }
            return new int[] { firstvalue, lastvalue };
        }
        public int MaxArea(int[] height)
        {
            GC.Collect();
            int TotalL = 0, Leftindex = 0, rightindex = height.Length - 1, Lengthdiff = 0, Height = 0, maxtotal = 0;
            while (Leftindex < rightindex)
            {
                Lengthdiff = rightindex - Leftindex;
                Height = height[rightindex] > height[Leftindex] ? height[Leftindex] : height[rightindex];
                maxtotal = Lengthdiff * Height;
                if (maxtotal > TotalL)
                {
                    TotalL = maxtotal;
                }
                if (height[Leftindex] < height[rightindex])
                {
                    Leftindex++;
                }
                else
                {
                    rightindex--;
                }
            }
            return TotalL;
        }

        #region
        //public IList<string> LetterCombinations(string digits)
        //{
        //    string value = "";
        //    List<string> strings = new List<string>();
        //    Dictionary<char, string> dic = new Dictionary<char, string>() {
        //        { '2',"abc" },
        //        { '3',"def" },
        //        { '4',"ghi" },
        //        { '5',"jkl" },
        //        { '6',"mno" },
        //        { '7',"pqrs" },
        //        { '8',"tuv" },
        //        { '9',"wxyz" }
        //    };
        //    List<string> values = new List<string>();
        //    for (int i = 0; i < digits.Length ; i++) {
        //        if (dic.TryGetValue(digits[i],out value))
        //        {
        //            values.Add(value);
        //        }
        //    }

        //    if (values.Count() > 0)
        //    {
        //        List<string> strings1 = new List<string>();
        //        string s = values[0];
        //        for (int i = 0; i < s.Length ; i++) {
        //            strings1= recursiveloop(ref strings,order: s[i].ToString(), loopindex: 1, values);
        //        }
        //    }
        //    return strings;
        //}
        //public List<string> recursiveloop(ref List<string> strings, string order = "", int loopindex = 0, List<string> values = null)
        //{
        //    List<string> recursive = new List<string>();
        //    string value1 = "";
        //    if (loopindex < values.Count() - 1)
        //    {
        //        for (int i = 0; i < values[loopindex].Length; i++)
        //        {
        //            value1 = order + values[loopindex][i];
        //            if (loopindex < values.Count() - 1)
        //            {
        //                recursive = recursiveloop(ref strings, order: value1, loopindex: loopindex + 1, values: values);
        //            }
        //            else
        //            {
        //                strings.Add(value1);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        strings.Add(value1);
        //    }

        //    return recursive;
        //}
        #endregion
        public IList<string> LetterCombinations(string digits)
        {
            string value = "";

            List<string> strings = new List<string>();
            Dictionary<char, string> dic = new Dictionary<char, string>() {
                    { '2',"abc" },
                    { '3',"def" },
                    { '4',"ghi" },
                    { '5',"jkl" },
                    { '6',"mno" },
                    { '7',"pqrs" },
                    { '8',"tuv" },
                    { '9',"wxyz" }
            };
            List<string> values = new List<string>();
            for (int i = 0; i < digits.Length; i++)
            {
                if (dic.TryGetValue(digits[i], out value))
                {
                    values.Add(value);
                }
            }

            if (values.Count() > 0)
            {
                string s = values[0];
                for (int i = 0; i < s.Length; i++)
                {
                    recursiveloop(ref strings, order: s[i].ToString(), loopindex: 1, values);
                }
            }
            return strings;
        }
        public void recursiveloop(ref List<string> strings, string order = "", int loopindex = 0, List<string> values = null)
        {
            string value1 = "";
            if (loopindex < values.Count())
            {
                for (int i = 0; i < values[loopindex].Length; i++)
                {
                    value1 = order + values[loopindex][i];
                    if (loopindex < values.Count() - 1)
                    {
                        recursiveloop(ref strings, order: value1, loopindex: loopindex + 1, values: values);
                    }
                    else
                    {
                        strings.Add(value1);
                    }
                }
            }
            else
            {
                strings.Add(order);
            }
        }
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string Finalvalue = "", a = "";
            for (int i = 0; i < s.Length; i++)
            {
                dic = new Dictionary<char, int>();
                a = s[i] + "";
                dic.Add(s[i], 0);
                for (int J = i + 1; J < s.Length; J++)
                {
                    if (dic.ContainsKey(s[J]))
                    {
                        if (Finalvalue.Length < a.Length)
                        {
                            Finalvalue = a;
                            Console.WriteLine(Finalvalue);
                        }
                        break;
                    }
                    else
                    {
                        dic.Add(s[J], 0);
                        a += s[J];
                    }
                }
            }
            return Finalvalue.Length;
        }
        static IEnumerable<object> GetEvenNumbers(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                    //yield return 5;
                    //yield return 15;// Yield the current even number
                }
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = list2;
                    list2 = list2.Next;
                }
                current = current.Next;
            }

            if (list1 != null) current.Next = list1;
            if (list2 != null) current.Next = list2;

            return dummy.Next;

            //while (loopnode != null)
            //{
            //    innercount = 0;
            //    list1 = innerloopnode;
            //    if (list1 == null)
            //    {
            //        return list2;
            //    }
            //    while (list1 != null)
            //    {
            //        if (list1.val > loopnode.val)
            //        {
            //            ListNode tempnode = ;
            //            list2
            //            globalcount++;
            //        }
            //        else if (list1.val == loopnode.val && innercount== globalcount)
            //        {
            //            globalcount++;
            //        }
            //        else {
            //            break;
            //        }
            //        innercount++;
            //    }
            //    loopnode = loopnode.Next;
            //}

            return list1;
        }
        public ListNode1 RemoveNthFromEnd(ListNode1 head, int n)
        {
            ListNode1 temp = new ListNode1(0);
            temp.Next = head;
            ListNode1 fast = temp;
            ListNode1 slow = temp;

            for (int i = 0; i <= n; i++)
            {
                if (fast == null) break;
                fast = fast.Next;
            }

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            if (slow.Next != null)
            {
                slow.Next = slow.Next.Next;
            }

            return temp.Next;
        }
        public ListNode1 RemoveNthFromEnd1(ListNode1 head, int n)
        {
            int count = 0;
            ListNode1 current = head;
            ListNode1 current2 = head;
            while (current != null)
            {
                count++;
                if (current.Next == null)
                    break;
                current = current.Next;
            }
            if (count >= n)
            {
                current = head;
                if (count <= n && count == 1)
                {
                    return null;
                }
                n = count - (n - 1);
                for (int i = 1; i <= count; i++)
                {
                    if (i == n)
                    {
                        if (current.Next != null)
                        {
                            current.Next = current.Next.Next;
                            break;
                        }
                        else
                        {
                            current2.Next = null;
                        }
                    }
                    if (i != 1)
                    {
                        current2 = current.Next;
                    }
                    current = current.Next;
                }
            }
            return head;
        }

        #region
        // Difference between throw and throw ex
        //public void throwouter()
        //{
        //    try
        //    {
        //        throwinner();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("throwouter "+ex);
        //        throw ex;
        //    }
        //}
        //public void throwinner()
        //{
        //    try
        //    {
        //        throwinner1();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("throwinner " + ex);
        //        throw ex;
        //    }
        //}
        //public void throwinner1()
        //{
        //    try
        //    {
        //        throw new InvalidOperationException("Inner exception occurred");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("throwinner " + ex);
        //        throw ex;
        //    }
        //}
        //public void throwglobal()
        //{
        //    try
        //    {
        //        throwouter();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("throwglobal " + ex);
        //    }
        //}
        #endregion
    }
    public class ListNode
    {
        public int val;
        public ListNode Next;
    }

    public class ListNode1
    {
        public int val;
        public ListNode1 Next;
        public ListNode1(int _val)
        {
            val = _val;
        }
    }

    #region
    //abstract class IA
    //{
    //    public void a1()
    //    {
    //        Console.WriteLine("cascs");
    //    }
    //    public abstract void a2();
    //}
    //class b : IA
    //{
    //    public void b1()
    //    {
    //        a1();
    //    }
    //    public override void a2()
    //    {
    //        Console.WriteLine("aaa");
    //    }
    //}

    //interface IA
    //{
    //    void a1();
    //}
    //class A : IA
    //{
    //    public void a1()
    //    {
    //        Console.WriteLine("  ");
    //    }
    //}
    //class B1
    //{
    //    public void B11()
    //    {
    //        IA a = new A();
    //        a.a1();
    //    }
    //}

    //class A
    //{
    //    public static void a1(int a)
    //    {
    //        Console.WriteLine("new1223");
    //    }
    //    public static void a1(int a,int b)
    //    {
    //        Console.WriteLine("new1223");
    //    }

    //}
    //class b : A
    //{

    //    public void b1()
    //    {
    //        Console.WriteLine("new");
    //    }

    //}

    //public partial class Person
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public void DisplayFullName1()
    //    {
    //        Console.WriteLine($"{FirstName} {LastName}");
    //    }
    //}
    //public partial class Person
    //{
    //    public void DisplayFullName()
    //    {
    //        DisplayFullName1();
    //    }
    //}

    public abstract class one
    {
        public void A1()
        {

        }
    }

    class b
    {
        static b()
        {
            //one on = new one();
        }
        public void checking1(ref int b, int a = 0, int c = 0) {
        }
        public void nothing()
        {
            int c = 0;
            new123(out int a, 2, ref c, d: 5);
            a = a + 1;
            new123(out a, 1, ref c, 5);
        }
        public void new123(out int a, in int b, ref int c, int d)
        {
            a = 1;
        }
    }
    public class Base
    {
        public const int Max = 100;
        public readonly int id;
        public static int counter;
        //int avalue;
        public Base()
        {
            id = 200;
            counter = 10;
            //avalue = 10;
        }
        public new void Show() => Console.WriteLine("Base");
        public void Show2()
        {
            //Max = 200;
            //id = 200;
            counter = 100;
        }
    }

    public class Derived : Base
    {
        public void Show() => Console.WriteLine("Derived");

        public void Show23()
        {

        }
    }
    public class c : Derived
    {
        public void Show1()
        {
            Show();

        }
    }

    //public interface  IA1
    //{
    //      void one();
    //}
    //public interface IA2: IA1
    //{
    //    void one1();
    //}
    //public abstract class IB2 
    //{
    //    int a;
    //    public IB2()
    //    {
    //        a = 1;
    //    }
    //    public abstract void oneB2();
    //}

    //public abstract class  IB1 : C1, IA1
    //{
    //    int a;
    //    public IB1()
    //    {
    //        a= 1;
    //    }
    //    public abstract void oneB1();
    //    public void one()
    //    {

    //    }
    //}
    public  class C1
    {
        public virtual void onec1()
        {

        }
        public void One1(int a)
        {

        }
    }
    public class C2 : C1
    {
        public  void One(int a)
        {
            
        }
    }

    public class C3
    {
        public void One(int a)
        {
            a = 0;
            int b = 0;
            One1(ref a,out b);
        }
        public void One1(ref int a,out int b)
        {
            b = 0;
        }
    }

    public static class C4
    {
        public static void One(int a)
        {
            a = 0;
            int b = 0;
           
        }
        public static void One(int a,int c)
        {
            a = 0;
            int b = 0;
        }
        public static  void two(int a, int c)
        {
            a = 0;
            int b = 0;
        }

    }
    public sealed class newone
    {
        public newone()
        {

        }

    }
    public  class newone2
    {
        private newone2()
        {
            newone newone = new newone();
        }
    }

    public interface IA
    {
        void A();
    }




    //public class A1 : IA2
    //{
    //    public void one()
    //    {


    //    }
    //    public void one1()
    //    {

    //    }
    //    public override  void oneB1()
    //    {

    //    }
    //}

    #endregion
}


