using System;

namespace ArraysAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SingleDimensional name = new SingleDimensional();
            //name.SdArray();
            //name.SdArray2();
            //name.SdArray3();
            //name.SdArray4();
            //name.SdArray4B();
            //name.GetSdArray5();
            name.SdArrayMethods();
        }
    }
}
//Arrays-store multiple variables of the same type in a single structure (array data structure)
//Like a list of numbers, or list of string (50 states)
//All data types in the array must be the same type
//Element- individual item in an array
//Arrays can be single-dimensional, multidimensional, or jagged
//Arrays dimensions (rank) is the number of "indices" needed to access an element
//Arrays length is the number of elements in all dimensions
//Length and rank will show you how big the array is
//The size of an array cant change once its been defined
//Arrays are zero based (start at position 0)
//Once created all elements are filled with their default value (0-for int, null-for classes)
//Array elements can be of any type, including an array type
//Array types are reference types 

//Types of arrays:
//Single-dimensional - all values are in a straight line
//Multidimensional - same number of elements in all dimensions
//Jagged - different number of elements in each dimension "array of arrays"

//Declare single-dimensional
//Data type, followed by square bracket ([]), name, the 'new' keyword, same data type, 
//followed by square brackets with how many positions (# of elements)

//Assign values, or read vaules to a element in the array
//use square brackets with element position number (assigning values by index)

//Loop (interate) an arrays elements
//For loop is good (specify starting and ending position)
//Foreach best
//Array starts at 0, and end a its length minus 1

//Declare multidimensional
//Same a single, type, square brackets but comma for each dimension greater than one, name, new, 
//square brackets but comma for each dimension greater than one 
//(int[, ,] array1 = new int[4, 2, 3]; - 3 dimensions)

//Assign values multidimensional
//we have to provide a value for each dimension
//(int[, ,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } }; - 3 dimensions)
//(int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } }; - The same array with dimensions specified)

//Loop (interate) an multidimensional arrays elements
//need nested for loops
//2d 2 loops, 3d 3 loops