using System.Threading.Tasks;
using RestSharp;

namespace TravelClientApi.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/v2.0/destinations", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}