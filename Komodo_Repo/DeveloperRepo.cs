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
        public bool UpdateDeveloper(int oldID, Developer newParm)
        {
            //Find Develooper
            Developer ogdeveloper = GetDevByID(oldID);

            //Update Developer
            if (ogdeveloper != null)
            {
                ogdeveloper.Name = newParm.Name;
                ogdeveloper.ID = newParm.ID;
                ogdeveloper.AccessPluralsight = newParm.AccessPluralsight;
                return true;
            }
            else
            {
                return false;
            }

        }


        //Delete
        public bool RemoveDeveloper(int id)
        {
            Developer developer = GetDevByID(id);

            if (developer == null)
            {
                return false;
            }

            int initialCount = _listofDevelopers.Count;
            _listofDevelopers.Remove(developer);

            if (initialCount > _listofDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Helper
        public Developer GetDevByName(string name)
        {
            foreach (Developer developer in _listofDevelopers)
            {
                if (developer.Name == name)
                {
                    return developer;
                }
            }

            return null;
        }

        public Developer GetDevByID(int id)
        {
            foreach (Developer developer in _listofDevelopers)
            {
                if (developer.ID == id)
                {
                    return developer;
                }
            }

            return null;
        }
    }
}

