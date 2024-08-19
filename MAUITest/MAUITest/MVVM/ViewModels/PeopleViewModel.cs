using MAUITest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITest.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            People = new ()
            {
               new Person
               {
                   Name="Luis",
                   Age=60,
                   BirthDate=new DateTime(1964,5,16),
                   IsMarried=false,
                   LunchTime=new TimeSpan(12,30,0),
                   Weight=85
               },
                new Person
               {
                   Name="Wisho",
                   Age=29,
                   BirthDate=new DateTime(1994,10,20),
                   IsMarried=false,
                   LunchTime=new TimeSpan(12,30,0),
                   Weight=75
               },
                 new Person
               {
                   Name="Diego",
                   Age=28,
                   BirthDate=new DateTime(1996,4,25),
                   IsMarried=false,
                   LunchTime=new TimeSpan(12,30,0),
                   Weight=75
               },
                  new Person
               {
                   Name="Ana Luisa",
                   Age=39,
                   BirthDate=new DateTime(1985,7,16),
                   IsMarried=true,
                   LunchTime=new TimeSpan(10,30,0),
                   Weight=65
               },
                   new Person
               {
                   Name="Alex",
                   Age=14,
                   BirthDate=new DateTime(2009,9,19),
                   IsMarried=false,
                   LunchTime=new TimeSpan(12,30,0),
                   Weight=49
               },
                    new Person
               {
                   Name="Kokito",
                   Age=8,
                   BirthDate=new DateTime(2016,8,6),
                   IsMarried=false,
                   LunchTime=new TimeSpan(10,30,0),
                   Weight=30
               },
                         new Person
               {
                   Name="Pato",
                   Age=5,
                   BirthDate=new DateTime(2018,12,16),
                   IsMarried=false,
                   LunchTime=new TimeSpan(10,30,0),
                   Weight=23
               },
                                   new Person
               {
                   Name="Sebastian",
                   Age=4,
                   BirthDate=new DateTime(2020,3,12),
                   IsMarried=false,
                   LunchTime=new TimeSpan(10,30,0),
                   Weight=20
               },
            };
        }

        public List<Person> People { get; set; }

    }
}
