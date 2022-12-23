using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.DTOs;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, PersonDTO>
    {
        IDataAccess _data;

        public AddPersonHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<PersonDTO> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            _data.addPerson(new Models.PersonsModel
            {
                Name = request.Name,
                LastName = request.LastName,
            });

            return Task.FromResult(new PersonDTO
            {
                Name=request.Name,
                LastName=request.LastName,
            });
        }
    }
}
