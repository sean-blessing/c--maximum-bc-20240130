namespace FakeDataAPI {
    
public interface IStringListService {
        List<string> StringList { get; set; }
    }

    public class StringCollection : IStringListService {
        List<string> _stringList = new List<string> { "red", "blue" };
        public List<string> StringList { get { return _stringList; } set { _stringList = value; } }
    }
}
