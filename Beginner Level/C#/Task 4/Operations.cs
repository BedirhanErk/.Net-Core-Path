namespace TaskFour
{
    public class Operations
    {
        List<User> users = new List<User>
        {
            new User { UserId = 1, Name = "Bedirhan", Surname = "Erkılıç"},
            new User { UserId = 2, Name = "Hakkı", Surname = "Ak"},
            new User { UserId = 3, Name = "Rüstem", Surname = "Uzun"},
            new User { UserId = 4, Name = "İrem", Surname = "Bakmaz"},
            new User { UserId = 5, Name = "Ali", Surname = "Uçar"}
        };

        List<Board> boards = new List<Board>
        {
            new Board { Title = "Coffee", Content = "Make a cup of coffee.", UserId = 1, Size = Sizes.XS, Line = Lines.TODO },
            new Board { Title = "Dog", Content = "Take Bentley for a walk.", UserId = 2, Size = Sizes.S, Line = Lines.TODO },
            new Board { Title = "Read", Content = "Read one chapter of book.", UserId = 3, Size = Sizes.M, Line = Lines.DONE },
        };      

        public void AskOperation()
        {
            Console.WriteLine("Please select the operation you want to perform.");
            Console.WriteLine("************************************************");

            Console.WriteLine("(1) List Board (2) Add Card (3) Delete Card (4) Move the Card to Another Process (5) Update Card\n");  

            byte operation;
            do
            {
                Console.Write("Operation: "); 

                bool isOperationExist = byte.TryParse(Console.ReadLine(), out operation);
                if(isOperationExist == true)
                {
                    if(operation <= 0 || operation > 5)
                    {
                        Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                        operation = 0;
                    }
                }
                else
                    Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
            }
            while(operation <= 0);

            Console.WriteLine("\r");

            if(operation == 1)
                List();
            else if(operation == 2)
                Add();
            else if(operation == 3)
                Delete();
            else if(operation == 4)
                Move();  
            else if(operation == 5)
                Update();                                                
        }

        public void List()
        {
            List<Board> todos = boards.Where(x=>x.Line == Lines.TODO).ToList();
            Console.WriteLine("TODO Line");            
            Console.WriteLine("************************");      
            if(todos != null && todos.Count > 0)
            {
                foreach (var item in todos)
                {
                    Console.WriteLine("Title     : {0}", item.Title);
                    Console.WriteLine("Content   : {0}", item.Content);
                    Console.WriteLine("User      : {0}", users.Where(x=>x.UserId == item.UserId).Select(x=>x.Name + " " + x.Surname).FirstOrDefault());
                    Console.WriteLine("Size      : {0}", item.Size);

                    if(todos.Last() != item)
                        Console.WriteLine("\r");
                }
            }      
            else
                Console.WriteLine("~ EMPTY ~");

            Console.WriteLine("\r\r");

            List<Board> progress = boards.Where(x=>x.Line == Lines.INPROGRESS).ToList();
            Console.WriteLine("IN PROGRESS Line");            
            Console.WriteLine("************************");      
            if(progress != null && progress.Count > 0)
            {
                foreach (var item in progress)
                {
                    Console.WriteLine("Title     : {0}", item.Title);
                    Console.WriteLine("Content   : {0}", item.Content);
                    Console.WriteLine("User      : {0}", users.Where(x=>x.UserId == item.UserId).Select(x=>x.Name + " " + x.Surname).FirstOrDefault());
                    Console.WriteLine("Size      : {0}", item.Size);

                    if(progress.Last() != item)
                        Console.WriteLine("\r");                    
                }
            }      
            else
                Console.WriteLine("~ EMPTY ~");

            Console.WriteLine("\r\r");                

            List<Board> dones = boards.Where(x=>x.Line == Lines.DONE).ToList();
            Console.WriteLine("DONE Line");            
            Console.WriteLine("************************");      
            if(dones != null && dones.Count > 0)
            {
                foreach (var item in dones)
                {
                    Console.WriteLine("Title     : {0}", item.Title);
                    Console.WriteLine("Content   : {0}", item.Content);
                    Console.WriteLine("User      : {0}", users.Where(x=>x.UserId == item.UserId).Select(x=>x.Name + " " + x.Surname).FirstOrDefault());
                    Console.WriteLine("Size      : {0}", item.Size);

                    if(dones.Last() != item)
                        Console.WriteLine("\r");                        
                }
            }      
            else
                Console.WriteLine("~ EMPTY ~");   

            Console.WriteLine("\r");
            AskOperation();                             
        }

        public void Add()
        {
            Console.WriteLine("Add Card\n");

            string title;
            do
            {
                Console.Write("Title: ");
                title = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(title))
                    Console.WriteLine("ERROR: The title cannot be blank, enter it again.");
            }
            while(String.IsNullOrWhiteSpace(title));

            string content;
            do
            {
                Console.Write("Content: ");
                content = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(content))
                    Console.WriteLine("ERROR: The content cannot be blank, enter it again.");
            }
            while(String.IsNullOrWhiteSpace(content)); 

            Sizes size;
            do
            {
                Console.Write("Size -> XS(1), S(2), M(3), L(4), XL(5): ");
                bool isSizeExist = Sizes.TryParse(Console.ReadLine(), out size);
                if(isSizeExist == true)
                {
                    if((int)size <= 0 || (int)size > 5)
                    {
                        Console.WriteLine("ERROR: The size you selected was not found. Please try again.");
                        size = 0;
                    }
                }
                else
                    Console.WriteLine("ERROR: The size you selected was not found. Please try again.");
            }
            while((int)size <= 0);     

            int userId;
            do
            {
                Console.Write("User: "); 

                bool isValueExist = int.TryParse(Console.ReadLine(), out userId);
                if(isValueExist == true)
                {
                    if(userId <= 0 || userId > users.Count)
                    {
                        Console.WriteLine("ERROR: Please enter the id of the user.");
                        userId = 0;
                        continue;
                    }

                    if(users.Where(x=>x.UserId == userId).FirstOrDefault() == null)
                    {
                        Console.WriteLine("ERROR: User not found. Try again.");
                        userId = 0;
                    }
                }
                else
                    Console.WriteLine("ERROR: Please enter the id of the user.");
            }
            while(userId <= 0);     

            Console.WriteLine("\r");            

            Board board = new Board();
            board.Title = title.Trim();
            board.Content = content.Trim();
            board.Size = size;
            board.UserId = userId;
            board.Line = Lines.TODO;     
            boards.Add(board);          

            Console.WriteLine("The card was successfully added.\n");         
            AskOperation();   
        }  

        public void Delete()
        {
            Console.WriteLine("Delete Card\n");

            Console.WriteLine("INFO: Firstly, you need to select the card you want to delete.");

            string title;
            do
            {
                Console.Write("Title: ");
                title = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(title))
                    Console.WriteLine("ERROR: The title cannot be blank, enter it again.");
            }
            while(String.IsNullOrWhiteSpace(title));

            Console.WriteLine("\r");

            List<Board> cards = boards.Where(x=>x.Title == title.Trim()).ToList();

            if(cards != null && cards.Count > 0)
            {
                foreach (var item in cards)
                {
                    boards.Remove(item);
                }

                Console.WriteLine("The card successfully deleted.\n"); 

                AskOperation();
            }
            else
            {
                Console.WriteLine("No cards matching the criteria you are looking for were found on the board. Please make a selection.");
                Console.WriteLine("* To end the deletion : (1)");
                Console.WriteLine("* To retry : (2)\n");

                byte operation;
                do
                {
                    Console.Write("Operation: "); 

                    bool isOperationExist = byte.TryParse(Console.ReadLine(), out operation);
                    if(isOperationExist == true)
                    {
                        if(operation <= 0 || operation > 2)
                        {
                            Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                            operation = 0;
                        }
                    }
                    else
                        Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                }
                while(operation <= 0);        

                Console.WriteLine("\r");

                if(operation == 1)
                    AskOperation();
                else if(operation == 2)   
                    Delete();     
            }
        } 

        public void Move()
        {
            Console.WriteLine("Move the Card to Another Process\n");

            Console.WriteLine("INFO: Firstly, you need to select the card you want to move.");

            string title;
            do
            {
                Console.Write("Title: ");
                title = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(title))
                    Console.WriteLine("ERROR: The title cannot be blank, enter it again.");
            }
            while(String.IsNullOrWhiteSpace(title));

            Console.WriteLine("\r");

            Board card = boards.Where(x=>x.Title == title.Trim()).FirstOrDefault();

            if(card != null)
            {
                Console.WriteLine("Card Details: Title: {0} - Content: {1} - User: {2} - Size: {3} - Line. {4}", card.Title, card.Content, users.Where(x=>x.UserId == card.UserId).Select(x=>x.Name + " " + x.Surname).FirstOrDefault(), card.Size, card.Line);

                Console.WriteLine("Please select the Line you want to move: (1) TODO (2) IN PROGRESS (3) DONE\n");

                byte operation;
                do
                {
                    Console.Write("Operation: "); 

                    bool isOperationExist = byte.TryParse(Console.ReadLine(), out operation);
                    if(isOperationExist == true)
                    {
                        if(operation <= 0 || operation > 3)
                        {
                            Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                            operation = 0;
                        }
                    }
                    else
                        Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                }
                while(operation <= 0);       

                card.Line = (Lines)operation;

                Console.WriteLine("\r"); 

                Console.WriteLine("The card successfully moved.\n"); 

                AskOperation();                 
            }   
            else
            {
                Console.WriteLine("No cards matching the criteria you are looking for were found on the board. Please make a selection.");
                Console.WriteLine("* To finalise the process : (1)");
                Console.WriteLine("* To retry : (2)\n");

                byte operation;
                do
                {
                    Console.Write("Operation: "); 

                    bool isOperationExist = byte.TryParse(Console.ReadLine(), out operation);
                    if(isOperationExist == true)
                    {
                        if(operation <= 0 || operation > 2)
                        {
                            Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                            operation = 0;
                        }
                    }
                    else
                        Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                }
                while(operation <= 0);        

                Console.WriteLine("\r");

                if(operation == 1)
                    AskOperation();
                else if(operation == 2)   
                    Move();                     
            }                    
        } 

        public void Update()
        {
            Console.WriteLine("Update Card\n");

            Console.WriteLine("INFO: Firstly, you need to select the card you want to update.");

            string title;
            do
            {
                Console.Write("Title: ");
                title = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(title))
                    Console.WriteLine("ERROR: The title cannot be blank, enter it again.");
            }
            while(String.IsNullOrWhiteSpace(title));

            Console.WriteLine("\r");

            Board card = boards.Where(x=>x.Title == title.Trim()).FirstOrDefault();

            if(card != null)
            {
                string updTitle;
                do
                {
                    Console.Write("Title: ");
                    updTitle = Console.ReadLine();

                    if(String.IsNullOrWhiteSpace(updTitle))
                        Console.WriteLine("ERROR: The title cannot be blank, enter it again.");
                }
                while(String.IsNullOrWhiteSpace(updTitle));

                string content;
                do
                {
                    Console.Write("Content: ");
                    content = Console.ReadLine();

                    if(String.IsNullOrWhiteSpace(content))
                        Console.WriteLine("ERROR: The content cannot be blank, enter it again.");
                }
                while(String.IsNullOrWhiteSpace(content)); 

                Sizes size;
                do
                {
                    Console.Write("Size -> XS(1), S(2), M(3), L(4), XL(5): ");
                    bool isSizeExist = Sizes.TryParse(Console.ReadLine(), out size);
                    if(isSizeExist == true)
                    {
                        if((int)size <= 0 || (int)size > 5)
                        {
                            Console.WriteLine("ERROR: The size you selected was not found. Please try again.");
                            size = 0;
                        }
                    }
                    else
                        Console.WriteLine("ERROR: The size you selected was not found. Please try again.");
                }
                while((int)size <= 0);     

                int userId;
                do
                {
                    Console.Write("User: "); 

                    bool isValueExist = int.TryParse(Console.ReadLine(), out userId);
                    if(isValueExist == true)
                    {
                        if(userId <= 0 || userId > users.Count)
                        {
                            Console.WriteLine("ERROR: Please enter the id of the user.");
                            userId = 0;
                            continue;
                        }

                        if(users.Where(x=>x.UserId == userId).FirstOrDefault() == null)
                        {
                            Console.WriteLine("ERROR: User not found. Try again.");
                            userId = 0;
                        }
                    }
                    else
                        Console.WriteLine("ERROR: Please enter the id of the user.");
                }
                while(userId <= 0);     

                Console.WriteLine("\r");            

                card.Title = updTitle.Trim();
                card.Content = content.Trim();
                card.Size = size;
                card.UserId = userId;            

                Console.WriteLine("The card successfully updated.\n"); 

                AskOperation();
            }   
            else
            {
                Console.WriteLine("No cards matching the criteria you are looking for were found on the board. Please make a selection.");
                Console.WriteLine("* To finalise the process : (1)");
                Console.WriteLine("* To retry : (2)\n");

                byte operation;
                do
                {
                    Console.Write("Operation: "); 

                    bool isOperationExist = byte.TryParse(Console.ReadLine(), out operation);
                    if(isOperationExist == true)
                    {
                        if(operation <= 0 || operation > 2)
                        {
                            Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                            operation = 0;
                        }
                    }
                    else
                        Console.WriteLine("ERROR: The operation you wanted to perform was not found. Please try again.");
                }
                while(operation <= 0);        

                Console.WriteLine("\r");

                if(operation == 1)
                    AskOperation();
                else if(operation == 2)   
                    Update();   
            }         
        }                                       
    }
}