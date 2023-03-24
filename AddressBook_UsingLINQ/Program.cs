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
                Console.WriteLine("1.Add contact 2.Update data 3.Delect 4Exist");
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
                        flag = false;
                        Console.WriteLine("Exist");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}