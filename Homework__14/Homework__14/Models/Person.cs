using Microsoft.Owin.BuilderProperties;
using System;
using System.Net;

namespace Homework__14.Models
{
    public class Person
    {
        public DateTime CreateDate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobPosition { get; set; }
        public double Salary { get; set; }
        public double WorkExperince { get; set; }
        public Address PersonAddress { get; set; }

        


}
    
}
