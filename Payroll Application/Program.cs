using System;

public class Payroll { 

    public struct Employee {

        public string Id; 
        public string Name;
        public String Gender;
        public string Address;
        public float Height;
        public float Weight;
        public byte Age;
        public long PFNo;
        public short Experience;
        public double Salary;
        public decimal GrossPay;
        public Employee( string id,string name,String gender,string address,float height,float weight,byte age,long pfno,short experience,double salary) {
            Name = name;
            Id = id;
            Gender = gender;
            Address = address;
            Height = height;
            Weight = weight;
            Age = age;
            PFNo = pfno;
            Experience = experience;
            Salary = salary;
            GrossPay = (decimal)(Salary+(0.12*Salary)+(0.1*Salary)+(.06*Salary)); // Assuming 12% DA, 10% HRA, and 6%PF 

        }
    }
    
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to the Payroll Application!");
        Console.WriteLine("Enter Employee Details");
        Console.Write("ID: ");
        string id = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
       
        string gender;
        while (true)
        {
            Console.Write("Gender (M/F): ");
            gender = Console.ReadLine().ToUpper();
            if (gender == "M") 
            {
                gender = "Male";
                break;
            }
            else if(gender == "F")
            {
                gender = "Female";
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'M' or 'F'.");
            }
        } 
        Console.Write("Address: ");
        string address = Console.ReadLine();
        float height;
        while (true)
        {
            try
            {
                Console.Write("Height (in cm): ");
                height = float.Parse(Console.ReadLine());
                break;

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid height");
            }

        }
        float weight;
        while (true)
        {
            try
            {
                Console.Write("Weight (in kg): ");
                weight = float.Parse(Console.ReadLine());
                break;

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid weight");
            }

        }
        byte age;
        while (true)
        {
            try
            {
                Console.Write("Age: ");
                age = byte.Parse(Console.ReadLine());
                break;

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid age");
            }

        }
        long pfno;
        while (true)
        {
            try
            {
                Console.Write("PF Number: ");
                pfno = long.Parse(Console.ReadLine());
                break;

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid Pf NUmber");
            }

        }
        short experience;
        while (true)
        {
            try
            {
                Console.Write("Experience (in years): ");
                experience = short.Parse(Console.ReadLine());
                break;

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid Experience");
            }

        }
        double salary;
        while (true)
        {
            try
            {
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());
                break;

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid Salary");
            }

        }
        
        
        

        // Create an instance of Employee struct with the provided details
        Employee employee = new Employee(id, name,gender, address, height, weight, age, pfno, experience, salary);
        Console.WriteLine();
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nGender: {employee.Gender} \nAddress: {employee.Address} \nHeight: {employee.Height} cm \nWeight: {employee.Weight} kg \nAge: {employee.Age} years \nPF Number: {employee.PFNo} \nExperience: {employee.Experience} years \nBasic Pay: Rs.{employee.Salary} \nGross Pay: Rs.{employee.GrossPay}");

    }
}