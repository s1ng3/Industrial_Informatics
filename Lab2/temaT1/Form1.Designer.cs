﻿namespace temaT1
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(559, 352);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(96, 33);
      this.button1.TabIndex = 0;
      this.button1.Text = "Exit";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(283, 251);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(106, 26);
      this.button2.TabIndex = 1;
      this.button2.Text = "Sterge";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(592, 48);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(142, 31);
      this.button3.TabIndex = 2;
      this.button3.Text = "Adauga";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Visible = false;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(546, 251);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 29);
      this.label1.TabIndex = 3;
      this.label1.Text = "Cost total: 0.00$";
      this.label1.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
  }
}

