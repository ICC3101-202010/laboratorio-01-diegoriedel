using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio1diegoriedel
{
    class person
    {
        public int lanzar()
        {
            Random rnd = new Random();
            int lanzar = rnd.Next(0, 3);
            return lanzar;
        }
        private string Name;
        private string LastName;
        public person()
        {
            this.Name = "Bob";
            this.LastName = "Kunga";
        }
        public string Getname()
        {
            return Name;
        }
        public string Getlastname()
        {
            return LastName;
        }
    }
}
