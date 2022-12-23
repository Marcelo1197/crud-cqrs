using DemoLibrary.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DemoLibrary.Commands
{
    public class AddPersonCommand : IRequest<PersonDTO>
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;
    }
}
