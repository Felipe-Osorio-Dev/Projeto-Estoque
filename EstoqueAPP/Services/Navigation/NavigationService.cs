using EstoqueAPP.Views.Register;

namespace EstoqueAPP.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        public void NavigateTo(string key)
        {
            throw new NotImplementedException();
        }

        public void OpenRegisterDialog()
        {
            using (RegisterForm registerForm = new RegisterForm())
            {
                if(registerForm.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                MessageBox.Show("Testando");
            }
        }
    }
}
