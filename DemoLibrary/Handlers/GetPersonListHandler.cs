using DemoLibrary.DataAccess;
using DemoLibrary.DTOs;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonDTO>>
    {
        private IDataAccess _data;
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<PersonDTO>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getPersonList().Select(p => new PersonDTO { Name = p.Name, LastName = p.LastName}).ToList());
        }
    }
}
