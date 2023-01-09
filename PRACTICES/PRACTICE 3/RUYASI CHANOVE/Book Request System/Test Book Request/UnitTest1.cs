using System.Security.Cryptography;

namespace Test_Book_Request
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddingNovel()
        {
            BookManager bm = new BookManager();
            bm.Add(new Novel("Victor Hugo", "Les Miserables", "NOV-772", "Historical Novel", "French", "Free", 22.45, "978-3-16-148410-0"));
            bm.Add(new Essay("Sun Tzu","The Art of War","ESS-521","Military Issues","English","Free",18.99,"723-5-16-123190-9"));
            bm.Add(new Comic("Stan Lee","X-Men #1","COM-169","Action Comic","English","Free",199.22, "852-1-52-58221-2"));
            

        }
        [TestMethod]
        public void TestLend()
        {
            BookManager bm = new BookManager();
            bm.Add(new Novel("Victor Hugo", "Les Miserables", "NOV-772", "Historical Novel", "French", "Free", 22.45, "978-3-16-148410-0"));
            bm.Add(new Essay("Sun Tzu", "The Art of War", "ESS-521", "Military Iss  ues", "English", "Free", 18.99, "723-5-16-123190-9"));
            bm.Add(new Comic("Stan Lee", "X-Men #1", "COM-169", "Action Comic", "English", "Free", 199.22, "852-1-52-58221-2"));
            
            bm.Lend(new Novel("Victor Hugo", "Les Miserables", "NOV-772", "Historical Novel", "French", "Free", 22.45, "978-3-16-148410-0"),"Jorge Lopez","Novel","Les Miserables");

        }

        public void TestRemove()
        {
            BookManager bm = new BookManager();
            bm.Add(new Novel("Victor Hugo", "Les Miserables", "NOV-772", "Historical Novel", "French", "Free", 22.45, "978-3-16-148410-0"));
            bm.Add(new Essay("Sun Tzu", "The Art of War", "ESS-521", "Military Issues", "English", "Free", 18.99, "723-5-16-123190-9"));
            bm.Add(new Comic("Stan Lee", "X-Men #1", "COM-169", "Action Comic", "English", "Free", 199.22, "852-1-52-58221-2"));
            bm.Remove(new Essay("Sun Tzu", "The Art of War", "ESS-521", "Military Issues", "English", "Free", 18.99, "723-5-16-123190-9"),"The Art of War");

        }
    }
}