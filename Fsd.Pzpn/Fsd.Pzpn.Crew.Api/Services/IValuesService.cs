using System.Collections.Generic;

namespace Fsd.Pzpn.Crew.Api.Services
{
    public interface IValuesService
    {
        IEnumerable<string> GetAll();
    }
}
