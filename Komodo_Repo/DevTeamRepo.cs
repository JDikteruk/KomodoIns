using System;
using System.Collections.Generic;

namespace Komodo_Repo

public class DevTeamRepo
{

    private List<DevTeam> _listOfDevTeam = new List<DevTeam>;

    //Create
    public void CreateDevTeam(DevTeam devTeam)
    {
        _listOfDevTeam.Add(devTeam)
    }


    //Read
    public List<DevTeam> GetDevTeamList()
    {
        return _listOfDevTeam
    }


    //Update
    public bool UpdateDevTeam(int oldID, DevTeam newParm)
    {
        //Find DevTeam
        DevTeam ogdevTeam = GetDevTeamByID(oldID);

        //Update DevTeam
        if (ogdevTeam != null)
        {
            ogdevTeam.Name = newParm.Name;
            ogdevTeam.TeamID = newParm.ID;
            ogdevTeam.TeamMember = newParm.TeamMember
            return true;
        }
        else
        {
            return false;
        }

    }

    //Delete
    public bool RemoveDevTeam(int id)
    {
        DevTeam devTeam = GetDevTeamByID(id)

        if (devTeam == null)
        {
            return false;
        }

        int initialCount = _listOfDevTeam.Count;
        _listOfDevTeam.Remove(devTeam);

        if (initialCount > _listOfDevTeam.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Helper
    public DevTeam GetDevTeamByID(int id)
    {
        foreach (DevTeam devTeam in _listOfDevTeam)
        {
            if (devTeam.TeamID == id)
            {
                return devTeam;
            }
        }

        return null;
    }
}

