namespace AddressBook_UsingLINQ
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("AddressBook management Using LINQ to Object with Query Syntax and Lambda Expression");
            
            List<PersonData> personDatas = new List<PersonData>();
            AddressBookMain book = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Add contact 2.Update data 3.Delect  4.Retrive Data by City or State 5.RetriveByCityOrStateCount 6.Exist");
                // Uc1 LINQ Object Create with the help of collection
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        book.Additiondata(personDatas);
                        break;
                    case 2:
                        book.UpdateContact(personDatas);
                        break;
                    case 3:
                        book.Remove(personDatas);
                        break;
                    case 4:
                        book.RetriveByCityOrState(personDatas);
                        break;
                    case 5:
                        book.RetriveByCityOrStateCount(personDatas);
                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("Exist");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}