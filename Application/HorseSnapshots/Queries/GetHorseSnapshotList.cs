using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.HorseSnapshots.Queries;

public class GetHorseSnapshotList
{
    public class Query : IRequest<List<HorseSnapshot>> { }

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<HorseSnapshot>>
    {
        public async Task<List<HorseSnapshot>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.HorseSnapshots.ToListAsync(cancellationToken);
        }
    }
}