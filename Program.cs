namespace Properties_Ortiz_Victor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a object to referance the Car class
            Car C1 = new Car();
            // Sets the Make and Model to a new value from the set in the Car class
            C1.Model = "Mustang";
            C1.Make = "Ford";
            // Prints a sentance to the console with the Model and Make values
            Console.WriteLine($"Car numbero Uno: Make = {C1.Make}, Model = {C1.Model}");
            // Creates a second separate object to referance to the car class
            Car C2 = new Car();
            // Sets the Make and Model to a new value from the set in the Car class
            C2.Model = "Civic";
            C2.Make = "Honda";
            // Prints a sentance to the console with the Model and Make values
            Console.WriteLine($"Car numbero Dos: Make = {C2.Make}, Model = {C2.Model}");
        }
    }
}
