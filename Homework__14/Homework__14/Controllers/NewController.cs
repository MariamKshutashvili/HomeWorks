using Homework__14.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework__14.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewController : Controller
    {
        public string jsonFile = Path.Combine(Directory.GetCurrentDirectory(), "information.json");

        //1////////////////////////////////////////////////////////////////////////////////////
        [HttpPost("addinfo")]
        public IActionResult AddInfo([FromQuery] Person person)
        {

            string first = person.Firstname;
            string last = person.Lastname;
            string job = person.JobPosition;
            double salary = person.Salary;
            double workExp = person.WorkExperince;
            Address addresss = person.PersonAddress;
            DateTime time = person.CreateDate;


            var jsonfile = new
            {
                Firstname = first,
                Lastname = last,
                JobPosition = job,
                Salary = salary,
                WorkExperince = workExp,
                CreateDate = time,
                PersonAddress = addresss,

            };

            var streamReader = new StreamReader(jsonFile);
            var jread = streamReader.ReadToEnd();
            var jlist = JsonConvert.DeserializeObject<List<object>>(jread);
            streamReader.Close();

            if (jlist != null)
            {
                jlist.Add(jsonfile);
                var jsonData = JsonConvert.SerializeObject(jlist, Formatting.Indented);
                using StreamWriter st = new(jsonFile);
                st.WriteLine(jsonData);
                return Accepted(jlist);
            }
            else
            {

                var jsonList = new List<object>() { jsonfile };
                var newJson = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
                using StreamWriter str = new(jsonFile);
                str.WriteLine(newJson);
                return Accepted(jsonList);            

             }




                }
        //2////////////////////////////////////////////////////////////////////////////////////

        [HttpGet("getinfo")]
        public IActionResult GetInfo()
        {
            var streamReader = new StreamReader(jsonFile);
            var jread = streamReader.ReadToEnd();
            var jlist = JsonConvert.DeserializeObject<List<Person>>(jread);
            streamReader.Close();
            return Accepted(jlist);
        }
        //3////////////////////////////////////////////////////////////////////////////////////

        [HttpGet("getinfo/{id}")]
        public IActionResult GetByID(int id)
        {
            var streamReader = new StreamReader(jsonFile);
            var jread = streamReader.ReadToEnd();
            var jlist = JsonConvert.DeserializeObject<List<Person>>(jread);
            streamReader.Close();
            return Accepted(jlist[id]);
        }

        //4////////////////////////////////////////////////////////////////////////////////////

        [HttpGet("getFiltered}")]
        public IActionResult GetFiltered([FromQuery] int id, Person person)
        {
            var streamReader = new StreamReader(jsonFile);
            var jread = streamReader.ReadToEnd();
            var jlist = JsonConvert.DeserializeObject<List<Person>>(jread);
            streamReader.Close();
            return Accepted(jlist.Where(x => x.WorkExperince > person.WorkExperince));

        }
        //5////////////////////////////////////////////////////////////////////////////////////

        [HttpDelete("getDeleted/{id}")]
        public IActionResult GetDeleted(int id)
        {
            var streamReader = new StreamReader(jsonFile);
            var jread = streamReader.ReadToEnd();
            var jlist = JsonConvert.DeserializeObject<List<Person>>(jread);
            streamReader.Close();

            jlist.RemoveAt(id) ;
            return Accepted(jlist);    

        }

        //6////////////////////////////////////////////////////////////////////////////////////

        [HttpPut("getUpdated/{id}")]
        public IActionResult UpdateUser(int id, Person person)
        {
            var streamReader = new StreamReader(jsonFile);
            var jread = streamReader.ReadToEnd();
            var jlist = JsonConvert.DeserializeObject<List<Person>>(jread);
            streamReader.Close();
            jlist[id].Firstname = person.Firstname;
            jlist[id].JobPosition = person.JobPosition;
            return Accepted(jlist);

        }




    }
}
