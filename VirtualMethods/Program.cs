
namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMysql dbMysql = new DbMysql();
            dbMysql.Add();


            DbMsSql dbMsSql = new DbMsSql();
            dbMsSql.Add();

            Console.ReadLine();
        }
    }
}