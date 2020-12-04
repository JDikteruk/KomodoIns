namespace Komodo_Repo
{

    public class DevTeam
    {
        public string TeamName { get; set; }
        public int TeamID { get; set; }
        public Developer TeamMember { get; set; }


        public DevTeam()
        {

        }

        public DevTeam(string name, int teamID, Developer teamMember)
        {
            TeamName = name;
            TeamID = teamID;
            TeamMember = teamMember;
        }
    }

}
