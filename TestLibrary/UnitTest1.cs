using LendingLibrary;

namespace TestLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddingBookToLibrary()
        {
            //Arrange
            Library l = new Library();
            l.Add("PizzaBook", "Rama", "Wael", 100);
            l.Add("Swimming", "Hala", "Samer", 200);
            l.Add("Hello", "Rama", "Wael", 800);

            
            // Assert
            Assert.Equal(3, l.Count);
            
        }
        [Fact]
        public void TestBorrowExistingTitle()
        {
            
            //Arrange
            Library l = new Library();
            l.Add("PizzaBook","Rama","Wael",100);
            l.Add("Swimming", "Hala", "Samer", 200);
            l.Add("Hello", "Rama", "Wael", 800);

            //Act
            Book borrowed = l.Borrow("Hello");

            //Assert
            Assert.Equal(2,l.Count);
            Assert.DoesNotContain(borrowed, l);
        }
        [Fact]
        public void TestBorrowMissingTitle()
        {

            //Arrange
            Library l = new Library();
            l.Add("PizzaBook", "Rama", "Wael", 100);
            l.Add("Swimming", "Hala", "Samer", 200);
            l.Add("Hello", "Rama", "Wael", 800);

            //Act
            Book borrowed = l.Borrow("KJ");

            //Assert
            Assert.Equal(3, l.Count);
            Assert.Equal(null,borrowed);
        }
        [Fact]
        public void TestReturningBook() 
        {
            //Arrange
            Library l = new Library();
            l.Add("java", "Rama", "Wael", 100);
            l.Add("C++", "Sara", "Ahmad", 330);
            l.Add("Html", "Hala", "Safi", 500);

            //Act
            Book returned = new Book("C#","Rama Wael");
            l.Return(returned);

            //Assert
            Assert.Equal(4, l.Count);
            Assert.Contains(returned, l);
        }
        [Fact]
        public void TestThePacking() 
        {
            //Arrange
            Backpack<string > Bag = new Backpack<string>();

            //Act
            string b1 = "Crocodile";
            Bag.Pack(b1);

            //Assert
            Assert.Equal(1,Bag.Count());
            Assert.True(Bag.Contains(b1));


        }
        [Fact]
        public void TestTheUnPacking()
        {
            //Arrange
            Backpack<string> Bag = new Backpack<string>();

            //Act
            Bag.Pack("Crocodiles");
            Bag.Pack("Cats");
            Bag.Pack("Dogs");
            Bag.Pack("Birds");


            Bag.Unpack(2);

            //Assert
            Assert.Equal(3, Bag.Count());
            Assert.DoesNotContain("Dogs",Bag);


        }
    }
}