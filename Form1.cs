// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form1
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 73D1CE30-46F1-425E-827D-66B3E6F8877A
// Assembly location: E:\Артём\Мои программы\Зачёркиватель.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public class Form1 : Form
  {
    private int i;
    private IContainer components = (IContainer) null;
    private TextBox textBox1;
    private Button button1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem менюToolStripMenuItem;
    private TextBox textBox2;
    private ToolStripMenuItem оПрограммеToolStripMenuItem;
    private Button button2;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Width = 1146;
      this.Height = 396;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      char[] charArray = this.textBox1.Text.ToCharArray();
      this.textBox2.Text = "&#0822;";
      for (int index = 0; index < this.textBox1.Text.Length; ++index)
        this.textBox2.Text = this.textBox2.Text + charArray[index].ToString() + "&#0822;";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.textBox1.Text = "";
      this.textBox2.Text = "";
    }

    private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new Form2().Show();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.menuStrip1 = new MenuStrip();
      this.менюToolStripMenuItem = new ToolStripMenuItem();
      this.оПрограммеToolStripMenuItem = new ToolStripMenuItem();
      this.textBox2 = new TextBox();
      this.button2 = new Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.textBox1.Font = new Font("Microsoft Sans Serif", 15f);
      this.textBox1.Location = new Point(12, 27);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(971, 106);
      this.textBox1.TabIndex = 0;
      this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button1.Font = new Font("Microsoft Sans Serif", 12f);
      this.button1.Location = new Point(989, 27);
      this.button1.Name = "button1";
      this.button1.Size = new Size(129, 77);
      this.button1.TabIndex = 1;
      this.button1.Text = "Зачеркнуть!";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.menuStrip1.BackColor = SystemColors.ButtonHighlight;
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.менюToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1130, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      this.менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.оПрограммеToolStripMenuItem
      });
      this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
      this.менюToolStripMenuItem.Size = new Size(53, 20);
      this.менюToolStripMenuItem.Text = "Меню";
      this.оПрограммеToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
      this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      this.оПрограммеToolStripMenuItem.Size = new Size(149, 22);
      this.оПрограммеToolStripMenuItem.Text = "О программе";
      this.оПрограммеToolStripMenuItem.Click += new EventHandler(this.оПрограммеToolStripMenuItem_Click);
      this.textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.textBox2.Font = new Font("Microsoft Sans Serif", 15f);
      this.textBox2.Location = new Point(12, 139);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(1106, 206);
      this.textBox2.TabIndex = 3;
      this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button2.Font = new Font("Microsoft Sans Serif", 9f);
      this.button2.Location = new Point(989, 110);
      this.button2.Name = "button2";
      this.button2.Size = new Size(129, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Очистить";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonHighlight;
      this.ClientSize = new Size(1130, 357);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (Form1);
      this.Text = "Зачёркиватель";
      this.Load += new EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
