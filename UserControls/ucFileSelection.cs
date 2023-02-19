using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SmartId3Tagger.UserControls {
  public partial class ucFileSelection : UserControl {

    private MainLogic _logic;

    public ucFileSelection() {
      this.InitializeComponent();
      this._logic = MainLogic.Instance;
    }

    private void btnSelect_Click(object sender, EventArgs e) {
      var files = _RequestFiles();
      this._logic.Files = files;
      foreach (var file in files)
        this.lbFiles.Items.Add(file.Name);
    }

    private void btnClear_Click(object sender, EventArgs e) {
      lbFiles.Items.Clear();
      this._logic.Files = new FileInfo[0];
    }

    private static FileInfo[] _RequestFiles() {
      var files = new List<FileInfo>();

      using (var fileDialog = new OpenFileDialog()) {
        fileDialog.Multiselect = true;
        fileDialog.Filter = "Only Audio Files|*.mp3;*.aac;*.flac";
        fileDialog.ShowDialog();

        foreach (var fileName in fileDialog.FileNames)
          files.Add(new FileInfo(fileName));
      }
      return files.ToArray();
    }

  }
}
