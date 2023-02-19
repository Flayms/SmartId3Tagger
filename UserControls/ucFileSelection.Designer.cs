
namespace SmartId3Tagger.UserControls {
  partial class ucFileSelection {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnSelect = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.lbFiles = new System.Windows.Forms.ListBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.btnSelect, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.lbFiles, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 414);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // btnSelect
      // 
      this.btnSelect.Location = new System.Drawing.Point(3, 3);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new System.Drawing.Size(75, 23);
      this.btnSelect.TabIndex = 0;
      this.btnSelect.Text = "Select Files";
      this.btnSelect.UseVisualStyleBackColor = true;
      this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Location = new System.Drawing.Point(335, 3);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "Clear List Box";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // lbFiles
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.lbFiles, 2);
      this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbFiles.FormattingEnabled = true;
      this.lbFiles.Location = new System.Drawing.Point(3, 32);
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(407, 379);
      this.lbFiles.TabIndex = 2;
      // 
      // FileSelection
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "FileSelection";
      this.Size = new System.Drawing.Size(413, 414);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.ListBox lbFiles;
  }
}
