namespace Jalasoft.DevLEvel1.Practice03
{
    public class Novel : Book
    {
        public Novel(string auth, string nam, int libCode, string gnr, string lang, double purchPrc, string ISBN) : base(auth, nam, libCode, gnr, lang, purchPrc, ISBN)
        {
        }
    }
}