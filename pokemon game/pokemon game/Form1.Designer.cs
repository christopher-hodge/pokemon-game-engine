namespace pokemon_game
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
            this.Gen = new System.Windows.Forms.Button();
            this.pokemonDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(300, 302);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(163, 23);
            this.Gen.TabIndex = 0;
            this.Gen.Text = "Generate Pokemon";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Generate);
            // 
            // pokemonDisplayInfo
            // 
            this.pokemonDisplayInfo.Location = new System.Drawing.Point(12, 41);
            this.pokemonDisplayInfo.Name = "pokemonDisplayInfo";
            this.pokemonDisplayInfo.ReadOnly = true;
            this.pokemonDisplayInfo.Size = new System.Drawing.Size(776, 255);
            this.pokemonDisplayInfo.TabIndex = 1;
            this.pokemonDisplayInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pokemonDisplayInfo);
            this.Controls.Add(this.Gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.RichTextBox pokemonDisplayInfo;
    }
}

