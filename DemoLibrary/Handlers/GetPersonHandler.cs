using DemoLibrary.DataAccess;
using DemoLibrary.DTOs;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonHandler: IRequestHandler<GetPersonQuery, PersonDTO>
    {
        private IDataAccess _data;

        public GetPersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public async Task<PersonDTO> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            var person = await Task.FromResult(_data.Get(request.Id));
            return new PersonDTO { Name = person.Name, LastName = person.LastName };
        }
    }
}
