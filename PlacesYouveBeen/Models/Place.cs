using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string VisitDate { get; set; }
    public string EndDate { get; set; }
    public string TravelPartners { get; set; }
    public string JournalEntry { get; set;}
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };
    public Place(string cityName, string visitDate, string endDate, string travelPartners, string journalEntry)
    {
      CityName = cityName;
      VisitDate = visitDate;
      EndDate = endDate;
      TravelPartners = travelPartners;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}