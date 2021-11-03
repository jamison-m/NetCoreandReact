using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> {}

        public class Handler : IRequestHandler<Query, List<Activity>>
        {

            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                //ToListAsync can take a cancellation token as a param and this can allow us to cancel a long-running request.
                return await _context.Activities.ToListAsync();


                // Example of how to use cancellation tokens
                /*
                try
                {
                    for(var i = 0; i < 0; i++){
                        cancellationToken.ThrowifCancellationRequested();
                        await.Task.Delay(1000, cancellationToken);
                        _logger.LogInformation($"Task {i} has completed");
                    }
                }catch (Exception ex) when (ex is TaskCancelledException){
                    _logger.LogInformation("Task was cancelled");
                }
                */
                // Task should be cancelled around task 5
            }
        }
    }
}