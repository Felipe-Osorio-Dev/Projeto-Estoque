using EstoqueAPP.Services.Navigation;
using EstoqueAPP.Views.Main;

namespace EstoqueAPP.Presenters.Main
{
    internal class MainPresenter
    {
        private readonly INavigationService _navigationService;
        private readonly IMainView _mainView;

        public MainPresenter(INavigationService navigationService, IMainView mainView)
        {
            _navigationService = navigationService;
            _mainView = mainView;

            _mainView.OpenDialogRegister += OpenDialogRegister;
        }

        private void OpenDialogRegister(object sender, EventArgs args)
        {
            _navigationService.OpenRegisterDialog();
        }
    }
}
