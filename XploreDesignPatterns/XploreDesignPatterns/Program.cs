namespace XploreDesignPatterns {
    internal class Program {
        public void Main(string[] args) {
            string type = Console.ReadLine();
            Inter obj = CreateObj.Generate(type);
            Console.WriteLine(obj.GetName());
        }
    }
}

public class CreateObj {
    public static Inter Generate(string type) {
        Inter obj = null;
        if (type?.ToLower() == "teacher") {
            obj = new Teacher();
        } else {
            obj = new Student();
        }
        return obj;
    }
}

public interface Inter {
    string GetName();
    string GetDepartment();
}

public class Teacher : Inter {

    public string GetName() {
        return "Teacher Name is Name";
    }
    public string GetDepartment() {
        return "Teacher Department is Chemistry";
    }
}

public class Student : Inter {
    public string GetName() {
        return "Student Name is RKS";
    }
    public string GetDepartment() {
        return "Student Department is Chemistry";
    }

    public interface IPlatform {
        void Create();
    }

    public class Android : IPlatform {
        public void Create() {
            Console.WriteLine("Customer ordered for Andriod");
            Console.WriteLine("Contacing Google Manufacturer");
            Console.WriteLine("Accepted and preparing your order");
            Console.WriteLine("Prepared and Delivered");
        }
    }

    public class iOS : IPlatform {
        private string age { get; set; }
        public void Create() {
            Console.WriteLine("Customer ordered for iOS");
            Console.WriteLine("Contacing Apple Manufacturer");
            Console.WriteLine("Accepted and preparing your order");
            Console.WriteLine("Prepared and Delivered");
        }
    }
    public class Samsung : IPlatform {
        public void Create() {
            Console.WriteLine("Customer ordered for Tizen");
            Console.WriteLine("Contacing Samsung Manufacturer");
            Console.WriteLine("Accepted and preparing your order");
            Console.WriteLine("Prepared and Delivered");
        }
    }
    public class Haeuwei : IPlatform {
        public void Create() {
            Console.WriteLine("Customer ordered for Harmony");
            Console.WriteLine("Contacing Haeuwei Manufacturer");
            Console.WriteLine("Accepted and preparing your order");
            Console.WriteLine("Prepared and Delivered");
        }
    }

    public static class SimpleFactory {
        public static IPlatform Create(string type) {
            switch (type.ToLower()) {
                case "andriod":
                    return new Android();
                case "ios":
                    return new iOS();
                case "tizen":
                    return new Samsung();
                case "harmony":
                    return new Haeuwei();
                default:
                    return null;
            }
        }
    }

    public void Main(String[] args) {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Please enter your platform:");
        IPlatform platform = SimpleFactory.Create(Console.ReadLine());
        platform?.Create();
        Console.ResetColor();
    }

}
