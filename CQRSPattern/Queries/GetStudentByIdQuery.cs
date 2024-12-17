using CQRSPattern.Models;
using MediatR;

namespace CQRSPattern.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
