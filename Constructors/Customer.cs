﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{


    class Customer
    {


        public Customer()
        {
            //default Constructer

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FistName = firstName;
            LastName = lastName;
            City = city;

        }



        public int Id { get; set; }

        public string FistName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }





    }
}
