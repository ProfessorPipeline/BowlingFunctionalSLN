namespace Bowling.xUnit;

public class Bowling
{
    public static List<int> ThrowsToList(string bowlingThrows) {
        return bowlingThrows.Split(' ').Select(int.Parse).ToList();
    }

    public static int CalculateScore(string throwsListStr)
    {
        var throwsConvertedToList = ThrowsToList(throwsListStr);
        return CalculateScore(throwsConvertedToList);
    }

    public static int CalculateScore(List<int> throwsList) {
        if (throwsList.Count == 0) {
            return 0;
        }
        else if (throwsList.Count == 1) {
            return throwsList[0];
        }
        else if (throwsList.Count == 2) {
            return throwsList[0] + throwsList[1];
        }
        else if (throwsList.Count == 3)
        {
            return throwsList[0] + throwsList[1] + throwsList[2];
        }
        
        if (throwsList[0] == 10)
        {   
            List<int> newList = new List<int>(throwsList);
            newList.RemoveAt(0);
            return throwsList[0] + throwsList[1] + throwsList[2] + CalculateScore(newList); 
        }
        else if (throwsList[0] + throwsList[1] == 10){
            List<int> newList = new List<int>(throwsList);
            newList.RemoveAt(0);
            newList.RemoveAt(0);
            return throwsList[0] + throwsList[1] + throwsList[2] + CalculateScore(newList);
        }
        
        List<int> lastList = new List<int>(throwsList);
        lastList.RemoveAt(0);
        lastList.RemoveAt(0);
        return throwsList[0] + throwsList[1] + CalculateScore(lastList);
    }

}
