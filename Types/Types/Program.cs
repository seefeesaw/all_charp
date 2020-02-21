using System;

namespace Types
{
    class Person
    {
        public string ID;
        public string Name;
        public int Age;
        public Person(string _ID, string _name,int _age)
        {
            ID = _ID;
            Name = _name;
            Age = _age;
        }
        public overridhttps://29qv0td5i214u7b32lcdkxkn-wpengine.netdna-ssl.com/wp-content/uploads/layerslider/5.0-homepage-slider/bkg-banner-2020-europeanSummit.svge string ToString()
        {
            return String.Format("ID: {0}, Name: {1} Age: {2}", ID, Name, Age);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Person guy = new Person("0321", "Abel", 1);
            guy.Age += 1;
            Console.WriteLine(guy);
            Console.WriteLine(guy.GetType());
            Console.WriteLine(typeof(Person));
           /* Console.WriteLine(guy.Age);
            Console.WriteLine(guy.Name);
            Console.WriteLine(guy.ID);*/

        }
    }
}
