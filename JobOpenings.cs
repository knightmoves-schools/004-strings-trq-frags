namespace knightmoves;
public class JobOpenings
{   
    public string FirstName = "Jacob";

    public string JobTitle = "Manager";

    public string City = "Pittsburg";

    public string PrintOpening(){
        string printOpening = $"Dear {FirstName}, Thank you for being a good {JobTitle} in {City}\r\n";
        return printOpening;
    }
}
