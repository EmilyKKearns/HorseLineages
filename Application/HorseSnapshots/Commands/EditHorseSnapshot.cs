using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.HorseSnapshots.Commands;

public class EditHorseSnapshot
{
    public class Command : IRequest
    {
        public required HorseSnapshot HorseSnapshot { get; set; }
    }

    public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var horseSnapshot = await context.HorseSnapshots
                .FindAsync([request.HorseSnapshot.HorseSnapshotId], cancellationToken)
                ?? throw new Exception("Cannot find activity");

            mapper.Map(request.HorseSnapshot, horseSnapshot);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}