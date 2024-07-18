using Bowling.xUnit;
using System.Collections.Generic;

namespace Bowling.xUnit.Tests;

public class UnitTest1
{

    [Fact]
    public void Bowling_ShouldReturnCorrectList()
    {
        //arrange 
        var bowlingThrowsStr = "2 4 1 5 1 5 6 10";
        List<int> bowlingThrowsList = [2,4,1,5,1,5,6,10];
        //act
        var result = Bowling.ThrowsToList(bowlingThrowsStr);
        //assert
        Assert.Equal(result, bowlingThrowsList);
    }

    [Fact]
    public void Bowling_ShouldReturnCorrectScore_FromString()
    {
        //arrange
        var bowlingThrowsStr = "2 4 1 5 1 5 6 10";
        //act
        var result = Bowling.CalculateScore(bowlingThrowsStr);
        //assert
        Assert.Equal(34, result);
    }

    [Fact]
    public void Bowling_ShouldReturnCorrectScore_FromList()
    {
        //arrange
        List<int> bowlingThrowsList = [2,4,1,5,1,5,6,10];
        //act
        var result = Bowling.CalculateScore(bowlingThrowsList);
        //assert
        Assert.Equal(34, result);
    }

}

