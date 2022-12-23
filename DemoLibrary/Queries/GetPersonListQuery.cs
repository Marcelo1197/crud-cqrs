using DemoLibrary.DTOs;
using MediatR;

namespace DemoLibrary.Queries
{
    public class GetPersonListQuery : IRequest<List<PersonDTO>>
    {
        public GetPersonListQuery()
        {

        }
    }
}
