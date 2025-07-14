public class Bus
{
    private int BusNo;
    private bool isAc;
    private int Capacity;

    public Bus(int BusNo, bool isAc, int Capacity)
    {
        this.BusNo = BusNo;
        this.isAc = isAc;
        this.Capacity = Capacity;
    }

    public int getBusNo()
    {
        return BusNo;
    }

    public bool isAcBus()
    {
        return isAc;
    }

    public void setAc(bool isAc)
    {
        this.isAc = isAc;
    }

    public int getCapacity()
    {
        return Capacity;
    }

    public void setCapacity(int capacity)
    {
        this.Capacity = capacity;
    }

    public void displayBusInfo()
    {
        Console.WriteLine($"Bus No: {BusNo}, AC: {isAc}, Capacity: {Capacity}");
    }

}