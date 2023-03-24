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
        }
    }
}
