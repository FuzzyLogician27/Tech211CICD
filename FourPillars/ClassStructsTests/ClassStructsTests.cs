using FourPillarsApp;
using System.Diagnostics.CodeAnalysis;

namespace ClassStructsTests
{
    [TestFixture, Category("Lesson Tests")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GivenNoAge_PersonAge_ReturnsAsEighteen()
        {
            Person person = new Person("Joe", "Mama");
            Assert.That(person.Age, Is.EqualTo(18));
        }

        [TestCase("Hugh", "Mungus", "Hugh Mungus")]
        [TestCase("", "", " ")]
        public void GivenFNameLName_PersonGetFullName_ReturnsCorrectName(string fName, string lName, string expected)
        {
            Person person = new Person(fName, lName);
            Assert.That(person.GetFullName, Is.EqualTo(expected));
        }

        [TestCase("Mr", "Mr Peter Bellaby")]
        [TestCase("Sir", "Sir Peter Bellaby")]
        [TestCase("", " Peter Bellaby")]
        public void GivenTitle_PersonGetFullName_ReturnsCorrectTitle(string title, string expected)
        {
            Person person = new Person("Peter", "Bellaby");
            Assert.That(person.GetFullName(title), Is.EqualTo(expected));
        }


        [TestCase(1)]
        [TestCase(0)]
        [TestCase(100)]
        public void GivenAge_Person_StoresCorrectAge(int age)
        {
            Person person = new Person("Some", "Fellow", age);
            Assert.That(person.Age, Is.EqualTo(age));
        }
        [TestCase(-1)]
        public void GivenNegativeAge_Person_ReturnsDefaultAge(int age)
        {
            Person person = new Person("Some", "Fellow", age);
            Assert.That(person.Age, Is.EqualTo(18));
        }

        [TestCase(180)]
        public void GivenHeight_Person_StoresCorrectHeight(int height)
        {
            Person person = new Person("Some", "Fellow");
            person.Height = height;
            Assert.That(person.Height, Is.EqualTo(height));
        }

        [Test]
        public void Person_ConstructsSuccessfully()
        {
            var _sut = new Person();
            Assert.Pass();
        }

        [Test]
        public void Person_ConstructsSuccessfully_GivenFullName()
        {
            var _sut = new Person("John", "Smith");
            Assert.Pass();
        }

    }

    [TestFixture, Category("Lab Tests")]
    public class LabTests
    {

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.That(v.Position, Is.EqualTo(20));
            Assert.That(result, Is.EqualTo("Moving along 2 times"));
        }


        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.That(v.Position, Is.EqualTo(40));
            Assert.That(result, Is.EqualTo("Moving along"));
        }

        [Test]
        public void Vehicle_ConstructsCorrectly()
        {
            var _sut = new Vehicle();
            Assert.Pass();
        }

        [Test]
        public void Vehicle_ConstructsCorrectly_GivenSomeInputs()
        {
            var _sut = new Vehicle(5,15);
            Assert.Pass();
        }


        [Test]
        public void WhenGivenNoSpeed_Vehicle_ConstructsWithSpeedTen()
        {
            var _sut = new Vehicle(5);

            Assert.That(_sut.Speed, Is.EqualTo(10));
        }

        [TestCase(5,4)]
        [TestCase(1,0)]
        [TestCase(6, 1)]
        public void WhenNumPassengersIsTooLarge_Vehicle_GivesVehicleCapacity(int passengers, int capacity)
        {
            var _sut = new Vehicle(capacity);
            _sut.NumPassengers = passengers;
            Assert.That(_sut.NumPassengers, Is.EqualTo(capacity));
        }


        [Test]
        public void WhenNumPassengersNegative_Vehicle_GivesZero()
        {
            var _sut = new Vehicle(1);
            _sut.NumPassengers = -1;
            Assert.That(_sut.NumPassengers, Is.EqualTo(0));
        }

    }

    public class AirplaneTests
    {
        

        [Test]
        public void GivenCorrectParameters_ToString_FormatsCorrectly()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            Assert.That(a.ToString(), Is.EqualTo("Thank you for flying JetsRUs: FourPillarsApp.Airplane Capacity: 200, Passengers: 0, Speed: 100, Position: 0, Altitude: 0."));
        }

        [TestCase(3, 500, "Moving along 3 times at an altitude of 500 metres.")]
        public void GivenSomeIntegerAndAltitude_MoveInteger_GivesCorrectOutput(int times, int altitude, string expected)
        {
            Airplane a = new Airplane(200);
            a.Ascend(altitude);
            Assert.That(a.Move(times), Is.EqualTo(expected));
        }

        [TestCase(100)]
        public void GivenSomeHeight_Ascend_ReturnsCorrectAltitude(int rise)
        {
            Airplane a = new Airplane(10);
            a.Ascend(rise);
            Assert.That(a.Altitude, Is.EqualTo(rise));
        }

        [TestCase(100, 0)]
        [TestCase(110, 0)]
        [TestCase(20, 80)]
        public void GivenSomeHeight_Descend_ReturnsCorrectAltitude(int fall, int expected)
        {
            Airplane a = new Airplane(10);
            a.Ascend(100);
            a.Descend(fall);
            Assert.That(a.Altitude, Is.EqualTo(expected));
        }

        [Test]
        public void SillyTest()
        {
            Assert.Fail();
        }

    }

    
}