using Linq;

//public class Vehicle
//{
//    public int VehicleID { get; set; }
//    public string VehicleName { get; set; }
//    public string Vehicletype { get; set; }
//    public string VehicleColor { get; set; }
//    public double VehicleMilage { get; set; }
//    public string VehicleFuelType { get; set; }
//}
//public class Program
//{
//    static void Main(string[] args)
//    {
//        List<Vehicle> vlist = new List<Vehicle>()
//        {
//            new Vehicle() { VehicleID = 1, VehicleName = "Swift", Vehicletype = "Car", VehicleColor = "Red", VehicleMilage = 60.5, VehicleFuelType = "Petrol" },
//            new Vehicle() { VehicleID = 2, VehicleName = "Waganor", Vehicletype = "Car", VehicleColor = "White", VehicleMilage = 60.5, VehicleFuelType = "Petrol" },
//            new Vehicle() { VehicleID = 3, VehicleName = "Activa", Vehicletype = "Two-Wheeler", VehicleColor = "blue", VehicleMilage = 60.5, VehicleFuelType = "Petrol" },
//            new Vehicle() { VehicleID = 4, VehicleName = "Audi", Vehicletype = "Car", VehicleColor = "black", VehicleMilage = 60.5, VehicleFuelType = "Petrol" },
//            new Vehicle() { VehicleID = 5, VehicleName = "BMW", Vehicletype = "Car", VehicleColor = "Red", VehicleMilage = 60.5, VehicleFuelType = "Petrol" }
//        };

//        var VehicleList = vlist.Select(x=>x.VehicleName) ;

//        foreach (var vehicle in vlist)
//        {
//            Console.WriteLine($"VehicleID: {vehicle.VehicleID}, VehicleName: {vehicle.VehicleName}, VehicleType: {vehicle.Vehicletype}, VehicleColor: {vehicle.VehicleColor}, VehicleMilage: {vehicle.VehicleMilage}, VehicleFuelType: {vehicle.VehicleFuelType}");
//        }


//        var totalRecordCount = vlist.Count();
//        Console.WriteLine($"Total Record Count: {totalRecordCount}");

//        var vehiclesStartingWithS = vlist.Where(x => x.VehicleName.StartsWith("S")).ToList();

//        foreach (var vehicle in vehiclesStartingWithS)
//        {
//            Console.WriteLine($"VehicleID: {vehicle.VehicleID}, VehicleName: {vehicle.VehicleName}, VehicleType: {vehicle.Vehicletype}, VehicleColor: {vehicle.VehicleColor}, VehicleMilage: {vehicle.VehicleMilage}, VehicleFuelType: {vehicle.VehicleFuelType}");
//        }

//        Console.ReadLine();


//        var context = new ApplicationDBContext();
//        //For example, Display FirstName of all employees.
//        var q1 = context.Employee.Select(x => x.FirstName);
//        foreach (var employee in q1)
//        {
//            Console.WriteLine("\n {0}", employee);
//        }

//        Console.ReadLine();

//    }


//}

var context = new ApplicationDBContext();

//LINQ Queries on Projection operators
//1. Display data of all employees.
var q1 = context.Employee.Select(x => x.FirstName);
foreach (var employee in q1)
{
    Console.WriteLine("\n {0}", employee);
}

//2. Select ActNo, FirstName and Salary of all employees to a new class and display it.
var q2 = context.Employee.Select(x => new Employee() { AccountNo = x.AccountNo, FirstName = x.FirstName, Salary = x.Salary }).ToList();
foreach (var employee in q2)
{
    Console.WriteLine("\nAccountNo: {0}, FirstName: {1}, Salary: {2}", employee.AccountNo, employee.FirstName, employee.Salary);
}
//3.Display data in following format => {Anil} works in {Admin} Department.

var q3 = context.Employee.Select(x => x.FirstName + " works in " + x.Department + "Department ");
foreach (var employee in q3)
{
    Console.WriteLine("\n{0}", employee);
}
//4.Select Employee Full Name, Email and Department as anonymous and display it.
var q4 = context.Employee.Select(x => new { ActNo = x.AccountNo, FN = x.FirstName, Salary = x.Salary }).ToList();
foreach (var employee in q4)
{
    Console.WriteLine("\n {0}", employee);
}


//5. Display employees with their joining date.
var q6 = context.Employee.Select(x => x.FirstName + " " + x.LastName + " " + x.JoiningDate);
foreach (var employee in q6)
{
    Console.WriteLine("\n {0}", employee);
}