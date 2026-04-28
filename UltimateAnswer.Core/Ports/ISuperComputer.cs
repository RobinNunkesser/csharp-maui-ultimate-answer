using System.Threading.Tasks;
using Italbytz.Common.Abstractions;

namespace UltimateAnswer.Core.Ports
{
    public interface ISuperComputer
    {
        Task<string> Answer(string question);
    }
}
