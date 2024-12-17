using CQRSPattern.Models;
using MediatR;

namespace CQRSPattern.Queries
{
    public class GetStudentListQuery :  IRequest<List<StudentDetails>>
    {
    }
}
