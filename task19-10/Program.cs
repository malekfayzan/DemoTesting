

//     String[] personDetail = new String[6];

//     personDetail[0] = "Malek Fayzan Husain";
//     personDetail[1] = "Yudiz Solution";
//     personDetail[2] = "MCA";
//     personDetail[3] = "3rdSem";
//     personDetail[4] = "Vadodara";
//     personDetail[5] = "Work From Office";


//     // let  s Initialize Array


//     Console.WriteLine("Hello, World!");
//     Console.WriteLine("1st value:\t{0}", personDetail[0]); 
//     // System.Console.WriteLine(personDetail[0]);
//     personDetail.GetType();
//     System.Console.WriteLine(personDetail.GetType());
//     // for (int i = 0; i < personDetail.length; i++)
//     // {
//     //    Console.WriteLine("This Is Array");
//     // }
//       for (int i = 0; i < 5; i++)
//     {
//         Console.WriteLine($"{personDetail[i]}");
//     }
//    Console.ReadLine();
//         }
//     }
// }


// using System;
// namespace MySuperBank
// {
//     class Program
//     {
//         static void Main(){
//             var nm = new List<String> {"<Name>","Kishita","Tirthana"};

//            foreach (var item in nm)
//            {
//            Console.WriteLine($"Hello This IS The Name Of The CEO: {item}");
//            }
//         }
//     }

// }


using System;
using System.Collections.Generic;
using System.Collections;

// //Array Example
namespace Array
{
    class Program
    {

        // class Student
        // {
        //     public int Id { get; set; }
        //     public string Name { get; set; }
        // }
        // class Test
        // {
        //     public string birth {get; set;}
        //     public int sal {get; set;}
        // }
        static void Main(String[] args)
        {

            try
            {


                //Single Dimensional Array
                // int[] arr = new int[2];

                // Console.WriteLine("This Is Is Single-Dimensional Arrays");
                // Console.WriteLine("Enter The 1st Value Here...");
                // arr[0] = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter The 2nd Value Here...");
                // arr[1] = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine("HYour 1st Value : " + arr[0]);
                // Console.WriteLine("Your 2nd Value : " + arr[1]);


                //MultiDimensional Array
                // Console.WriteLine("Here Two-dimensional array....");
                // int[,] twoD = new int[2,2];

                // Console.WriteLine("Enter The 1st Value Here...");
                // twoD[0,0] = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter The 2nd Value Here...");
                // twoD[0,1] = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine(twoD[0, 0]+" "+twoD[0,1]);

                //     Console.WriteLine("Enter The 2nd Array 1st Value Here...");
                // twoD[1,0] = Convert.ToInt32(Console.ReadLine());

                //      Console.WriteLine("Enter The 2nd Array 2nd Value Here...");
                // twoD[1,1] = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine(twoD[1, 0]+" "+twoD[1,1]);
                // // Console.WriteLine(twoD[0, 1]);


                //User 
                //     System.Console.WriteLine("Enter The Size Of Array");
                //    int a =  Convert.ToInt32(Console.ReadLine());
                //    int b =  Convert.ToInt32(Console.ReadLine());
                //     int[,] array2d = new int[a, b];
                //     Console.WriteLine("Tirthana Kansagara");
                //     Console.WriteLine("enter the value of 2d array : ");

                // for (int i = 0; i < array2d.GetLength(0) ; i++)
                // {
                //     for (int j = 0; j < array2d.GetLength(1); j++)
                //     {
                //         Console.Write($"[{i} {j}] : ");
                //        array2d[i,j] = Convert.ToInt32(Console.ReadLine());


                //     }
                // }
                //   for (int i = 0; i <array2d.GetLength(0); i++)
                // {
                //   for (int j = 0; j < array2d.GetLength(1); j++)
                //   {
                //         Console.Write($"[{array2d[i,j]}]");

                //   }  
                // }


                //Using Generic
                // adding elements using add() method
            //     var primeNumbers = new List<int>();
            //     primeNumbers.Add(1);
            //     primeNumbers.Add(3);
            //     primeNumbers.Add(5);
            //     primeNumbers.Add(7);

            //     Console.WriteLine("No of elelemts: " + primeNumbers.Count);

            //     var cities = new List<string>();
            //     cities.Add("New York");
            //     cities.Add("London");
            //     cities.Add("Mumbai");
            //     cities.Add("Chicago");
            //     cities.Add(null); // null is allowed

            //     Console.WriteLine("No of elelemts: " + cities.Count);

            //     // adding elements using collection initializer syntax
            //     var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            //     Console.WriteLine("No of elelemts: " + bigCities.Count);

            //     var students = new List<Student>() {
            //     new Student(){ Id = 1, Name="Bill"},
            //     new Student(){ Id = 2, Name="Steve"},
            //     new Student(){ Id = 3, Name="Ram"},
            //     new Student(){ Id = 4, Name="Abdul"}
            // };

            //     Console.WriteLine("No of elelemts: " + students.Count);
            //     var details = new List<Test>() {
            //         new Test(){birth = "12-06-2001", sal = 40000},
            //         new Test(){birth = "14-6-2000", sal = 50000}

            //     };
            //     Console.WriteLine(details);
            //     Console.WriteLine("No of elelemts Of Details: " + details.Count);


            //This Is Collections ArrayList
            	// adding elements using ArrayList.Add() method
		var arlist1 = new ArrayList();
		arlist1.Add(1);
		arlist1.Add("Bill");
		arlist1.Add(" ");
		arlist1.Add(true);
		arlist1.Add(4.5);
		arlist1.Add(null);

		// adding elements using object initializer syntax
		var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };
		Console.WriteLine("ArrayList 1 Elements");
		
		for(int i = 0; i< arlist1.Count; i++)
			Console.WriteLine(arlist1[i]);
		
		Console.WriteLine("ArrayList 2 Elements");
		
		for(int i = 0; i< arlist2.Count; i++)
			Console.WriteLine(arlist2[i]);
	


                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Hendling" + e.ToString() + "\n\n");

            }
        }
    }
}

