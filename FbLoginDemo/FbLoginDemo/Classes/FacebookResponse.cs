using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FbLoginDemo.Classes
{
    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Employer
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Location2
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Position
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Work
    {
        public Employer employer { get; set; }
        public Location2 location { get; set; }
        public Position position { get; set; }
        public string description { get; set; }
        public string start_date { get; set; }
    }

    public class With
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Sport
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<With> with { get; set; }
    }

    public class FavoriteTeam
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class FavoriteAthlete
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class InspirationalPeople
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class School
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class With2
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Class
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Education
    {
        public School school { get; set; }
        public string type { get; set; }
        public List<With2> with { get; set; }
        public List<Class> classes { get; set; }
    }

    public class FBResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string link { get; set; }
        public string username { get; set; }
        public string birthday { get; set; }
        public Location location { get; set; }
        public string quotes { get; set; }
        public List<Work> work { get; set; }
        public List<Sport> sports { get; set; }
        public List<FavoriteTeam> favorite_teams { get; set; }
        public List<FavoriteAthlete> favorite_athletes { get; set; }
        public List<InspirationalPeople> inspirational_people { get; set; }
        public List<Education> education { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public int timezone { get; set; }
        public string locale { get; set; }
        public bool verified { get; set; }
        public string updated_time { get; set; }
    }
}