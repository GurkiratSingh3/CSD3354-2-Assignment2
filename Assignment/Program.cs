﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
//Student Name:- Gurkirat Singh Student Id:-C0731779
//student Name:-Robindeep Singh  Student Id:- C0723381
// CSD 3354 Section 2
//Assignment 2
//March 6-2019
{
    public class Program
    {
        public static void Main()
        {
           DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();   
        }
    }
    public delegate int MyDelegate(out int i);

    public class DelegateExercises
        {
        int Method(out int i)
            {
            i = 100;
            return 0;
            System.Console.WriteLine("Method1" + i);
        }          
        public void Method3()
            {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = null;
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intValue;
            myDelegate2(out intValue);
        }
    }
}
