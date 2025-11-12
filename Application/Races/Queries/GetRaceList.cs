using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Races.Queries;

public class GetRaceList
{
    public class Query : IRequest<List<Race>> { }

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Race>>
    {
        public async Task<List<Race>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Races.ToListAsync(cancellationToken);
        }
    }
}