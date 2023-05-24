using HW4;

CreateUsers createUsers = new CreateUsers();
ShowUser showUser = new ShowUser();
DeleteUser deleteUser = new DeleteUser();
validation valid = new validation();
bool flag;
string option = "";
string username = "";
string Name = "";
int id = 0;
string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
long mobile;
long Mobile;
DateTime birthdate;
DateTime Birhdate;
do
{
    Console.WriteLine("\n 1.AddUser \n 2.DeleteUser \n 3.List of Users \n 4.Update \n 5.Exit");
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
            var vlids = valid.newUser(mobile,birthdate);
            if(vlids == true)
            {
                var stat = createUsers.AddUser(username, mobile, birthdate);
                if (stat == true)
                {
                    Console.WriteLine("Add User Successfully");
                }
                else
                {
                    Console.WriteLine("Add User Error");
                }
            }
            break;

        case "2":
            Console.Clear();
            showUser.showlist(path);
            Console.WriteLine(" What Is Your User Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            var del = deleteUser.delete(id);
            if (del == true) 
            {
                Console.WriteLine("Delete User Successfully");
            }
            else
            {
                Console.WriteLine("Delete Error");
            }
            break;
        case "3":
            Console.Clear();
            var sh = showUser.showlist(path);
            foreach(var item in sh)
            {
                Console.WriteLine(item);
            }
            break;

            case "4":
                Console.Clear();
            Console.WriteLine("id?");
            int validid;
            validid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name?");
           Name = Console.ReadLine();
            Console.WriteLine("Bithdate?");
            Birhdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Mobile?");
            Mobile = Convert.ToInt64(Console.ReadLine());
            UpdateUser ups = new UpdateUser();
            ups.updateuser(id ,Name,Birhdate,Mobile);
            break;
        case "5":
            Console.Clear();

            flag = false;
            break;

        default:
            Console.Clear();

            Console.WriteLine("Error: Please give a number between 1 and 5!");
            flag = false;
            break;
    }
  
} while (option != "4");

Console.WriteLine("GoodBye :)\n");
