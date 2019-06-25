using Xamarin.Forms.Internals;

namespace Center.Production.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}