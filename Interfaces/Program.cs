
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //Console.WriteLine("================================================================");
            //NewMethod1();

            ICustomerDal[] dals = new ICustomerDal[3] { new MsSqlCustomerDal(), new MysqlCustomerDal(), new OracleCustomerDal() };

            foreach(var dal in dals)
            {
                dal.Add();
            }

            Console.ReadLine();
        }

        private static void NewMethod1()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer(1, "Yücel", "Sarıkaya");
            personManager.Add(customer);
        }

        private static void NewMethod()
        {
            ICustomerDal dal = new MsSqlCustomerDal();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(dal);
        }
    }
}