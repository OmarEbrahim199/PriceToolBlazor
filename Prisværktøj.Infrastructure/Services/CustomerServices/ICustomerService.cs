using pricetoolapi;

namespace Pricetool.Services.CustomerServices
{
    public interface ICustomerService
    {
        CorporateDTO SelectedCustomer { get; set; }
        event Action OnSelectedCustomerChanged;
    }
}
