using System.Threading.Tasks;
using FBinging.Manager;
using FBinging.Public;

namespace FBinging.Views
{
    public class Welcome : BaseView
    {
        public Welcome() : base("Login", "welcome")
        {
            Loadres();
        }

        private async void Loadres()
        {
            await Task.Delay(2000);
            ViewManager.Instance.ReplaceView(typeof(Login));
        }
    }
}