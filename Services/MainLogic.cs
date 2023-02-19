using System.IO;

namespace SmartId3Tagger {
  public class MainLogic {

    public FileInfo[] Files { get; set; }

    public static MainLogic Instance {
      get {
        if (_instance == null) {
          _instance = new MainLogic();
        }
        return _instance;
      }
    }

  private static MainLogic _instance;

    private MainLogic() { }

  }
}