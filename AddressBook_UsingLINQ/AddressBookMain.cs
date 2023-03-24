using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UsingLINQ
{
    public class AddressBookMain
    {
        PersonData person = new PersonData();
        /// <summary>
        /// Uc 3 Add Data in list 
        /// </summary>
        public void Additiondata(List<PersonData> personDatas)
        {
            personDatas.Add(new PersonData() { Id=1, FirstName="Snehal", LastName="Bansod", Address="PLOT2", City ="Sindewahi", State="Maha", Zip="13334", PhoneNum="1234567890", Email="snehal@gmail" });
            personDatas.Add(new PersonData() { Id=2, FirstName="Snehu", LastName="Bansod", Address="PLOT3", City ="Nagpur", State="UP", Zip="134355", PhoneNum="1234567890", Email="snehu@gmail" });
            personDatas.Add(new PersonData() { Id=3, FirstName="Mayur", LastName="Bansod", Address="PLOT2", City ="Mule", State="Maha", Zip="134366", PhoneNum="1234567890", Email="mayu@gmail" });
            personDatas.Add(new PersonData() { Id=4, FirstName="Vaibhav", LastName="Bansod", Address="PLOT6", City ="Chandrapur", State="MP", Zip="134377", PhoneNum="1234567890", Email="vaibhav@gmail" });
            personDatas.Add(new PersonData() { Id=5, FirstName="Sonakshi", LastName="Vanjari", Address="PLOT7", City ="Sindewahi", State="UP", Zip="134343", PhoneNum="1234567890", Email="sona@gmail" });
            personDatas.Add(new PersonData() { Id=6, FirstName="Hemlata", LastName="Bekare", Address="PLOT8", City ="Nagpur", State="MP", Zip="134344", PhoneNum="1234567890", Email="hem@gmail" });
            Display(personDatas);
        }
        public void Display(List<PersonData> personDatas)
        {
            foreach (var data in personDatas)
            {
                Console.WriteLine(data.FirstName+" "+data.LastName+" "+data.Address+" "+data.City+" "+data.State+" "+data.Zip+" "+data.PhoneNum+" "+data.Email);
            }
        }
        ///// <summary>
        ///// Uc4 update Contact by using FirstName //
        ///// </summary>
        public void UpdateContact(List<PersonData> personDatas)
        {
            Console.WriteLine("Entr the name");
            string serachName = Console.ReadLine();
            var validCustomers = personDatas.Where(c => c.FirstName==serachName);
            foreach (PersonData data in validCustomers)
            {
                Console.WriteLine("Enter the LastName");
                data.LastName=Console.ReadLine();
                Console.WriteLine("Enter the Address");
                data.Address=Console.ReadLine();
                Console.WriteLine("Enter the City");
                data.City=Console.ReadLine();
                Console.WriteLine("Enter the State");
                data.State=Console.ReadLine();
                Console.WriteLine("Enter the Zip");
                data.Zip=Console.ReadLine();
            }
            Display(personDatas);
        }
        /// <summary>
        /// UC 5 Delect contact
        /// </summary>
        /// <param name="personDatas"></param>
        public void Remove(List<PersonData> personDatas)
        {
            Console.WriteLine("Enter the name is present or not");
            string Names = Console.ReadLine();
            try
            {
                personDatas.RemoveAll(e => (e.FirstName == Names));

                Display(personDatas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Uc 6 Retrive data from linq to object by city or state     
        //SELECT* FROM AddressBookTable WHERE city='Nagpur';
        //SELECT* FROM AddressBookTable WHERE state='Maha';
        /// </summary>
        /// <param name="personDatas"></param>
        public void RetriveByCityOrState(List<PersonData> personDatas)
        {

            Console.WriteLine("choice what you want ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    var resultCity = from i in personDatas where i.City == "Nagpur" select i;
                    Display(resultCity.ToList());
                    break;
                case 2:
                    var resultState = from i in personDatas where i.State == "UP" select i;
                    Display(resultState.ToList());
                    break;
            }
        }
        /// <summary>
        /// Uc7 Count data by City or State
        /// //SELECT COUNT(*) FROM AddressBookTable WHERE city LIKE'Nagpur';
        //SELECT COUNT(*) FROM AddressBookTable WHERE state LIKE'UP';
        /// </summary>
        /// <param name="personDatas"></param>
        public void RetriveByCityOrStateCount(List<PersonData> personDatas)
        {
            Console.WriteLine("choice what you want ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    var resultCity = (from i in personDatas where i.City == "Nagpur" select i).Count();
                    Console.WriteLine("Total count of city "+resultCity);
                    break;
                case 2:
                    var resultState = (from i in personDatas where i.State == "UP" select i).Count();
                    Console.WriteLine("total count of state "+resultState);
                    break;
            }
        }
    }
}
