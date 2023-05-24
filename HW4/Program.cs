using HW4;

CreateUsers createUsers = new CreateUsers();
bool flag;
string option = "";
string username = "";
long mobile;
DateTime birthdate;
do
{
    Console.WriteLine("\n 1.AddUser \n 2.DeleteUser \n 3.List of Users \n 4.Exit");
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.Write("UserName :");
            username = Console.ReadLine();
            Console.Write("Mobile :");
            mobile = Convert.ToInt32(Console.ReadLine());
            Console.Write("Birthdate :");
            birthdate = Convert.ToDateTime(Console.ReadLine());
           var stat =  createUsers.AddUser(username, mobile,birthdate);
            if (stat == true)
            {
                Console.WriteLine("Add User Successfully");
            }
            else {
                Console.WriteLine("Add User Error");
                    }
            break;

        case "2":
            Console.Clear();
            createUsers.ShowUser();
            Console.WriteLine(" What Is Your User Name: ");
            username = Console.ReadLine();
            createUsers.DeleteUser(username);
            break;
        case "3":
            Console.Clear();
            createUsers.ShowUser();
            break;

        case "4":
            Console.Clear();

            flag = false;
            break;

        default:
            Console.Clear();

            Console.WriteLine("Error: Please give a number between 1 and 4!");
            flag = false;
            break;
    }
  
} while (option != "4");

Console.WriteLine("GoodBye :)\n");
