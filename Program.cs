Console.WriteLine("Password Generator");

string randomPassword = GenerateRandomPassword(16);

Console.WriteLine($"This is your new password in plain text: {randomPassword}");

// generate random password that includes numbers, letters and symbols
string GenerateRandomPassword(int lengthOfPassword) {
    Random rd = new Random();
    int randomTypeOfChar, randomNumber = 0;
    string password = "";

    for (var i = 1; i <= lengthOfPassword; i++){
        // choose what type of character to add, randomly 
        randomTypeOfChar = rd.Next(1,4);
        
        if ((TypeOfChar) randomTypeOfChar == TypeOfChar.Symbol) {
            randomNumber = rd.Next(33,48);
            password += Convert.ToChar(randomNumber).ToString();
        }

        if ((TypeOfChar) randomTypeOfChar == TypeOfChar.Number) {
            randomNumber = rd.Next(48,58);
            password += Convert.ToChar(randomNumber).ToString();
        }

        if ((TypeOfChar) randomTypeOfChar == TypeOfChar.Letter) {
            randomNumber = rd.Next(65,91);
            password += Convert.ToChar(randomNumber).ToString();
        }
    }

    return password;

}

public enum TypeOfChar {
    Symbol= 1,
    Number= 2,
    Letter= 3,
}
