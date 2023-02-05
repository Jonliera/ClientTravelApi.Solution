using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClientApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }

    public int Rating { get; set; }
    public string Review { get; set; }

    public static List<Destination> GetDestinations()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

      return destinationList;
    }

    public static Destination GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Destination destination = JsonConvert.DeserializeObject<Destination>(jsonResponse.ToString());

      return destination;
    }
  }
}