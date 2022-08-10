// Creating an object of Employee class
using Question1;

Employee employeeObj = new Employee("Gyan", "Kharel", 25000);

// Displaying fullname and salary
employeeObj.ShowFullName();
employeeObj.ShowSalary();

// Changing firstname
employeeObj.FirstName = "Hari";

// Increment salarty by 5000
employeeObj.IncrementSalary(5000);

// Displaying fullname and salary
employeeObj.ShowFullName();
employeeObj.ShowSalary();