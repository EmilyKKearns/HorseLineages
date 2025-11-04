using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.HorseSnapshots.Commands;

public class DeleteHorseSnapshot
{
    public class Command : IRequest
    {
        public required int HorseSnapshotId { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var horseSnapshot = await context.HorseSnapshots
                .FindAsync([request.HorseSnapshotId], cancellationToken)
                ?? throw new Exception("Cannot find HorseSnapshot");

            context.Remove(horseSnapshot);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}