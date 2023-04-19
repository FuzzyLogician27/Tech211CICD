namespace FourPillarsApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        int _numPassengers;

        private int _speed;

        public int NumPassengers
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (value < 0)
                {
                    _numPassengers = 0;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
                else
                {
                    _numPassengers = value;
                }
            }
        }
        public int Position { get; private set; }
        public int Speed { get { return _speed; } init { _speed = value; } }


        public Vehicle()
        {
            _capacity = 1;
            Speed = 10;
            Position = 0;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
            Position = 0;
        }


        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }
        public virtual string Move(int times)
        {
            Position += (Speed * times);
            return $"Moving along {times} times";
        }


        public override string ToString()
        {
            return $"{base.ToString()} Capacity: {_capacity}, Passengers: {NumPassengers}, Speed: {Speed}, Position: {Position}";
        }



    }
}