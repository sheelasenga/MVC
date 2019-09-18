using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstASPDotNetMVCApp.Models
{
    public class Customer
    {
        private string firstname = "";
        private string surname = "";
        private int age = 0;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}