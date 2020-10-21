using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Basketball
{
    public class List
    {
        public class Query : IRequest<List<Basketball>> {}
        public class Handler : IRequestHandler<Query, List<Basketball>>
        {
            private readonly DataContext context;
            public Handler(DataContext context) => this.context = context;

            public Task<List<Basketball>> Handle(Query request, CancellationToken cancellationToken)
            {
                return this.context.Basketball.ToListAsync();
            }
        }
    }
}