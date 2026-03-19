namespace WinFormsApp4;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        trackBar1 = new System.Windows.Forms.TrackBar();
        button3 = new System.Windows.Forms.Button();
        trackBar2 = new System.Windows.Forms.TrackBar();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(469, 283);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(222, 76);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(60, 294);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(169, 76);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // trackBar1
        // 
        trackBar1.Location = new System.Drawing.Point(240, 384);
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new System.Drawing.Size(279, 45);
        trackBar1.TabIndex = 2;
        trackBar1.Scroll += trackBar1_Scroll;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(260, 117);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(198, 83);
        button3.TabIndex = 3;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // trackBar2
        // 
        trackBar2.Location = new System.Drawing.Point(42, 38);
        trackBar2.Name = "trackBar2";
        trackBar2.Size = new System.Drawing.Size(207, 45);
        trackBar2.TabIndex = 4;
        trackBar2.Scroll += trackBar2_Scroll;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(trackBar2);
        Controls.Add(button3);
        Controls.Add(trackBar1);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TrackBar trackBar2;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TrackBar trackBar1;

    #endregion
}