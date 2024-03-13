namespace Kunigi.Entities;

public class Game
{
    public int Id { get; set; }
    
    public short Year { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public string ImageUrl { get; set; }
    
    public int HostId { get; set; }
    public virtual Team Host { get; set; }
    
    public int WinnerId { get; set; }
    public virtual Team Winner { get; set; }
}