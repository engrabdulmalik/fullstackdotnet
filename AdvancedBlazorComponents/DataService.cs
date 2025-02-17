using System.Collections.Generic;
using System.Threading.Tasks;

public class DataService
{
    public async Task<List<string>> GetProductsAsync()
    {
        await Task.Delay(1000);
        return new List<string> { "Product1", "Product2", "Product3" };
    }
}