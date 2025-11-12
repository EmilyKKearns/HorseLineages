using Domain;
using MediatR;
using Persistence;

namespace Application.Races.Commands;

public class CreateRace
{
    public class Command : IRequest<int>
    {
        public required Race race { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command, int>
    {
        public async Task<int> Handle(Command request, CancellationToken cancellationToken)
        {
            context.Races.Add(request.race);

            await context.SaveChangesAsync(cancellationToken);

            return request.race.RaceId;
        }
    }
}