using System;


namespace Komodo_Repo
{
    public class Developer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool AccessPluralsight { get; set; }


        public Developer()
        {

        }

        public Developer(string name, int id, bool pluralSightAccess)
        {
            Name = name;
            ID = id;
            AccessPluralsight = pluralSightAccess;

        }
    }

}
