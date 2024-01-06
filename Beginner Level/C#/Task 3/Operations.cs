namespace TaskThree
{
    public class Operations
    {
        List<PhoneBook> phoneBook = new List<PhoneBook>
        {
            new PhoneBook { Name = "Bedirhan", Surname = "Erkılıç", Phone = "596 886 6677"},
            new PhoneBook { Name = "Arda", Surname = "Yılmaz", Phone = "532 333 16757"},
            new PhoneBook { Name = "Ayla", Surname = "Ünlü", Phone = "512 287 3259"},
            new PhoneBook { Name = "Ayşe", Surname = "Güneş", Phone = "526 796 1635"},
            new PhoneBook { Name = "Deniz", Surname = "Orta", Phone = "572 391 2680"}
        };

        public void AskOperation()
        {
            Console.WriteLine("Please select the operation you want to perform.");
            Console.WriteLine("************************************************");

            Console.WriteLine("(1) Register a New Number (2) Delete an Existing Number (3) Update an Existing Number (4) List Phone Book (5) Search in Phone Book\n");

            Console.Write("Operation: ");

            byte selectedOperation;
            do
            {
                bool isOperationsExist = byte.TryParse(Console.ReadLine(), out selectedOperation);
                if (isOperationsExist == true)
                {
                    if (selectedOperation <= 0 || selectedOperation > 5)
                    {
                        Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                        Console.Write("Operation: ");
                        selectedOperation = 0;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                    Console.Write("Operation: ");
                }
            }
            while (selectedOperation <= 0);

            Console.WriteLine("\r");

            if (selectedOperation == 1)
                Add();
            else if (selectedOperation == 2)
                Delete();
            else if (selectedOperation == 3)
                Update();
            else if (selectedOperation == 4)
                List();
            else if (selectedOperation == 5)
                Search();
        }

        public void Add()
        {
            Console.WriteLine("Register a New Number\n");

            string name;
            do
            {
                Console.Write("Name: ");
                name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(name))
                    Console.WriteLine("The name cannot be blank, enter it again.");
            }
            while (String.IsNullOrWhiteSpace(name));

            string surname;
            do
            {
                Console.Write("Surname: ");
                surname = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(surname))
                    Console.WriteLine("The surname cannot be blank, enter it again.");
            }
            while (String.IsNullOrWhiteSpace(surname));

            string phone;
            do
            {
                Console.Write("Phone: ");
                phone = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(phone))
                    Console.WriteLine("The phone cannot be blank, enter it again.");
            }
            while (String.IsNullOrWhiteSpace(phone));

            PhoneBook item = new PhoneBook();
            item.Name = name.Trim();
            item.Surname = surname.Trim();
            item.Phone = phone.Trim();
            phoneBook.Add(item);

            Console.WriteLine("\r");

            Console.WriteLine("The new contact was successfully added to the phone book.\n");

            AskOperation();
        }

        public void Delete()
        {
            Console.WriteLine("Delete an Existing Number\n");

            string value;
            do
            {
                Console.Write("Please enter the name or surname of the person whose phone number you want to delete: ");
                value = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(value))
                    Console.WriteLine("You entered a blank value, please enter it again.");
            }
            while (String.IsNullOrWhiteSpace(value));

            PhoneBook contact = phoneBook.Where(x => x.Name == value.Trim() || x.Surname == value.Trim()).FirstOrDefault();

            Console.WriteLine("\r");

            if (contact == null)
            {
                Console.WriteLine("The data matching the criteria you are looking for was not found in the phone book. Please make a selection again.");
                Console.WriteLine("* To terminate the deletion : (1)");
                Console.WriteLine("* To retry : (2)\n");

                Console.Write("Operation: ");

                byte selectedOperation;
                do
                {
                    bool isOperationsExist = byte.TryParse(Console.ReadLine(), out selectedOperation);
                    if (isOperationsExist == true)
                    {
                        if (selectedOperation <= 0 || selectedOperation > 2)
                        {
                            Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                            Console.Write("Operation: ");
                            selectedOperation = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                        Console.Write("Operation: ");
                    }
                }
                while (selectedOperation <= 0);

                Console.WriteLine("\r");

                if (selectedOperation == 1)
                    AskOperation();
                else if (selectedOperation == 2)
                    Delete();
            }
            else
            {
                Console.WriteLine("The person named {0} is about to be deleted from the phone book, do you approve ?(y/n)", contact.Name + " " + contact.Surname);

                string answer;
                do
                {
                    answer = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(answer))
                    {
                        Console.WriteLine("The answer cannot be blank, enter it again.");
                        continue;
                    }

                    if (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("The answer cannot be blank, enter it again.");
                        answer = "";
                    }
                }
                while (String.IsNullOrWhiteSpace(answer));

                if (answer == "y")
                    phoneBook.Remove(contact);
            }

            Console.WriteLine("\r");
            AskOperation();
        }

        public void Update()
        {
            Console.WriteLine("Update an Existing Number\n");

            string value;
            do
            {
                Console.Write("Please enter the name or surname of the person you want to update: ");
                value = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(value))
                    Console.WriteLine("You entered a blank value, please enter it again.");
            }
            while (String.IsNullOrWhiteSpace(value));

            PhoneBook contact = phoneBook.Where(x => x.Name == value.Trim() || x.Surname == value.Trim()).FirstOrDefault();

            Console.WriteLine("\r");

            if (contact == null)
            {
                Console.WriteLine("The data matching the criteria you are looking for was not found in the phone book. Please make a selection again.");
                Console.WriteLine("* To terminate the update : (1)");
                Console.WriteLine("* To retry : (2)\n");

                Console.Write("Operation: ");

                byte selectedOperation;
                do
                {
                    bool isOperationsExist = byte.TryParse(Console.ReadLine(), out selectedOperation);
                    if (isOperationsExist == true)
                    {
                        if (selectedOperation <= 0 || selectedOperation > 2)
                        {
                            Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                            Console.Write("Operation: ");
                            selectedOperation = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                        Console.Write("Operation: ");
                    }
                }
                while (selectedOperation <= 0);

                Console.WriteLine("\r");

                if (selectedOperation == 1)
                    AskOperation();
                else if (selectedOperation == 2)
                    Update();
            }
            else
            {
                Console.WriteLine("Details of the person found: Name: {0} - Surname: {1} - Phone: {2}", contact.Name, contact.Surname, contact.Phone);

                string name;
                do
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(name))
                        Console.WriteLine("The name cannot be blank, enter it again.");
                }
                while (String.IsNullOrWhiteSpace(name));

                string surname;
                do
                {
                    Console.Write("Surname: ");
                    surname = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(surname))
                        Console.WriteLine("The surname cannot be blank, enter it again.");
                }
                while (String.IsNullOrWhiteSpace(surname));

                string phone;
                do
                {
                    Console.Write("Phone: ");
                    phone = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(phone))
                        Console.WriteLine("The phone cannot be blank, enter it again.");
                }
                while (String.IsNullOrWhiteSpace(phone));

                contact.Name = name.Trim();
                contact.Surname = surname.Trim();
                contact.Phone = phone.Trim();

                Console.WriteLine("\r");

                Console.WriteLine("Contact successfully updated.\n");
            }

            AskOperation();
        }

        public void List()
        {
            Console.WriteLine("List Phone Book\n");

            Console.WriteLine("Which one would you like to list according to?");
            Console.WriteLine("* A-Z : (1)");
            Console.WriteLine("* Z-A : (2)\n");

            Console.Write("Operation: ");

            byte selectedOperation;
            do
            {
                bool isOperationsExist = byte.TryParse(Console.ReadLine(), out selectedOperation);
                if (isOperationsExist == true)
                {
                    if (selectedOperation <= 0 || selectedOperation > 2)
                    {
                        Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                        Console.Write("Operation: ");
                        selectedOperation = 0;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                    Console.Write("Operation: ");
                }
            }
            while (selectedOperation <= 0);

            if (phoneBook != null && phoneBook.Count > 0)
            {
                int counter = 1;
                if (selectedOperation == 1)
                {
                    foreach (var item in phoneBook.OrderBy(x=>x.Name))
                    {
                        Console.WriteLine("{0}. Name: {1} - Surname: {2} - Phone: {3}",
                            counter,
                            item.Name,
                            item.Surname,
                            item.Phone);
                        counter++;
                    }
                }
                else if (selectedOperation == 2)
                {
                    foreach (var item in phoneBook.OrderByDescending(x=>x.Name))
                    {
                        Console.WriteLine("{0}. Name: {1} - Surname: {2} - Phone: {3}",
                            counter,
                            item.Name,
                            item.Surname,
                            item.Phone);
                        counter++;
                    }
                }
            }
            else
                Console.WriteLine("The phone book is empty.");

            Console.WriteLine("\r");
            AskOperation();
        }

        public void Search()
        {
            Console.WriteLine("Search in Phone Book\n");

            Console.WriteLine("Select the type you want to search.");
            Console.WriteLine("* To search by name or surname  : (1)");
            Console.WriteLine("* To search by phone            : (2)\n");

            Console.Write("Operation: ");

            string value = "";
            List<PhoneBook> list = new List<PhoneBook>();
            byte selectedOperation;
            do
            {
                bool isOperationsExist = byte.TryParse(Console.ReadLine(), out selectedOperation);
                if (isOperationsExist == true)
                {
                    if (selectedOperation <= 0 || selectedOperation > 2)
                    {
                        Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                        Console.Write("Operation: ");
                        selectedOperation = 0;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: The selected operation was not found. Please select an operation again.");
                    Console.Write("Operation: ");
                }
            }
            while (selectedOperation <= 0);

            Console.WriteLine("\r");

            if (selectedOperation == 1)
            {
                do
                {
                    Console.Write("Please enter the name or surname of the person you want to search for: ");
                    value = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(value))
                        Console.WriteLine("You entered a blank value, please enter it again.");
                }
                while (String.IsNullOrWhiteSpace(value));

                list = phoneBook.Where(x => x.Name == value || x.Surname == value).ToList();
            }
            else if (selectedOperation == 2)
            {
                do
                {
                    Console.Write("Please enter the phone of the person you want to search for: ");
                    value = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(value))
                        Console.WriteLine("You entered a blank value, please enter it again.");
                }
                while (String.IsNullOrWhiteSpace(value));

                list = phoneBook.Where(x => x.Phone == value).ToList();
            }

            Console.WriteLine("\r");

            if (list != null && list.Count > 0)
            {
                int counter = 1;
                foreach (var item in list)
                {
                    Console.WriteLine("{0}. Name: {1} - Surname: {2} - Phone: {3}",
                        counter,
                        item.Name,
                        item.Surname,
                        item.Phone);
                    counter++;
                }
            }
            else
                Console.WriteLine("No contacts were found according to your search criteria.");

            Console.WriteLine("\r");
            AskOperation();
        }
    }
}