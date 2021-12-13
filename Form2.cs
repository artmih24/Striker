// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form2
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 73D1CE30-46F1-425E-827D-66B3E6F8877A
// Assembly location: E:\Артём\Мои программы\Зачёркиватель.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public class Form2 : Form
  {
    private Random r = new Random();
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private PictureBox pictureBox1;

    public Form2() => this.InitializeComponent();

    public static object show { get; internal set; }

    public static bool topmost { get; internal set; }

    public int size { get; private set; }

    private void Form2_Load(object sender, EventArgs e)
    {
      this.Width = 297;
      this.Height = 370;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      int red = this.r.Next((int) byte.MaxValue);
      int green = this.r.Next((int) byte.MaxValue);
      int blue = this.r.Next((int) byte.MaxValue);
      this.BackColor = Color.FromArgb(red, green, blue);
      this.label1.ForeColor = Color.FromArgb((int) byte.MaxValue - red, (int) byte.MaxValue - green, (int) byte.MaxValue - blue);
      this.label2.ForeColor = Color.FromArgb((int) byte.MaxValue - red, (int) byte.MaxValue - green, (int) byte.MaxValue - blue);
      this.Text = "R: " + (object) red + " G: " + (object) green + " B: " + (object) blue;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.label1 = new Label();
      this.label2 = new Label();
      this.pictureBox1 = new PictureBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 204);
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(262, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "ЗАЧЁРКИВАТЕЛЬ";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 204);
      this.label2.Location = new Point(15, 297);
      this.label2.Name = "label2";
      this.label2.Size = new Size((int) byte.MaxValue, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Автор: Артём Горелик";
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(12, 43);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(257, 251);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonHighlight;
      this.ClientSize = new Size(281, 331);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form2);
      this.Text = "О программе";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
