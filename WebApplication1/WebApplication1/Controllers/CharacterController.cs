using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.DTOs;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly DbService _dbService;
    public CharacterController(DbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet]
    [Route("{characterID}")]
    public async Task<IActionResult> GetCharacterData(int characterID)
    {
        var character = await _dbService.GetCharacterData(characterID);

        return Ok(character.Select(e => new GetCharacterDTO()
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            CurrentWei = e.CurrentWei,
            MaxWeight = e.MaxWeight,
            Backpack = e.Backpacks.Select(p => new GetCharacterBackpackDTO()
            {
                CharacterId = p.CharacterId,
                TitleId = p.ItemId,
                Amound = p.Amount
            }).ToList(),
            Titles = e.CharacterTitles.Select(w => new GetCharacterTitlesDTO()
            {
                CharacterId = w.CharacterId,
                Titled = w.TitleId,
                AcquiredAt = w.AcquiredAt
            }).ToList()
        }));

   
    }
}

