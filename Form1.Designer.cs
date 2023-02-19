
namespace SmartId3Tagger {
  partial class Form1 {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnAddTags = new System.Windows.Forms.Button();
      this.ucFileSelection1 = new SmartId3Tagger.UserControls.ucFileSelection();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.ucFileSelection1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnAddTags, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 466);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // btnAddTags
      // 
      this.btnAddTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddTags.Location = new System.Drawing.Point(274, 440);
      this.btnAddTags.Name = "btnAddTags";
      this.btnAddTags.Size = new System.Drawing.Size(75, 23);
      this.btnAddTags.TabIndex = 3;
      this.btnAddTags.Text = "Add Tags";
      this.btnAddTags.UseVisualStyleBackColor = true;
      this.btnAddTags.Click += new System.EventHandler(this.btnAddTags_Click);
      // 
      // ucFileSelection1
      // 
      this.ucFileSelection1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucFileSelection1.Location = new System.Drawing.Point(3, 3);
      this.ucFileSelection1.Name = "ucFileSelection1";
      this.tableLayoutPanel1.SetRowSpan(this.ucFileSelection1, 2);
      this.ucFileSelection1.Size = new System.Drawing.Size(265, 460);
      this.ucFileSelection1.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 466);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "SmartId3Tagger";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private UserControls.ucFileSelection ucFileSelection1;
    private System.Windows.Forms.Button btnAddTags;
  }
}

