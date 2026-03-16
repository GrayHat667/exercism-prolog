class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int howLongInOven) => ExpectedMinutesInOven() - howLongInOven;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layerNumber)
    {
        return 2 * layerNumber;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layerNumber, int howLongInOven)
    {
        return PreparationTimeInMinutes(layerNumber) + howLongInOven;
    }
    
}
