namespace WebApplication1.Models.DTOs;

public class GetCharacterDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }

    public ICollection<GetCharacterTitlesDTO> Titles { get; set; }
    public ICollection<GetCharacterBackpackDTO> Backpack { get; set; }
}

public class GetCharacterTitlesDTO
{
    public int CharacterId { get; set; }
    
    public int Titled { get; set; }
    public DateTime AcquiredAt { get; set; }
}

public class GetCharacterBackpackDTO
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public int Amound { get; set; }
}