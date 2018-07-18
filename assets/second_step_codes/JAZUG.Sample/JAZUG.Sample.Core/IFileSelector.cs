using System;
using System.Threading.Tasks;
namespace JAZUG.Sample.Core
{
    public interface IFileSelector
    {
        Task<string> SelectSingle();
    }
}
