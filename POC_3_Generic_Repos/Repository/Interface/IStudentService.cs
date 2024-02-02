namespace POC_3_Generic_Repos.Repository.Interface
{
    public interface IStudentService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Insert(T item);
        List<T> Update(T item);
        List<T> Delete(int id);
    }
}
