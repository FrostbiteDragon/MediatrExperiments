using System.Threading.Tasks;

public static class PersonData
{
    public static async Task<Person[]> GetAllPeople()
    {
        using var session = Database.Instance.OpenAsyncSession();
        return await session.Advanced.AsyncDocumentQuery<Person>().ToArrayAsync();
    }

    public static async Task AddPerson(Person person)
    {
        using var session = Database.AsyncSession;
        await session.StoreAsync(person);
        await session.SaveChangesAsync();
    }
}