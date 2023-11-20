using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayListt
{
    public class ArrayListt
    {
        ArrayList arraylist = null;

        public int Index {  get; set; }
        public ArrayListt() 
        {
            if (arraylist == null)
            {
                arraylist = new ArrayList();
                Console.WriteLine("Object Created For ArrayList Successfully !");
            }
        }

        public void Menu1()
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("       ARRAYLIST METHODS");
                Console.WriteLine("====================================");
                Console.WriteLine("   1. ADD METHOD");
                Console.WriteLine("   2. INSERT METHOD");
                Console.WriteLine("   3. REMOVE METHOD");
                Console.WriteLine("   4. REMOVEAT METHOD");
                Console.WriteLine("   5. CLEAR METHOD");
                Console.WriteLine("   6. COUNT METHOD");
                //Console.WriteLine("   7. SORT METHOD");
                Console.WriteLine("   7. READ METHOD");
                Console.WriteLine("   8. EXIT");
                Console.WriteLine("====================================\n");
                try
                {
                    Console.Write("ENTER YOUR OPTION   -   ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1 || option == 2)
                    {
                        Menu2(option);
                    }
                    
                    else if(option == 3)
                    {
                        Remove();
                    }
                    else if(option == 4)
                    {
                        RemoveAt();
                    }
                    else if(option == 5)
                    {
                        Clear();
                    }
                    else if (option == 6)
                    {
                        Count();
                    }
                    //else if(option == 7)
                    //{
                    //    Sort();
                    //}
                    else if (option == 7)
                    {
                         Read();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please Enter INTEGER Value In OPTION !");
                }
            }

        }
        public void Menu2(int option)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("      What Value Gonna Add ?");
                Console.WriteLine("====================================");
                Console.WriteLine("  1.  INTEGER");
                Console.WriteLine("  2.  FLOAT");
                Console.WriteLine("  3.  LONG");
                Console.WriteLine("  4.  STRING");
                Console.WriteLine("  5.  CHARACTER");
                Console.WriteLine("====================================\n");
                try
                {
                    Console.Write("Enter Your Option  -  ");
                    int value = int.Parse(Console.ReadLine());
                    
                    if(option == 1 || option == 2)
                    {
                        AddAllMethod(option, value);
                    }
                   
                    break;
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message); 
                    Console.WriteLine("Please Enter INTEGER Value In OPTION !");
                }
            }
            
        }

        public void AddAllMethod(int option, int value)
        {

            if (value == 1)
            {
                Console.WriteLine("Enter INTEGER Value Only !!");
                for (; ; )
                {
                    try
                    {
                        Console.Write("Enter Value : ");
                        int num = int.Parse(Console.ReadLine());
                        if (num == 0)
                        {
                            Console.WriteLine("Thank You " + (char)1);
                            break;
                        }
                        if (option == 1)
                        {
                            arraylist.Add(num);

                        }
                        else if (option == 2)
                        {
                            Index = GetIndexForInsert();
                            arraylist.Insert(Index, num);
                            Console.WriteLine("Value Inserted Successfully !");
                            break;
                        }
                        Console.WriteLine("Added Successfully !");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Enter Integer Value Only !");
                    }

                }
            }
            else if (value == 2)
            {
                Console.WriteLine("Enter FLOAT Value !!");
                for (; ; )
                {
                    try
                    {
                        Console.Write("Enter Value : ");
                        float value1 = float.Parse(Console.ReadLine());
                        if (value1 == 0)
                        {
                            Console.WriteLine("Thank You " + (char)1);
                            break;
                        }
                        if (option == 1)
                        {
                            arraylist.Add(value1);
                        }
                        else if (option == 2)
                        {
                            Index = GetIndexForInsert();
                            arraylist.Insert(Index, value1);
                            Console.WriteLine("Value Inserted Successfully !");
                            break;
                        }
                        Console.WriteLine("Added Successfully !");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Enter FLOAT Value !");
                    }

                }
            }
            else if (value == 3)
            {
                Console.WriteLine("Enter LONG Value !!");
                for (; ; )
                {
                    try
                    {
                        Console.Write("Enter Value : ");
                        long value2 = long.Parse(Console.ReadLine());
                        if (value2 == 0)
                        {
                            Console.WriteLine("Thank You " + (char)1);
                            break;
                        }
                        if (option == 1)
                        {
                            arraylist.Add(value2);
                        }
                        else if (option == 2)
                        {
                            Index = GetIndexForInsert();
                            arraylist.Insert(Index, value2);
                            Console.WriteLine("Value Inserted Successfully !");
                            break;
                        }
                        Console.WriteLine("Added Successfully !");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Enter LONG Value !");
                    }

                }

            }
            else if (value == 4)
            {
                Console.WriteLine("Enter STRING Value !!");
                for (; ; )
                {
                    Console.Write("Enter Value : ");
                    string value4 = Console.ReadLine();
                    if (value4 == "")
                    {
                        Console.WriteLine("Thank You " + (char)1);
                        break;
                    }
                    if (option == 1)
                    {
                        arraylist.Add(value4);
                    }
                    else if (option == 2)
                    {
                        Index = GetIndexForInsert();
                        arraylist.Insert(Index, value4);
                        Console.WriteLine("Value Inserted Successfully !");
                        break;
                    }
                    Console.WriteLine("Added Successfully !");
                }

            }
            else if (value == 5)
            {
                Console.WriteLine("Enter CHARACTER Value Only !!");
                for (; ; )
                {
                    try
                    {
                        Console.Write("Enter Value : ");
                        char value3 = char.Parse(Console.ReadLine());
                        if (value3 == '0')
                        {
                            Console.WriteLine("Thank You " + (char)1);
                            break;
                        }
                        if (option == 1)
                        {
                            arraylist.Add(value3);
                        }
                        else if (option == 2)
                        {
                            Index = GetIndexForInsert();
                            arraylist.Insert(Index, value3);
                            Console.WriteLine("Value Inserted Successfully !");
                            break;
                        }
                        Console.WriteLine("Added Successfully !");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Enter CHARACTER Value Only !!");
                    }
                }

            }
        }

        public int GetIndexForInsert()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the Insert Index - ");
                    int index = int.Parse(Console.ReadLine());
                    return index;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Write(" Index Should be Integer ! ");

                }
            }
            
        }

        public bool Check()
        {
            if (arraylist != null && arraylist.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Read()
        {
            int x = 1;
            if(Check())
            {
                foreach (var item in arraylist)
                {
                    Console.WriteLine("Value {0}  is  {1}", x++, item);
                }
            }
            else
            {
                Console.WriteLine("ArrayList is Empty !");
            }    
            
            Console.ReadKey();
        }
        public void Remove()
        {
            while(true)
            {
                bool Find = true;
                int x = 0;
                try
                {
                    if (Check())
                    {
                        Console.Write("Remove Value  : ");
                        string Value = Console.ReadLine();

                        if (Value == "")
                        {
                            Console.WriteLine("Thank You " + (char)1);
                            break;
                        }
                        foreach (var array in arraylist)
                        {
                            string change = array.ToString();
                            if(change == Value)
                            {
                                arraylist.RemoveAt(x);
                                arraylist.Insert(x, change);
                                Find = false;
                                arraylist.Remove(change);
                                Console.WriteLine("Removed Successfully !");
                                break;
                            }
                            x++;
                        }
                        if (Find)
                        {
                            Console.WriteLine("Element Not Found !");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("ArrayList is Empty !. You Cannot Remove Items.");
                        break;
                    }
                    Console.ReadKey();
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void RemoveAt ()
        {
            while(true)
            {
                if (Check())
                {
                    try
                    {
                        Console.Write("Enter the Index to Remove Item  : ");
                        int Index = int.Parse(Console.ReadLine());

                        arraylist.RemoveAt(Index);
                        Console.WriteLine("Item Removed Successfully !");
                        break;

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("ArrayList is Empty !. You Cannot Remove Items.");
                }
            }
            Console.ReadKey();
        }
        public void Clear()
        {
            if(Check())
            {
                arraylist.Clear();
                Console.WriteLine("ArrayList is Cleared !");
            }
            else
            {
                Console.WriteLine("ArrayList is Already Empty !");
            }

            Console.ReadKey();
        }
        public void Count()
        {
            int count = arraylist.Count;
            Console.WriteLine("Number Of Elements In the Array Is : "+count);
            Console.ReadKey();
        }

        //public void Sort()
        //{
        //    if(Check())
        //    {
        //        arraylist.Sort();
        //        Console.WriteLine("ArrayList Sorted Successfully !");
        //    }
        //    else
        //    {
        //        Console.WriteLine("ArrayList is Empty !");
        //    }

        //    Console.ReadKey ();
        //}
    }
}
