namespace TodosService.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }

}