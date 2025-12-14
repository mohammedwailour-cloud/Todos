using System.Collections.Generic;
using System.Text.Json;

namespace TODO_Correction.Services
{
    public class SessionManagerService : ISessionManagerService
    {
        public void Add( String key, object obj, HttpContext context)
        {
            String chaine = JsonSerializer.Serialize(obj);

            context.Session.SetString(key, chaine);

        }
    }
}
