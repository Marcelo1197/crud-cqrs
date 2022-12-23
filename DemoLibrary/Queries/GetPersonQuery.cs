using DemoLibrary.DTOs;
using MediatR;

namespace DemoLibrary.Queries
{
    public class GetPersonQuery: IRequest<PersonDTO>
    {
        public int Id { get; set; }

        public GetPersonQuery(int id)
        {
            Id = id;
        }
    }
}
