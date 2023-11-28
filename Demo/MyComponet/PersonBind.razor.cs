using Demo.Data;

namespace Demo.MyComponet
{
    public partial class PersonBind
    {
        public int PersonID { get; set; }
        public Person MyPerson { get; set; }
        public List<Person> PersonList { get; set; }
        public PersonBind()
        {

            PersonList = new List<Person>();
            PersonList.Add(new Person() { Id = 1, Name = "Abd Elrahman", Salary = 20000 });
            PersonList.Add(new Person() { Id = 2, Name = "Omnia", Salary = 20000 });
            PersonList.Add(new Person() { Id = 3, Name = "Tarek", Salary = 20000 });
        }
        public void GetData()
        {
            Console.WriteLine("Hiii from GEtData");
            MyPerson = PersonList.FirstOrDefault(p => p.Id == PersonID);
        }
        public void fun1(int id)
        {
            Console.WriteLine(id);
        }
    }
}
