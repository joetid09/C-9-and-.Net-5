﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
//             object height = 1.88; // storing a double in an object
// object name = "Amir"; // storing a string in an object
// Console.WriteLine($"{name} is {height} metres tall.");
// //int length1 = name.Length; // gives compile error!
// int length2 = ((string)name).Length; // tell compiler it is a string
// Console.WriteLine($"{name} has {length2} characters.");

//storing a string in a dynamic object
        dynamic anotherName = "Ahmed";
        //this compiles but would throw an exception at run-time
        //if you later store a data type that does not have a
        //property named length
        int length = anotherName.Length;
        }
    }
}
