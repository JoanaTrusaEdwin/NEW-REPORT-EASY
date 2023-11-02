using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_REPORT_EASY.Models
public class Incident
{
    public int Id { get; set; }
    public string Description { get; set; }
    public Category IncidentCategory { get; set; }
    public Location IncidentLocation { get; set; }
    public Urgency UrgencyLevel { get; set; }
    public List<Media> MediaList { get; set; }
    public Feedback IncidentFeedback { get; set; }
    public DateTime Date { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Location
{
    public int Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public class Urgency
{
    public int Id { get; set; }
    public string Level { get; set; }
}

public class Media
{
    public int Id { get; set; }
    public string FilePath { get; set; }
}

public class Feedback
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
}