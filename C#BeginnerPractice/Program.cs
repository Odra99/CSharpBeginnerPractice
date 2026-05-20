class FilesExercises
{
    public void FirstExercise()
    {
        Console.WriteLine("Exercise 1: Read a file and display the number of words in the file");
        Console.WriteLine("File name: FileExercises.txt");
        string fileName = @"TestFiles\FileExercises.txt";
        if (fileName != null && File.Exists(fileName))
        {
            string fileContents = File.ReadAllText(fileName);
            int wordCount = fileContents.Split(new char[] { ' ', '\t', '\n', '\r','.', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Number of words in the file: {wordCount}");
            Console.WriteLine("File Contents:");
            Console.WriteLine(fileContents);
        }
        else
        {
            Console.WriteLine("File not found. Please verify the FileExercises.txt file exists.");
        }
    }

    public void SecondExercise()
    {
        Console.WriteLine("Exercise 2: Find the longest word in a file");
        Console.WriteLine("File name: FileExercises.txt");
        string fileName = @"TestFiles\FileExercises.txt";
        if (fileName != null && File.Exists(fileName))
        {
            string fileContents = File.ReadAllText(fileName);
            string[] words = fileContents.Split(new char[] { ' ', '\t', '\n', '\r', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"The longest word in the file is: {longestWord}");
        }
        else
        {
            Console.WriteLine("File not found. Please verify the FileExercises.txt file exists.");
        }
    }
}

class StringExercises
{
    public void FirstExercise()
    {
        Console.WriteLine("Exercise 1: Calculate consecutive or non-consecutive numbers in a string");
        Console.Write("Enter a string of numbers separated by hyphens (e.g., 1-2-3-4): ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string[] numberStrings = input.Split('-');
            List<int> numbers = new List<int>();
            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString.Trim(), out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Invalid number: {numberString}. Please enter valid numbers separated by hyphens.");
                    return;
                }
            }
            bool isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (isConsecutive)
            {
                Console.WriteLine("The numbers are consecutive.");
            }
            else
            {
                Console.WriteLine("The numbers are not consecutive.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a string of numbers separated by hyphens.");
        }
    }

    public void SecondExercise()
    {
        Console.WriteLine("Exercise 2: Check for duplicates in a string");
        Console.Write("Enter a string of numbers separated by hyphens (e.g., 1-2-3-4): ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string[] numberStrings = input.Split('-');
            HashSet<string> uniqueNumbers = new HashSet<string>();
            bool hasDuplicates = false;
            foreach (string numberString in numberStrings)
            {
                if (!uniqueNumbers.Add(numberString.Trim()))
                {
                    hasDuplicates = true;
                    break;
                }
            }
            if (hasDuplicates)
            {
                Console.WriteLine("Duplicates found in the string.");
            }
        }
        else
        {
            Console.WriteLine("Exiting");
        }
    }

    public void ThirdExercise()
    {
        Console.WriteLine("Exercise 3: Time format validation");
        Console.Write("Enter a time in 24-hour format (e.g., 14:30): ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            if (TimeSpan.TryParse(input, out TimeSpan time))
            {
                Console.WriteLine("Valid time format.");
            }
            else
            {
                Console.WriteLine("Invalid time format. Please enter a valid time in 24-hour format.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a time in 24-hour format.");
        }
    }

    public void FourthExercise()
    {
        Console.WriteLine("Exercise 4: PascalCase conversion");
        Console.Write("Enter a string with words separated by spaces (e.g., hello world): ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            string pascalCaseString = string.Join("", words);
            Console.WriteLine($"PascalCase: {pascalCaseString}");
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a string with words separated by spaces.");
        }
    }

    public void FifthExercise()
    {
        Console.WriteLine("Exercise 5: Count vowels in a string");
        Console.Write("Enter a string: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            int vowelCount = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a string.");
        }
    }
}

class ArrayANDListExercises
{
    public void FirstExercise()
    {
        Console.WriteLine("Exercise 1: Facebook likes - Create an array of user's names and print them");

        List<string> names = new List<string>();
        while (true)
        {
            Console.Write("Enter a user's name (or empty to finish): ");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            else
            {
                names.Add(input);
            }


        }
        if (names.Count == 1)
        {
            Console.WriteLine($"{names[0]} likes your post.");
        }
        else if (names.Count == 2)
        {
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        }
        else if (names.Count > 2)
        {
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        }
    }

    public void SecondExercise()
    {
        Console.WriteLine("Exercise 2: Reverse the name");
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        if (name != null)
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reversedName = new string(nameArray);
            Console.WriteLine($"Reversed name: {reversedName}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    public void ThirdExercise()
    {
        Console.WriteLine("Exercise 3: Sort a list of 5 unique numbers.");
        Console.WriteLine("Enter 5 unique numbers:");
        List<int> numbers = new List<int>();
        while (numbers.Count < 5)
        {
            Console.Write($"Number {numbers.Count + 1}: ");
            string? input = Console.ReadLine();
            if (input != null && int.TryParse(input, out int number))
            {
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Number already entered, please enter a unique number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
        numbers.Sort();
        Console.WriteLine("Sorted unique numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void FourthExercise()
    {
        Console.WriteLine("Exercise 4: Select unique numbers from a list with duplicates");
        Console.WriteLine("Enter a list of numbers separated by commas (duplicates allowed):");
        string? input = Console.ReadLine();
        if (input != null)
        {
            string[] numberStrings = input.Split(',');
            HashSet<int> uniqueNumbers = new HashSet<int>();
            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString.Trim(), out int number))
                {
                    uniqueNumbers.Add(number);
                }
            }
            Console.WriteLine("Unique numbers:");
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a list of numbers separated by commas.");
        }
    }

    public void FifthExercise()
    {
        Console.WriteLine("Exercise 5: Find the three smallest numbers in a list");
        while (true)
        {
            Console.WriteLine("Enter a list of numbers separated by commas (more than 5 numbers):");
            string? input = Console.ReadLine();
            if (input != null)
            {
                string[] numberStrings = input.Split(',');
                List<int> numbers = new List<int>();
                foreach (string numberString in numberStrings)
                {
                    if (int.TryParse(numberString.Trim(), out int number))
                    {
                        numbers.Add(number);
                    }
                }
                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue;
                }
                numbers.Sort();
                Console.WriteLine("The three smallest numbers are:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a list of numbers separated by commas.");
            }
        }
    }
}

class ControlFlowExercises
{
    public void FirstExercise()
    {
        Console.WriteLine("Exercise 1: How many numbers between 1 and 100 are divisible by 3?");
        int count = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Answer: {count}");
    }

    public void SecondExercise()
    {
        Console.WriteLine("Exercise 2: Sum of user-entered numbers until they enter 'ok'");
        int sum = 0;
        while (true)
        {
            Console.Write("Enter a number (or 'ok' to finish): ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Invalid input, please enter a number or 'ok'.");
                continue;
            }
            if (input.ToLower() == "ok")
            {
                break;
            }
            if (int.TryParse(input, out int number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number or 'ok'.");
            }
        }
        Console.WriteLine($"Sum: {sum}");
    }

    public void ThirdExercise()
    {
        Console.WriteLine("Exercise 3: Calculate the factorial of a number");
        Console.Write("Enter a number to calculate its factorial: ");
        string? factorialInput = Console.ReadLine();
        if (factorialInput != null && int.TryParse(factorialInput, out int factorialNumber) && factorialNumber >= 0)
        {
            long factorialResult = 1;
            for (int i = 1; i <= factorialNumber; i++)
            {
                factorialResult *= i;
            }
            Console.WriteLine($"{factorialNumber}! = {factorialResult}");
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a positive number");
        }
    }

    public void FourthExercise()
    {
        Console.WriteLine("Exercise 4: Guess the number between 1 and 10");
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        Console.Write("Guess the number between 1 and 10: ");
        for (int i = 0; i < 4; i++)
        {
            string? guessInput = Console.ReadLine();
            if (guessInput != null && int.TryParse(guessInput, out int guess))
            {
                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again. Maximum attempts left: " + (3 - i));
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 10.");
            }
        }
    }

    public void FifthExercise()
    {
        Console.WriteLine("Exercise 5: Find the maximum number in a list of numbers");
        Console.Write("Enter a list of numbers separated by commas: ");
        string? numbersInput = Console.ReadLine();
        if (numbersInput != null)
        {
            string[] numberStrings = numbersInput.Split(',');
            int maxNumber = int.MinValue;
            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString.Trim(), out int number))
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
            }
            Console.WriteLine($"The maximum number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a list of numbers separated by commas.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Beginner Practice Exercises - C#");
        Console.WriteLine("Control Flow Exercises:");
        Console.WriteLine("1. Count numbers divisible by 3 between 1 and 100");
        Console.WriteLine("2. Sum of user-entered numbers until 'ok'");
        Console.WriteLine("3. Calculate the factorial of a number");
        Console.WriteLine("4. Guess the number between 1 and 10");
        Console.WriteLine("5. Find the maximum number in a list of numbers");
        Console.WriteLine("Array and List Exercises:");
        Console.WriteLine("6. Facebook likes - Create an array of user's names and print them");
        Console.WriteLine("7. Reverse the name");
        Console.WriteLine("8. Sort a list of 5 unique numbers");
        Console.WriteLine("9. Select unique numbers from a list with duplicates");
        Console.WriteLine("10. Find the three smallest numbers in a list");
        Console.WriteLine("String Exercises:");
        Console.WriteLine("11. Calculate consecutive or non-consecutive numbers in a string");
        Console.WriteLine("12. Check for duplicates in a string");
        Console.WriteLine("13. Time format validation");
        Console.WriteLine("14. PascalCase conversion");
        Console.WriteLine("15. Count vowels in a string");
        Console.WriteLine("Files Exercises:");
        Console.WriteLine("16. Read a file and display the number of words in the file");
        Console.WriteLine("17. Find the longest word in a file");
        Console.Write("Select an exercise to run (1-17): ");


        string? option = Console.ReadLine();
        if (option != null && int.TryParse(option, out int optionNumber))
        {
            ControlFlowExercises exercises = new ControlFlowExercises();
            ArrayANDListExercises arrayExercises = new ArrayANDListExercises();
            StringExercises stringExercises = new StringExercises();
            FilesExercises fileExercises = new FilesExercises();
            switch (optionNumber)
            {
                case 1:
                    exercises.FirstExercise();
                    break;
                case 2:
                    exercises.SecondExercise();
                    break;
                case 3:
                    exercises.ThirdExercise();
                    break;
                case 4:
                    exercises.FourthExercise();
                    break;
                case 5:
                    exercises.FifthExercise();
                    break;
                case 6:
                    arrayExercises.FirstExercise();
                    break;
                case 7:
                    arrayExercises.SecondExercise();
                    break;
                case 8:
                    arrayExercises.ThirdExercise();
                    break;
                case 9:
                    arrayExercises.FourthExercise();
                    break;
                case 10:
                    arrayExercises.FifthExercise();
                    break;
                case 11:
                    stringExercises.FirstExercise();
                    break;
                case 12:
                    stringExercises.SecondExercise();
                    break;
                case 13:
                    stringExercises.ThirdExercise();
                    break;
                case 14:
                    stringExercises.FourthExercise();
                    break;
                case 15:
                    stringExercises.FifthExercise();
                    break;
                case 16:
                    fileExercises.FirstExercise();
                    break;
                case 17:
                    fileExercises.SecondExercise();
                    break;
                default:
                    Console.WriteLine("Invalid option, please select a number between 1 and 17.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a number between 1 and 17.");
        }
    }
}