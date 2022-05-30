
namespace NIM
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
            this.sirka1btn = new System.Windows.Forms.Button();
            this.sirka2btn = new System.Windows.Forms.Button();
            this.sirka3btn = new System.Windows.Forms.Button();
            this.sirka1pb = new System.Windows.Forms.PictureBox();
            this.sirka3pb = new System.Windows.Forms.PictureBox();
            this.sirka2pb = new System.Windows.Forms.PictureBox();
            this.Startgame = new System.Windows.Forms.Button();
            this.sirkaboxpb = new System.Windows.Forms.PictureBox();
            this.sirkylbl = new System.Windows.Forms.Label();
            this.numlbl = new System.Windows.Forms.Label();
            this.gamelostlbl = new System.Windows.Forms.Label();
            this.gamewonlbl = new System.Windows.Forms.Label();
            this.again = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sirka1pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka3pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka2pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirkaboxpb)).BeginInit();
            this.SuspendLayout();
            // 
            // sirka1btn
            // 
            this.sirka1btn.Location = new System.Drawing.Point(100, 384);
            this.sirka1btn.Name = "sirka1btn";
            this.sirka1btn.Size = new System.Drawing.Size(120, 39);
            this.sirka1btn.TabIndex = 0;
            this.sirka1btn.Text = "Vzit 1 sirku";
            this.sirka1btn.UseVisualStyleBackColor = true;
            this.sirka1btn.Visible = false;
            this.sirka1btn.Click += new System.EventHandler(this.sirka1btn_Click);
            // 
            // sirka2btn
            // 
            this.sirka2btn.Location = new System.Drawing.Point(365, 384);
            this.sirka2btn.Name = "sirka2btn";
            this.sirka2btn.Size = new System.Drawing.Size(120, 39);
            this.sirka2btn.TabIndex = 1;
            this.sirka2btn.Text = "Vzit 2 sirky";
            this.sirka2btn.UseVisualStyleBackColor = true;
            this.sirka2btn.Visible = false;
            this.sirka2btn.Click += new System.EventHandler(this.sirka2btn_Click);
            // 
            // sirka3btn
            // 
            this.sirka3btn.Location = new System.Drawing.Point(641, 384);
            this.sirka3btn.Name = "sirka3btn";
            this.sirka3btn.Size = new System.Drawing.Size(120, 39);
            this.sirka3btn.TabIndex = 2;
            this.sirka3btn.Text = "Vzit 3 sirky";
            this.sirka3btn.UseVisualStyleBackColor = true;
            this.sirka3btn.Visible = false;
            this.sirka3btn.Click += new System.EventHandler(this.sirka3btn_Click);
            // 
            // sirka1pb
            // 
            this.sirka1pb.Image = ((System.Drawing.Image)(resources.GetObject("sirka1pb.Image")));
            this.sirka1pb.Location = new System.Drawing.Point(100, 429);
            this.sirka1pb.Name = "sirka1pb";
            this.sirka1pb.Size = new System.Drawing.Size(120, 100);
            this.sirka1pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirka1pb.TabIndex = 3;
            this.sirka1pb.TabStop = false;
            this.sirka1pb.Visible = false;
            // 
            // sirka3pb
            // 
            this.sirka3pb.Image = ((System.Drawing.Image)(resources.GetObject("sirka3pb.Image")));
            this.sirka3pb.Location = new System.Drawing.Point(641, 429);
            this.sirka3pb.Name = "sirka3pb";
            this.sirka3pb.Size = new System.Drawing.Size(120, 100);
            this.sirka3pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirka3pb.TabIndex = 4;
            this.sirka3pb.TabStop = false;
            this.sirka3pb.Visible = false;
            // 
            // sirka2pb
            // 
            this.sirka2pb.Image = ((System.Drawing.Image)(resources.GetObject("sirka2pb.Image")));
            this.sirka2pb.Location = new System.Drawing.Point(365, 429);
            this.sirka2pb.Name = "sirka2pb";
            this.sirka2pb.Size = new System.Drawing.Size(120, 100);
            this.sirka2pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirka2pb.TabIndex = 5;
            this.sirka2pb.TabStop = false;
            this.sirka2pb.Visible = false;
            // 
            // Startgame
            // 
            this.Startgame.Location = new System.Drawing.Point(365, 244);
            this.Startgame.Name = "Startgame";
            this.Startgame.Size = new System.Drawing.Size(120, 39);
            this.Startgame.TabIndex = 6;
            this.Startgame.Text = "Start Game";
            this.Startgame.UseVisualStyleBackColor = true;
            this.Startgame.Click += new System.EventHandler(this.Startgame_Click);
            // 
            // sirkaboxpb
            // 
            this.sirkaboxpb.Image = ((System.Drawing.Image)(resources.GetObject("sirkaboxpb.Image")));
            this.sirkaboxpb.Location = new System.Drawing.Point(365, 68);
            this.sirkaboxpb.Name = "sirkaboxpb";
            this.sirkaboxpb.Size = new System.Drawing.Size(120, 100);
            this.sirkaboxpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirkaboxpb.TabIndex = 7;
            this.sirkaboxpb.TabStop = false;
            this.sirkaboxpb.Visible = false;
            // 
            // sirkylbl
            // 
            this.sirkylbl.AutoSize = true;
            this.sirkylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sirkylbl.Location = new System.Drawing.Point(402, 9);
            this.sirkylbl.Name = "sirkylbl";
            this.sirkylbl.Size = new System.Drawing.Size(45, 21);
            this.sirkylbl.TabIndex = 8;
            this.sirkylbl.Text = "Sirky";
            this.sirkylbl.Visible = false;
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numlbl.Location = new System.Drawing.Point(405, 45);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(38, 20);
            this.numlbl.TabIndex = 9;
            this.numlbl.Text = "num";
            this.numlbl.Visible = false;
            // 
            // gamelostlbl
            // 
            this.gamelostlbl.AutoSize = true;
            this.gamelostlbl.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamelostlbl.Location = new System.Drawing.Point(217, 206);
            this.gamelostlbl.Name = "gamelostlbl";
            this.gamelostlbl.Size = new System.Drawing.Size(425, 89);
            this.gamelostlbl.TabIndex = 10;
            this.gamelostlbl.Text = "PROHRAL JSI";
            this.gamelostlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gamelostlbl.Visible = false;
            // 
            // gamewonlbl
            // 
            this.gamewonlbl.AutoSize = true;
            this.gamewonlbl.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamewonlbl.Location = new System.Drawing.Point(237, 206);
            this.gamewonlbl.Name = "gamewonlbl";
            this.gamewonlbl.Size = new System.Drawing.Size(376, 89);
            this.gamewonlbl.TabIndex = 11;
            this.gamewonlbl.Text = "VYHRAL JSI";
            this.gamewonlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gamewonlbl.Visible = false;
            // 
            // again
            // 
            this.again.Location = new System.Drawing.Point(43, 244);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(120, 39);
            this.again.TabIndex = 12;
            this.again.Text = "Hrat znova";
            this.again.UseVisualStyleBackColor = true;
            this.again.Visible = false;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(719, 244);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(120, 39);
            this.end.TabIndex = 13;
            this.end.Text = "Ukoncit hru";
            this.end.UseVisualStyleBackColor = true;
            this.end.Visible = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.end);
            this.Controls.Add(this.again);
            this.Controls.Add(this.gamewonlbl);
            this.Controls.Add(this.gamelostlbl);
            this.Controls.Add(this.numlbl);
            this.Controls.Add(this.sirkylbl);
            this.Controls.Add(this.sirkaboxpb);
            this.Controls.Add(this.Startgame);
            this.Controls.Add(this.sirka2pb);
            this.Controls.Add(this.sirka3pb);
            this.Controls.Add(this.sirka1pb);
            this.Controls.Add(this.sirka3btn);
            this.Controls.Add(this.sirka2btn);
            this.Controls.Add(this.sirka1btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NIM";
            ((System.ComponentModel.ISupportInitialize)(this.sirka1pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka3pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka2pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirkaboxpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sirka1btn;
        private System.Windows.Forms.Button sirka2btn;
        private System.Windows.Forms.Button sirka3btn;
        private System.Windows.Forms.PictureBox sirka1pb;
        private System.Windows.Forms.PictureBox sirka3pb;
        private System.Windows.Forms.PictureBox sirka2pb;
        private System.Windows.Forms.Button Startgame;
        private System.Windows.Forms.PictureBox sirkaboxpb;
        private System.Windows.Forms.Label sirkylbl;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.Label gamelostlbl;
        private System.Windows.Forms.Label gamewonlbl;
        private System.Windows.Forms.Button again;
        private System.Windows.Forms.Button end;
    }
}

