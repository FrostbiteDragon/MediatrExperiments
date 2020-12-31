using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

public sealed class GetAllPeopleQuerry : IRequest<Person[]> { }
public sealed class GetAllPeopleQuerryHandler : IRequestHandler<GetAllPeopleQuerry, Person[]>
{
    public async Task<Person[]> Handle(GetAllPeopleQuerry request, CancellationToken cancellationToken)
    {
        var people = await PersonData.GetAllPeople();

        //do validation logic

        return people;
    }
}