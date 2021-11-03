using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public IMapper Mapper { get; }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Activity.Id);

                // activity.Title = request.Activity.Title ?? activity.Title; Could do the equivalent of this for every single property but will instead use auto mapper

                _mapper.Map(request.Activity, activity); //Now when we update an activity we are updating every field within our activity.  Will be using this fairly frequently

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}