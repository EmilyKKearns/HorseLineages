using Domain;
using MediatR;
using Persistence;

namespace Application.HorseSnapshots.Commands;

public class CreateHorseSnapshot
{
    public class Command : IRequest<int>
    {
        public required HorseSnapshot horseSnapshot { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command, int>
    {
        public async Task<int> Handle(Command request, CancellationToken cancellationToken)
        {
            context.HorseSnapshots.Add(request.horseSnapshot);

            await context.SaveChangesAsync(cancellationToken);

            return request.horseSnapshot.HorseSnapshotId;
        }
    }
}