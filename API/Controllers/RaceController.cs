using Application.Races.Commands;
using Application.Races.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class RaceController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Race>>> GetRace()
    {
        return await Mediator.Send(new GetRaceList.Query());
    }

/*  [HttpGet("{id}")]
    public async Task<ActionResult<Race>> GetRaceDetail(int id)
    {
        return await Mediator.Send(new GetRaceDetails.Query { RaceId = id });
    }
*/
    [HttpPost]
    public async Task<ActionResult<int>> CreateRace(Race race)
    {
        return await Mediator.Send(new CreateRace.Command { race = race });
    }
/*
    [HttpPut]
    public async Task<ActionResult> EditRace(Race Race)
    {
        await Mediator.Send(new EditRace.Command { Race = Race });

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteRace(int id)
    {
        await Mediator.Send(new DeleteRace.Command { RaceId = id });

        return Ok();
    } 
*/
}
