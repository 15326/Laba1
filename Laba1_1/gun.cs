using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Laba1_1
{
    public class gun
    {
        private string name;
        private double kol;
        private int dal;

        /// <summary>
        /// Инициализирует новый экземпляр класса Gun значением по умалчанию
        /// </summary> 

        public gun()
        {
            this.name = "AK-47";
            this.kol = 7.62;
            this.dal = 1800;

        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Tovar значением 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="kol">Колибр</param>
        /// <param name="dal">Дальность</param>
        public gun(string Name, double Kol, int Dal)
        {
            Name = name;
            Kol = kol;
            Dal = dal;
        }
        /// <summary>
        /// Вход объекта класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\n Имя: " + name + "\n колибр: " + kol + "\n дальность  : " + dal;
        }
    }
}
