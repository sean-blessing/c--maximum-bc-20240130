namespace FakeDataAPI {
    public interface ICustomerList {
        List<Customer> CustomerList { get; set; }
    }

    public class CustomerCollection : ICustomerList {
        List<Customer> _customerList = new ();
        public List<Customer> CustomerList { get { return _customerList; } set { _customerList = value; } }
    }
}
}
