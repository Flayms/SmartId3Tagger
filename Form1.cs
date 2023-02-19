using System;
using System.Windows.Forms;
using System.IO;

namespace SmartId3Tagger {
  public partial class Form1 : Form {

    private MainLogic _logic;
    private const string _TOPIC_ID = "Topic - ";

    public Form1() {
      this.InitializeComponent();
      this._logic = MainLogic.Instance;
    }

    private void btnAddTags_Click(object sender, EventArgs e) {
      var files = this._logic.Files;
      for (var i = 0; i < files.Length; ++i) {
        var file = files[i];
        var directory = file.Directory;
        var title = file.Name;
        var titleChanged = false;


        //correct filename
        if (title.Contains(_TOPIC_ID)) {
          title = title.Replace(_TOPIC_ID, string.Empty).Trim();
          titleChanged = true;
        } else {
          var splitted = title.Split('-');

          if (splitted.Length >= 3) {
            var removePart = splitted[0];
            title = title.Replace(removePart + "- ", string.Empty).Trim();
            titleChanged = true;
          }
        }

        //rename file
        if (titleChanged) {
          files[i] = file.CopyTo(Path.Combine(directory.FullName, title));
          file.Delete();
          file = files[i];
        }

        //add tags
        var splitted2 = title.Split('.');
        title = title.Replace("." + splitted2[splitted2.Length - 1], string.Empty);

        var tFile = TagLib.File.Create(file.FullName);
        var fileTags = tFile.Tag;
        var parts = title.Split('-');

        fileTags.Performers = new string[] { parts[0].Trim() };
        fileTags.Title = parts.Length > 1 ? parts[1].Trim() : title;
        tFile.Save();
      }

      MessageBox.Show("All Tags Added!");
    }
  }
}