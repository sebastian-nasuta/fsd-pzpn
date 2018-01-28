using System.Collections.Generic;

namespace Fsd.Pzpn.Crew.Api.Services
{
    public interface IValuesServices
    {
        IEnumerable<string> GetAll();
    }
}
