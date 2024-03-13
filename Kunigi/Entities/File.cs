namespace Kunigi.Entities;

public class File
{
    public int Id { get; set; }

    public string FilePath { get; set; }

    public string FileType { get; set; }
    
    public int PuzzleId { get; set; }
    public virtual Puzzle Puzzle { get; set; }
}