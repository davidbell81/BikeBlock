using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeBlock
{
	public interface IPageService
	{
		Task PushAsync(Page page);
		Task<Page> PopAsync();
		Task PushModalAsync(Page page);
		Task<Page> PopModalAsync(bool animated = false);
		Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
		
		Task DisplayAlert(string title, string message, string ok);
		
		
	}
}