namespace Summative_2
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelScore.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(4, 8);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(593, 23);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score: ";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEnd.Location = new System.Drawing.Point(515, 4);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(82, 31);
            this.buttonEnd.TabIndex = 3;
            this.buttonEnd.Text = "Leave";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 16;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summative_2.Properties.Resources.BKG_Forest;
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.labelScore);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Timer timerGame;
    }
}
