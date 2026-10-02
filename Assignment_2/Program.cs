namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region indexers section in assignment 1 
            // i have solved and submittedthe indexers section in assignment 1 
            #endregion



            #region Question 1
            #region What is the difference between a class and a struct?
            // class --> reference type , copy the reference of the object to another variable , stored in heap memory , support inheritance and polymorphism , can be null , default constructor is provided if no constructor is defined in the class , suitable for large data
            // struct --> value type , copy the value of the struct to another variable , stored in stack memory , do not support inheritance and polymorphism , cannot be null , default constructor always provided , suitable for small data 
            #endregion

            #region Why are classes more suitable than structs for large applications?
            // classes are more suitable than structs for large applications because they are reference types and can be easily managed in memory. They also support inheritance and polymorphism, which allows for more flexible and reusable code. Structs, on the other hand, are value types and are better suited for small data structures that do not require inheritance or polymorphism.
            #endregion 
            #endregion
        }
    }
}
