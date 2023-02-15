using Xunit;
using MyAverageLib;

namespace MyAverageLibTest;

public class UnitTest1
{
    [Fact]
    public void TestAverageOf2and2() {
        double a = 2;
        double b = 2;
        double expected = 2;

        //act
        double actual =  Average.MyAvg1(a, b);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAverageOf2and3and4() {
        double a = 2;
        double b = 3;
        double c = 4;
        double expected = 3;
        
        double actual =  Average.MyAvg1(a, b, c);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAverageOf2and3and4fail() {
        double a = 2;
        double b = 3;
        double c = 4;
        double expected = 4;
        
        double actual =  Average.MyAvg1(a, b, c);
        
        Assert.Equal(expected, actual);
    }
}