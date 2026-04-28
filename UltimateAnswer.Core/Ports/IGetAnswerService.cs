using Italbytz.Common.Abstractions;

namespace UltimateAnswer.Core.Ports
{
    public interface IGetAnswerService
        : IAsyncService<string, string> { }
}
