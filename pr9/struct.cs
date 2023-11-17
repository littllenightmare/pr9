using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9
{
    struct student
    {
        //поля
        public string Surname;
        public string Street;
        public int Home;
        public int Apartment;
        /// <summary>
        /// Конструктор структуры
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="street">улица</param>
        /// <param name="home">дом</param>
        /// <param name="apartment">квартира</param>
        public student(string surname, string street, int home, int apartment)
        {
            Surname = surname;
            Street = street;
            Home = home;
            Apartment = apartment;
        }
    }
}
