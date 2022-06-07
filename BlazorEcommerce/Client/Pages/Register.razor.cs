namespace BlazorEcommerce.Client.Pages
{
    public partial class Register
    {
        private UserRegister _user = new UserRegister();
        private string _message = String.Empty;
        string _messageCssClass = String.Empty;

        private async void HandleRegistration()
        {
            var result = await AuthService.Register(_user);
            _message = result.Message;
            if (result.Success) { _messageCssClass = "text-success"; }
            else { _messageCssClass = "text-danger"; }
        }
    }
}
