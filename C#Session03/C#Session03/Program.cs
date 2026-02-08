namespace C_Session03
{
    public class Rectangle
    {
        //1.3  Ex: The Rectangle Class
        private float _length;
        private float _width;
        public Rectangle()
        {
            _length = 0;
            _width = 0;
        }
        public Rectangle(float length, float width)
        {
            _length = length;
            _width = width;
        }
        public float Length
        {
            get { return _length; }
            set { if(_length >= 0)
                    _length = value; }

        }
        public float Width
        {
            get { return _width; }
            set { if(_width >= 0)
                    _width = value;
            }
        }

        public double Area()
        {
            return _length * _width;
        }
        public double Perimeter()
        {
            return 2 * (_length + _width);
        }
         public string toString()
        {
            return $"Length: {_length}, Width: {_width}, Area: {Area()}, Perimeter: {Perimeter()}";
        }
    }
    public class InvoiceItem 
    {
        //1.5  Ex: The InvoiceItem Class
        private string _id;
        private string _description;
        private int _quantity;
        private decimal _unitPrice;

        public InvoiceItem(string id, string description, int quantity, decimal unitPrice)
        {
            _id = id;
            _description = description;
            _quantity = quantity;
            _unitPrice = unitPrice;
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { if(_quantity >= 0)
                    _quantity = value; }
        }
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { if(_unitPrice >= 0)
                    _unitPrice = value; }
        }
        public decimal TotalPrice()
        {
            return _quantity * _unitPrice;
        }
        public string toString()
        {
            return $"ID: {_id}, Description: {_description}, Quantity: {_quantity}, Unit Price: {_unitPrice}, Total Price: {TotalPrice()}";
        }

        }
    public class  Account
    {
        //1.6  Ex: The Account Class
        private string _id;
        private string _name;
        private int _balance = 0;

        public Account(string id, string name)
        {
            _id = id;
            _name = name;
        }
        public Account(string id, string name, int balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }
        public string Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int Balance
        {
            get { return _balance; }
        }
        public void Credit(int amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }
        public void Debit(int amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
        }
        public int TransferTo(Account another, int amount)
        {
            if (another._balance >= amount && amount > 0)
            {
                another._balance -= amount;
                this._balance += amount;
            }
            else
            {
                Console.WriteLine("Transfer failed: Insufficient balance or invalid amount.");
            }
            return this._balance;
        }
        public string toString()
        {
            return $"ID: {_id}, Name: {_name}, Balance: {_balance}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Palindrom or not ?=====");
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            string reversedStr="";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            if (str == reversedStr)
            {
                Console.WriteLine($"'{str}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{str}' is not a palindrome.");
            }
            Console.WriteLine("=================================");


            Console.WriteLine("===== Anagram or not ?=====");
            Console.Write("Enter first string : ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string : ");
            string str2 = Console.ReadLine();
            char[] sortedarr1 = new char[str1.Length];
            char[] sortedarr2 = new char[str2.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                sortedarr1[i] = str1[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                sortedarr2[i] = str2[i];
            }
            Array.Sort(sortedarr1);
            Array.Sort(sortedarr2);

            string sortedStr1 =Convert.ToString(sortedarr1);
            string sortedStr2 = Convert.ToString(sortedarr2);

           
            if (sortedStr1 == sortedStr2)
            {
                Console.WriteLine($"'{str1}' and '{str2}' are anagrams.");
            }
            else
            {
                Console.WriteLine($"'{str1}' and '{str2}' are not anagrams.");
            }
            Console.WriteLine("=================================");
            Console.WriteLine("===== add 100 numbers in list and find sum and  find even number and odd number =====");
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                int randomNumber = new Random().Next(1, 101);
                numbers.Add(randomNumber);
            }
            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");

            List<int> evenNumbers =new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenNumbers.Add(num);
                else
                    oddNumbers.Add(num);
            }
            Console.Write("Even numbers:");
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.Write("Odd numbers:");
            Console.WriteLine(string.Join(", ", oddNumbers));

            Console.WriteLine("=================================");
            Console.WriteLine("===== Rectangle Class =====");
            Rectangle rect1 = new Rectangle(5, 3);
            Console.WriteLine(rect1.toString());

            Console.WriteLine("=================================");
            Console.WriteLine("===== InvoiceItem Class =====");
            InvoiceItem item1 = new InvoiceItem("001", "Laptop", 2, 1500.00m);
            Console.WriteLine(item1.toString());


            Console.WriteLine("=================================");
            Console.WriteLine("===== Account Class =====");
            Account acc1 = new Account("A001", "John Doe", 1000);
            Account acc2 = new Account("A002", "Jane Smith", 500);

            Console.WriteLine(acc1.toString());
            Console.WriteLine(acc2.toString());
            acc1.Credit(200);
            Console.WriteLine("After crediting $200 to John Doe's account:");
            Console.WriteLine(acc1.toString());
            acc1.Debit(100);
            Console.WriteLine("After debiting $100 from John Doe's account:");
            Console.WriteLine(acc1.toString());
            acc2.TransferTo(acc1, 300);
            Console.WriteLine("After transferring $300 from John Doe's account to Jane Smith's account:");
            Console.WriteLine(acc1.toString());
            Console.WriteLine(acc2.toString());
            Console.WriteLine("=================================");
        }
    }
}