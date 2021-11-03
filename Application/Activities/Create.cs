using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        //Commands do not return data
        public class Command : IRequest
        {
            public Activity Activity { get;set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.Add(request.Activity); //Not touching the database at this point

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}