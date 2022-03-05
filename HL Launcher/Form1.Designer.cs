
namespace hl2005wonlauncher
{
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.bxtUpd = new System.Windows.Forms.Button();
            this.parametres = new System.Windows.Forms.TextBox();
            this.textparametres = new System.Windows.Forms.Label();
            this.bxtCheck = new System.Windows.Forms.CheckBox();
            this.riCheck = new System.Windows.Forms.CheckBox();
            this.path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(117, 312);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 37);
            this.start.TabIndex = 0;
            this.start.Text = "Запустить HL 2005 WON";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.lauchhl);
            // 
            // bxtUpd
            // 
            this.bxtUpd.Location = new System.Drawing.Point(82, 185);
            this.bxtUpd.Name = "bxtUpd";
            this.bxtUpd.Size = new System.Drawing.Size(171, 37);
            this.bxtUpd.TabIndex = 1;
            this.bxtUpd.Text = "Проверить обновления BXT";
            this.bxtUpd.UseVisualStyleBackColor = true;
            this.bxtUpd.Click += new System.EventHandler(this.bxtup);
            // 
            // parametres
            // 
            this.parametres.Location = new System.Drawing.Point(73, 159);
            this.parametres.Name = "parametres";
            this.parametres.Size = new System.Drawing.Size(205, 20);
            this.parametres.TabIndex = 2;
            // 
            // textparametres
            // 
            this.textparametres.AutoSize = true;
            this.textparametres.Location = new System.Drawing.Point(103, 135);
            this.textparametres.Name = "textparametres";
            this.textparametres.Size = new System.Drawing.Size(141, 13);
            this.textparametres.TabIndex = 3;
            this.textparametres.Text = "Параметры запуска hl.exe";
            // 
            // bxtCheck
            // 
            this.bxtCheck.AutoSize = true;
            this.bxtCheck.Checked = true;
            this.bxtCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bxtCheck.Location = new System.Drawing.Point(117, 238);
            this.bxtCheck.Name = "bxtCheck";
            this.bxtCheck.Size = new System.Drawing.Size(47, 17);
            this.bxtCheck.TabIndex = 4;
            this.bxtCheck.Text = "BXT";
            this.bxtCheck.UseVisualStyleBackColor = true;
            // 
            // riCheck
            // 
            this.riCheck.AutoSize = true;
            this.riCheck.Location = new System.Drawing.Point(179, 238);
            this.riCheck.Name = "riCheck";
            this.riCheck.Size = new System.Drawing.Size(58, 17);
            this.riCheck.TabIndex = 5;
            this.riCheck.Text = "RInput";
            this.riCheck.UseVisualStyleBackColor = true;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(69, 55);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(175, 20);
            this.path.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectHlPath);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Путь к HL WON";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(106, 276);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(147, 17);
            this.close.TabIndex = 9;
            this.close.Text = "Закрыть после запуска";
            this.close.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Приоритет";
            // 
            // priority
            // 
            this.priority.FormattingEnabled = true;
            this.priority.Location = new System.Drawing.Point(100, 94);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(131, 21);
            this.priority.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 402);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.riCheck);
            this.Controls.Add(this.bxtCheck);
            this.Controls.Add(this.textparametres);
            this.Controls.Add(this.parametres);
            this.Controls.Add(this.bxtUpd);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button bxtUpd;
		private System.Windows.Forms.TextBox parametres;
		private System.Windows.Forms.Label textparametres;
		private System.Windows.Forms.CheckBox bxtCheck;
		private System.Windows.Forms.CheckBox riCheck;
		private System.Windows.Forms.TextBox path;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox close;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox priority;
	}
}

