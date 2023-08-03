using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoonSiteTask.Models;
using System.Text.Json;

namespace MoonSiteTask.Controllers
{
    public class VaadController
    {
        public async Task<List<Recipt>> GetRecipts(){
        using (var HttpClient = new HttpClient()){
            try{
        var res = await HttpClient.GetAsync("https://localhost:44327/umbraco/api/ReciptsApi/GetRecipts");
            var resString = await res.Content.ReadAsStringAsync();
            var ReciptsVals = JsonSerializer.Deserialize<List<Recipt>>(resString,
                new JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
            return ReciptsVals!;
        }
        catch(Exception err){
            Console.WriteLine(err);
            return null!;
        }
        
        }
        }
    
    }
}