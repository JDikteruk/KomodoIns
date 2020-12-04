using System;
using System.Collections.Generic;

namespace Komodo_Repo
{
    public class DeveloperRepo
    {


        private List<Developer> _listofDevelopers = new List<Developer>();
        //Create
        public void AddDeveloper(Developer developer)
        {
            _listofDevelopers.Add(developer);
        }


        //Read
        public List<Developer> GetDeveloperList()
        {
            return _listofDevelopers;
        }

        //Update

        //Delete

    }

}