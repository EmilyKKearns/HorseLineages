using Application.HorseSnapshots.Commands;
using Application.HorseSnapshots.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HorseSnapshotsController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<HorseSnapshot>>> GetHorseSnapshots()
    {
        return await Mediator.Send(new GetHorseSnapshotList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<HorseSnapshot>> GetHorseSnapshotDetail(int id)
    {
        return await Mediator.Send(new GetHorseSnapshotDetails.Query { HorseSnapshotId = id });
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateHorseSnapshot(HorseSnapshot horseSnapshot)
    {
        return await Mediator.Send(new CreateHorseSnapshot.Command { horseSnapshot = horseSnapshot });
    }

    [HttpPut]
    public async Task<ActionResult> EditHorseSnapshot(HorseSnapshot horseSnapshot)
    {
        await Mediator.Send(new EditHorseSnapshot.Command { HorseSnapshot = horseSnapshot });

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteHorseSnapshot(int id)
    {
        await Mediator.Send(new DeleteHorseSnapshot.Command { HorseSnapshotId = id });

        return Ok();
    }
}
