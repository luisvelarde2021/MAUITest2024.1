using MAUITest.MVVM.Models;
namespace MAUITest.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new()
            {
                Name = "Alex Patt",
                Age = 14,
                BirthDate= new DateTime(2009,9,19),
                IsMarried = false,
                LunchTime=new TimeSpan(2,0,0),
                Weight=49
            };
        }

        public Person Person { get; set; }
    }
}
