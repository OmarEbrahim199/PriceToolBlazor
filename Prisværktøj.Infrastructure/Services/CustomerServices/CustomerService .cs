using pricetoolapi;

namespace Pricetool.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private CorporateDTO? selectedCustomer;

        public CorporateDTO SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnSelectedCustomerChanged?.Invoke();
            }
        }

        public event Action OnSelectedCustomerChanged;
    }
}
