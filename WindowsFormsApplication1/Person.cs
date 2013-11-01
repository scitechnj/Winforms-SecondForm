﻿using System;

namespace WindowsFormsApplication1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2}", FirstName, LastName, Age);
        }
    }
}