namespace TodoApi.Models;

public class Purchase
{   
    
    public long Id { get; set; }
    public uint Userid { get; set; }
    public float Amount { get; set; }

    public string? Collectionsategory { get; set; }

}