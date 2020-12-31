using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class AddPersonCommand : IRequest<Unit> 
{
    public Person Person { get; set; }
}
public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand, Unit>
{
    public async Task<Unit> Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        //do validation

        await PersonData.AddPerson(request.Person);
        return new Unit();
    }
}
