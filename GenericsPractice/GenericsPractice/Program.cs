
using GenericsPractice;
using GenericsPractice.Models;

Console.WriteLine("Hello, World!");

#region Fibonacci
//static void Fibonacci (int n)
//{
//    int a = 1;
//    int b = 1;
//    int c;

//    Console.WriteLine(a);
//    Console.WriteLine(b);

//    for (int i = 2; i < n; i++)
//    {
//        c = a + b; //2 //3 //5 
//        a = b; //1 //2  //3
//        b = c; //2 //3 //5 

//        Console.WriteLine(c);
//    }
//}
//Fibonacci(5);
#endregion

#region Implicit Explicit
//Manat manat = new Manat(200);

//Dollar dollar = manat;
//Console.WriteLine(dollar.Usd);
#endregion

//StringList list1 = new StringList();



//Datalist<string> students=new Datalist<string>();
//students.Add("Roya");
//students.Add("Konul");
//students.Add("Cinare");
//students.GetAll();


//IntList list2 = new IntList();
//list2.Add(1);
//list2.Add(2);
//list2.Add(3);
//list2.GetAll();

//Datalist<int>numbers=new Datalist<int>();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.GetAll();

//StudentList list3 = new StudentList();

//list3.Add(new Student { Id = 1, Name = "Ali" }); //=======// var stu 1=new Student{Id=1,Name="Ali}; anon
//list3.Add(new Student { Id = 2, Name = "Aqshin" });
//list3.Add(new Student { Id = 1, Name = "Elcan" });

/*list3.GetAll()*/

//Datalist<Student> studentlist = new Datalist<Student>();
//studentlist.Add(new Student { Id = 1, Name = "Ali" });
//studentlist.Add(new Student { Id = 2, Name = "Aqshin" });
//studentlist.Add(new Student { Id = 1, Name = "Elcan" });
//studentlist.GetAll();

//List<int>num=new List<int>();
//num.Add(10);
//num.Add(22);
//foreach (var item in num)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i <= num.Count; i++)
//{
//    for (int j = i+1; j <= num.Count-1; j++)
//    {
//        if (num[i] > num[j])
//        {
//            Console.WriteLine("Boyukdur");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Kicikdir");
//        }
//    }
//}
//Repository<Student>student=new Repository<Student>();
//Repository<int> num = new Repository<int>();// struct olduqu ucun ishlemir 
//Repository<string> str = new Repository<string>(); // klass olduquna gore string isleyecek
//Repository<bool> married = new Repository<bool>(); // bool - strucdir. 

Repository<Test1,Test2>data=new Repository<Test1,Test2>();
