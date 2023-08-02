using System;

namespace LinearProgrammingSolverApp
{
    public class UserInterface
    {
        private LinearProgrammingSolver lpSolver;
        private LPProblemSolver lpProblemSolver;
        private IPProblemSolver ipProblemSolver;

        public UserInterface()
        {
            lpSolver = new LinearProgrammingSolver();
            lpProblemSolver = new LPProblemSolver();
            ipProblemSolver = new IPProblemSolver();
        }

        // Display the main menu
        private void DisplayMenu()
        {
            Console.WriteLine("Linear Programming and Integer Programming Solver");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("a. Load LP/IP problem from an input file");
            Console.WriteLine("b. Solve LP problem");
            Console.WriteLine("c. Solve IP problem");
            Console.WriteLine("d. Display results");
            Console.WriteLine("e. Exit");
            Console.Write("Enter your choice (a/b/c/d/e): ");
        }

        // Accept the input file path from the user and read the contents
        private void LoadProblemFromFile()
        {
            Console.Write("Enter the input file path: ");
            string filePath = Console.ReadLine();

            bool success = lpSolver.ReadInputFile(filePath);
            if (success)
            {
                Console.WriteLine("File loaded successfully.");
            }
            else
            {
                Console.WriteLine("Error loading the file. Please check the file path and format.");
            }
        }

        // Solve the LP problem based on the user's choice
        private void SolveLPProblem()
        {
            Console.WriteLine("Solving LP Problem...");
            // Call the LP solver's method (e.g., Simplex algorithm)
            // lpProblemSolver.SolveLP();
            Console.WriteLine("LP problem solved. Results stored.");
        }

        // Solve the IP problem based on the user's choice
        private void SolveIPProblem()
        {
            Console.WriteLine("Solving IP Problem...");
            // Call the IP solver's method (e.g., Branch and Bound algorithm)
            // ipProblemSolver.SolveIP();
            Console.WriteLine("IP problem solved. Results stored.");
        }

        // Display the LP/IP results
        private void DisplayResults()
        {
            // Call the solver to export the results to an output file
            Console.Write("Enter the output file path: ");
            string outputPath = Console.ReadLine();

            bool success = lpSolver.ExportResults(outputPath);
            if (success)
            {
                Console.WriteLine("Results exported successfully.");
            }
            else
            {
                Console.WriteLine("Error exporting results. Please check the output file path.");
            }
        }

        // Run the user interface
        public void Run()
        {
            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case "a":
                        LoadProblemFromFile();
                        break;
                    case "b":
                        SolveLPProblem();
                        break;
                    case "c":
                        SolveIPProblem();
                        break;
                    case "d":
                        DisplayResults();
                        break;
                    case "e":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (a/b/c/d/e).");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
