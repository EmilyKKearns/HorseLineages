using Domain;
using MediatR;
using Persistence;

namespace Application.HorseSnapshots.Queries;

public class GetHorseSnapshotDetails
{
    public class Query : IRequest<HorseSnapshot>
    {
        public required int HorseSnapshotId { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, HorseSnapshot>
    {
        public async Task<HorseSnapshot> Handle(Query request, CancellationToken cancellationToken)
        {
            var horseSnapshot = await context.HorseSnapshots.FindAsync([request.HorseSnapshotId], cancellationToken);

            if (horseSnapshot == null)
            {
                throw new Exception("HorseSnapshot not found");
            }

            return horseSnapshot;
        }
    }
}