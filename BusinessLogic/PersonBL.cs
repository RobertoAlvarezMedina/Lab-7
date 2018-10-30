using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PersonBL

    {
        List<Person> persons = new List<Person>();
        public void Create(Person person)
        {
            if(string.IsNullOrEmpty(person.Name))
            throw new ArgumentException("Name cannot be empty");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public Person GetById(int id)
        {
            foreach(var item in persons)
            {
                if (item.Id == id) return item;
            }
            return null;
        }
    }
}
