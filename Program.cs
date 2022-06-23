string[][] MainTab = new string[9][];
string[][] TargetTab = new string[9][];
int compteur = 0;
bool gameInProgress = true;


//Function to sanitize user input Row/Collumn
int[] userInput()
{
    int[] parsedInput = { 0, 0 };
    string choix = "";
    do
    {
        string input = Console.ReadLine();
        choix = input.ToUpper();
    } while (choix[0] != 'A' && choix[0] != 'B' && choix[0] != 'C' && choix[0] != 'D' && choix[0] != 'E' && choix[0] != 'F' && choix[0] != 'G' && choix[0] != 'H' && choix[0] != 'I' &&
             choix[1] != '0' && choix[1] != '1' && choix[1] != '2' && choix[1] != '3' && choix[1] != '4' && choix[1] != '5' && choix[1] != '6' && choix[1] != '7' && choix[1] != '8');
    switch (choix[0])
    {
        case 'A':
            parsedInput[0] = 0;
            break;
        case 'B':
            parsedInput[0] = 1;
            break;
        case 'C':
            parsedInput[0] = 2;
            break;
        case 'D':
            parsedInput[0] = 3;
            break;
        case 'E':
            parsedInput[0] = 4;
            break;
        case 'F':
            parsedInput[0] = 5;
            break;
        case 'G':
            parsedInput[0] = 6;
            break;
        case 'H':
            parsedInput[0] = 7;
            break;
        case 'I':
            parsedInput[0] = 8;
            break;
    }
    switch (choix[1])
    {
        case '0':
            parsedInput[1] = 0;
            break;
        case '1':
            parsedInput[1] = 1;
            break;
        case '2':
            parsedInput[1] = 2;
            break;
        case '3':
            parsedInput[1] = 3;
            break;
        case '4':
            parsedInput[1] = 4;
            break;
        case '5':
            parsedInput[1] = 5;
            break;
        case '6':
            parsedInput[1] = 6;
            break;
        case '7':
            parsedInput[1] = 7;
            break;
        case '8':
            parsedInput[1] = 8;
            break;
    }
    return parsedInput;
}
//Function to initialize the gameboard.
void initializeGameboard()
{
    MainTab[0] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[1] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[2] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[3] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[4] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[5] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[6] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[7] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    MainTab[8] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };

}
//Function for the Target Gameboard.
void targetGameboard()
{
    TargetTab[0] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    TargetTab[1] = new string[] { "   |", " B |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    TargetTab[2] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    TargetTab[3] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", " B |", "   |" };
    TargetTab[4] = new string[] { "   |", "   |", "   |", "   |", " B |", "   |", "   |", " B |", "   |" };
    TargetTab[5] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", " B |", "   |" };
    TargetTab[6] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", " B |", "   |" };
    TargetTab[7] = new string[] { "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
    TargetTab[8] = new string[] { " B |", "   |", "   |", "   |", "   |", "   |", "   |", "   |", "   |" };
}
//Test Function to show TargetTab.
void targetTabTest(string x, int y)
{
    Console.Write(x);
    foreach (string n in TargetTab[y])
    {
        Console.Write(n);
    }
    Console.WriteLine();
}
//Test gameboard function for TargetTab.
void targetTabGameboard()
{
    Console.WriteLine("    A   B   C   D   E   F   G   H   I");
    targetTabTest("0 |", 0);
    targetTabTest("1 |", 1);
    targetTabTest("2 |", 2);
    targetTabTest("3 |", 3);
    targetTabTest("4 |", 4);
    targetTabTest("5 |", 5);
    targetTabTest("6 |", 6);
    targetTabTest("7 |", 7);
    targetTabTest("8 |", 8);
}
//Function to draw one line of the gameboard.
void gameline(string x, int y)
{
    Console.Write(x);
    foreach (string n in MainTab[y])
    {
        Console.Write(n);
    }
    Console.WriteLine();
}
//Function to draw the gameboard.
void gameboard()
{
    Console.WriteLine("    A   B   C   D   E   F   G   H   I");
    gameline("0 |", 0);
    gameline("1 |", 1);
    gameline("2 |", 2);
    gameline("3 |", 3);
    gameline("4 |", 4);
    gameline("5 |", 5);
    gameline("6 |", 6);
    gameline("7 |", 7);
    gameline("8 |", 8);
}
//Function that verify adjascent cells of a given cell. x = Row y = Collumn
int verifyCell(int [] input)
{
    compteur = 0;
    //Top Row Checker
    if (input[0] > 0 && input[1] > 0)
    {
        if (TargetTab[input[0] - 1][input[1] - 1] == " B |")
            compteur++;
    }
    if (input[0] > 0)
    {
        if (TargetTab[input[0] - 1][input[1]] == " B |")
            compteur++;
    }
    if (input[0] > 0 && input[1] < 8)
    {
        if (TargetTab[input[0] - 1][input[1] + 1] == " B |")
            compteur++;
    }
    //Mid Row Checker
    if (input[1] > 0)
    {
        if (TargetTab[input[0]][input[1] - 1] == " B |")
            compteur++;
    }
    if (input[1] < 8)
    {

        if (TargetTab[input[0]][input[1] + 1] == " B |")
            compteur++;
    }
    //Bot Row Checker
    if (input[0] < 8 && input[1] > 0)
    {
        if (TargetTab[input[0] + 1][input[1] - 1] == " B |")
            compteur++;
    }
    if (input[0] < 8)
    {
        if (TargetTab[input[0] + 1][input[1]] == " B |")
            compteur++;
    }
    if (input[0] < 8 && input[1] < 8)
    {
        if (TargetTab[input[0] + 1][input[1] + 1] == " B |")
            compteur++;
    }

    return compteur;
}
//Function that verify if adjascent cells are empty.
int verifyEmptyCell(int x, int y)
{
    //Top Row Checker
    if (x > 0 && y > 0)
    {
        if (TargetTab[x - 1][y - 1] == " 0 |")
            MainTab[x - 1][y - 1] = TargetTab[x - 1][y - 1];
    }
    if (x > 0)
    {
        if (TargetTab[x - 1][y] == " 0 |")
            MainTab[x - 1][y] = TargetTab[x - 1][y];
    }
    if (x > 0 && y < 8)
    {
        if (TargetTab[x - 1][y + 1] == " 0 |")
            MainTab[x - 1][y + 1] = TargetTab[x - 1][y + 1];
    }
    //Mid Row Checker
    if (y > 0)
    {
        if (TargetTab[x][y - 1] == " 0 |")
            MainTab[x][y - 1] = TargetTab[x][y - 1];
    }
    if (y < 8)
    {

        if (TargetTab[x][y + 1] == " 0 |")
            MainTab[x][y + 1] = TargetTab[x][y + 1];
    }
    //Bot Row Checker
    if (x < 8 && y > 0)
    {
        if (TargetTab[x + 1][y - 1] == " 0 |")
            MainTab[x + 1][y - 1] = TargetTab[x + 1][y - 1];
    }
    if (x < 8)
    {
        if (TargetTab[x + 1][y] == " 0 |")
            MainTab[x + 1][y] = TargetTab[x + 1][y];
    }
    if (x < 8 && y < 8)
    {
        if (TargetTab[x + 1][y + 1] == " 0 |")
            MainTab[x + 1][y + 1] = TargetTab[x + 1][y + 1];
    }

    return compteur;
}
//Function to change a cell value to reflect adjascent bombs.
void cellValueSetter()
{
    for (int n = 0; n <= 8; n++)
    {
        for (int i = 0; i <= 8; i++)
        {
            verifyCell(n, i);
            if (TargetTab[n][i] != " 0 |" && TargetTab[n][i] != " B |")
            {
                TargetTab[n][i] = $" {compteur} |";
            }
        }
    }
}
//Function to check the value of one cell. x = Row y = Collumn
void cellValueChecker(int[] input)
{
    if (TargetTab[input[0]][input[1]] == " B |")
    {
        MainTab[input[0]][input[1]] = TargetTab[input[0]][input[1]];
        gameInProgress = false;
        Console.Clear();
        gameboard();
        Console.WriteLine();
        Console.WriteLine("Game Over!");

    }
    if (TargetTab[input[0]][input[1]] == " 0 |")
    {
        //emptyCellCheckerHori(x,y);
        //emptyCellCheckerVerti(x, y);
        revealEmptyCell(x, input[1]);
    }
    if (TargetTab[input[0]][input[1]] != " B |" && TargetTab[input[0]][input[1]] != " 0 |")
    {
        MainTab[input[0]][input[1]] = TargetTab[input[0]][input[1]];
    }
}
//Function to reveal all cells adjascent to empty cells (Horizon).
void emptyCellCheckerHori(int x, int y)
{
    for (int n = 0; n <= 8; n++)
    {
        for (int i = y; i <= 8; i++)
        {
             verifyEmptyCell(n, i);
            if (i < 8)
            {
                if (TargetTab[n][i + 1] != " 0 |" && TargetTab[n][i + 1] != " B |")
                {
                    MainTab[n][i + 1] = TargetTab[n][i + 1];
                    break;
                }
            }
        }
        for (int i = y; i >= 0; i--)
        {
            verifyEmptyCell(n, i);
            if (i > 0)
            {
                if (TargetTab[n][i - 1] != " 0 |" && TargetTab[n][i - 1] != " B |")
                {
                    MainTab[n][i - 1] = TargetTab[n][i - 1];
                    break;
                }
            }
        }
    }
}
//Function to reveal all cells adjascent to empty cells (Vertical)
void emptyCellCheckerVerti(int x, int y)
{
    for (int n = 0; n <= 8; n++)
    {
        for (int i = x; i <= 8; i++)
        {
            verifyEmptyCell(i, n);
            if (i < 8)
            {
                if (TargetTab[i + 1][n] != " 0 |" && TargetTab[i + 1][n] != " B |")
                {
                    MainTab[i + 1][n] = TargetTab[i + 1][n];
                    break;
                }
            }
        }
    }
    for (int n = 0; n <= 8; n++)
    {
        for (int i = x; i >= 0; i--)
        {
            verifyEmptyCell(i, n);
            if (i > 0)
            {
                if (TargetTab[i - 1][n] != " 0 |" && TargetTab[i - 1][n] != " B |")
                {
                    MainTab[i - 1][n] = TargetTab[i - 1][n];
                    break;
                }
            }
        }
    }
}
//Function to reveal empty cells on a certain row
void revealEmptyCell(int row, int collumn)
{
    for (int i = collumn; i < 8; i++)
    {
        if (collumn < 8)
        {
            if (TargetTab[row][collumn + 1] == " 0 |")
                MainTab[row][collumn + 1] = TargetTab[row][collumn + 1];
            if (collumn < 7)
            {

                if (TargetTab[row][collumn + 2] !=  " 0 |" && TargetTab[row][collumn + 2] != " B |")
                    {
                    MainTab[row][collumn + 2] = TargetTab[row][collumn + 2];
                    break;
                    }
            }
        }
    }
    for (int i = collumn; i > 0 ; i--)
    {
        if (collumn > 0)
        {
            if (TargetTab[row][collumn - 1] == " 0 |")
                MainTab[row][collumn - 1] = TargetTab[row][collumn - 1];
            if (collumn > 1)
            {
                if (TargetTab[row][collumn - 2] != " 0 |" && TargetTab[row][collumn - 2] != " B |")
                {
                    MainTab[row][collumn - 2] = TargetTab[row][collumn - 2];
                    break;
                }
            }
        }
    }
}

void revealCells(int row, int collumn)
{
    for (int i = row; i < 8; i++)
    {
        revealCells(i, collumn);
    }
    for (int i = row; i > 0; i--)
    {
        revealCells(i, collumn);
    }
}











initializeGameboard();
targetGameboard();
cellValueSetter();
while (gameInProgress)
{
    Console.Clear();
    gameboard();
    targetTabGameboard();
    cellValueChecker(userInput());
    
}



