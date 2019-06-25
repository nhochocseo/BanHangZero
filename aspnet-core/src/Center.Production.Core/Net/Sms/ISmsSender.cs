using System.Threading.Tasks;

namespace Center.Production.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}