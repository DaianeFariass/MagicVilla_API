using System.Runtime.CompilerServices;

namespace MagicVilla_VillaAPI.Logging
{
    public interface ILogging
    {
        public void Log(string message, string type);
    }
}
