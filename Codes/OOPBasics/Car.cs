namespace OOP.Basic;

class Car
{
    public string color; // Access modifiers: public, internal, protected, private
    private int _maxSpeed; //field
    private bool hasEngineStarted;

    public double CurrentSpeed { get; set; }

    public int MaxSpeed
    {
        get
        {
            return _maxSpeed;
        }
        set
        {
            if (value >= 1)
                _maxSpeed = value;
        }
    }

    public Car(string color) : this(color, 0)
    {

    }

    public Car(string color, int maxSpeed)
    {
        this.color = color;
        _maxSpeed = maxSpeed;
    }

    public Car()
    {
        color = "white";
        _maxSpeed = 0;
    }

    public void Start()
    {
        hasEngineStarted = true;
    }

    public void Stop()
    {
        hasEngineStarted = false;
        CurrentSpeed = 0;
    }

    public void IncreaseSpeed(double speed)
    {
        CurrentSpeed += speed;
    }
}



