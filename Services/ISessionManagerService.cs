namespace TODO_Correction.Services
{
    public interface ISessionManagerService
    {
        public void Add(String key, object obj, HttpContext context);
    }
}
