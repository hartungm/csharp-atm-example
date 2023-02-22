main();

// Main is the controller function for the program
static void main() {
    Double checking = 4000.50;
    Double savings = 30000.69;
    Boolean exit = false;

    while (!exit) {
        Console.WriteLine("Hello customr, would you like to:\n1. Withdraw Money\n2. Deposit Money\n3. Check Balance\n4. Exit");

        // This bit here is getting the answer from the user and breaking it into something that makes sense to be used, our choice
        int choice = 0;
        try {
            string answer = Console.ReadLine();
            // If int.Parse here fails, it throws a format exception, meaning we know something other than a number got entered.
            choice = int.Parse(answer);
        } catch(FormatException e) {}


        switch(choice) {
            case 1:
                Console.WriteLine(" (1) Checking or  (2) Savings?");
                int wanswer = int.Parse(Console.ReadLine());
                if(wanswer == 1) {
                    withdrawMoney(checking);
                } else if(wanswer == 2) {
                    withdrawMoney(savings);
                } else {
                    Console.WriteLine("Try again, you bad.");
                }
                break;
            case 2:
                Console.WriteLine(" (1) Checking or  (2) Savings?");
                int danswer = int.Parse(Console.ReadLine());
                if(danswer == 1) {
                    depositMoney(checking);
                } else if(danswer == 2) {
                    depositMoney(savings);
                } else {
                    Console.WriteLine("Try again, you bad.");
                }
                break;
            case 3:
                Console.WriteLine(" (1) Checking or  (2) Savings?");
                int canswer = int.Parse(Console.ReadLine());
                if(canswer == 1) {
                    Console.WriteLine("Your Checking Balance is: " + checking);
                } else if(canswer == 2) {
                    Console.WriteLine("Your Savings Balance is: " + savings);
                } else {
                    Console.WriteLine("Try again, you bad.");
                }
                break;
            case 4:
                exit = true;
                break;
            default:
                Console.WriteLine("I'm sorry, your answer wasn't valid, please read the directions and try again."); // Handles other inputs
                break;
        }

    }
    
    Console.WriteLine("Goodbye!");
}

// This function takes the account balance as a parameter, and returns it modified after the withdrawal.
static Double withdrawMoney(Double account) {
    Console.WriteLine("How much would you like to withdraw?");
    try {
        string withdrawAmount = Console.ReadLine();
        return account - Double.Parse(withdrawAmount);
    } catch(Exception e) {
        Console.WriteLine("Something went wrong, please try again.");
        return account;
    }
}

// This function takes the account balance as a parameter, and returns it modified after the deposit.
static Double depositMoney(Double account) {
    Console.WriteLine("How much would you like to deposit?");
    try {
        string withdrawAmount = Console.ReadLine();
        return account + Double.Parse(withdrawAmount);
    } catch(Exception e) {
        Console.WriteLine("Something went wrong, please try again.");
        return account;
    }
}