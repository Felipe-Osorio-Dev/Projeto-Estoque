namespace EstoqueAPP.Services.Navigation
{
    internal interface INavigationService
    {
        void NavigateTo(string key);
        void OpenRegisterDialog();
    }
}
