using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class Program
    {
        private ListNode head;
        static void Main(string[] args)
        {

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

            Program program = new Program();
            //program.head = new ListNode();
            int[] lst = new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 1 };
            for (int i = 0; i < lst.Length; i++)
            {
                program.AddAtBeginning(lst[i]);
            }
            //program.AddAtBeginning(1);
            //program.AddAtBeginning(9);
            //program.AddAtBeginning(9);
            //program.AddAtBeginning(9);
            //program.AddAtBeginning(9);
            //program.AddAtBeginning(9);//[0,0,0,0,0,0,0,0,0,0,1]
            //program.ReverseeLinkedlistnode(program.head);
            var t1 =program.sumofnode(program.head);
            //program.AddAtBeginning(30);
            Program program1 = new Program();
            int[] lst1 = new int[] { 9 };
            for (int i = 0; i < lst1.Length; i++)
            {
                program1.AddAtBeginning(lst1[i]);
            }
            var t2 = program.sumofnode(program1.head);
            int total =  t1 + t2;
            var retun = program.CreateListNode(total.ToString());
            program.AddAtEnd(10);
            program.AddAtPosition(3,20);

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
                if(i==0)
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
        public int sumofnode(ListNode node)
        {
            string total = "";
            StringBuilder builder = new StringBuilder();
            if (node == null) 
                return 0;
            ListNode curentnode= node;
            while (curentnode != null) 
            {
                total += curentnode.val;
                if (curentnode.Next == null)
                {
                    break;
                }
                curentnode = curentnode.Next;
            }
            for (int i = total.Length - 1; i >= 0; i--)
            {
                builder.Append(total[i]);
            }
            if(builder.ToString().StartsWith("9") && builder.ToString().Length > 9)
            {
                total = "0" ;
            }
            else
            {
                total = builder.ToString();
            }
                return int.Parse(total.ToString());
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

    }
    public class ListNode
    {
        public int val;
        public ListNode Next;
    }
}


