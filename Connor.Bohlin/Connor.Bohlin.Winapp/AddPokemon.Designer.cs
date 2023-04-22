namespace Connor.Bohlin.Winapp
{
    partial class AddPokemon
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.txtPokemonType = new System.Windows.Forms.TextBox();
            this.txtPokemonNature = new System.Windows.Forms.TextBox();
            this.txtPokemonGender = new System.Windows.Forms.TextBox();
            this.txtPokemonLevel = new System.Windows.Forms.TextBox();
            this.lblPokemonName = new System.Windows.Forms.Label();
            this.lvlPokemonType = new System.Windows.Forms.Label();
            this.lblPokemonNature = new System.Windows.Forms.Label();
            this.lblPokemonGender = new System.Windows.Forms.Label();
            this.lblPokemonLevel = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(519, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(643, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.Location = new System.Drawing.Point(65, 42);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(100, 20);
            this.txtPokemonName.TabIndex = 2;
            // 
            // txtPokemonType
            // 
            this.txtPokemonType.Location = new System.Drawing.Point(228, 42);
            this.txtPokemonType.Name = "txtPokemonType";
            this.txtPokemonType.Size = new System.Drawing.Size(100, 20);
            this.txtPokemonType.TabIndex = 3;
            // 
            // txtPokemonNature
            // 
            this.txtPokemonNature.Location = new System.Drawing.Point(375, 42);
            this.txtPokemonNature.Name = "txtPokemonNature";
            this.txtPokemonNature.Size = new System.Drawing.Size(100, 20);
            this.txtPokemonNature.TabIndex = 4;
            // 
            // txtPokemonGender
            // 
            this.txtPokemonGender.Location = new System.Drawing.Point(519, 42);
            this.txtPokemonGender.Name = "txtPokemonGender";
            this.txtPokemonGender.Size = new System.Drawing.Size(100, 20);
            this.txtPokemonGender.TabIndex = 5;
            // 
            // txtPokemonLevel
            // 
            this.txtPokemonLevel.Location = new System.Drawing.Point(643, 42);
            this.txtPokemonLevel.Name = "txtPokemonLevel";
            this.txtPokemonLevel.Size = new System.Drawing.Size(100, 20);
            this.txtPokemonLevel.TabIndex = 6;
            // 
            // lblPokemonName
            // 
            this.lblPokemonName.AutoSize = true;
            this.lblPokemonName.Location = new System.Drawing.Point(62, 26);
            this.lblPokemonName.Name = "lblPokemonName";
            this.lblPokemonName.Size = new System.Drawing.Size(83, 13);
            this.lblPokemonName.TabIndex = 7;
            this.lblPokemonName.Text = "Pokemon Name";
            // 
            // lvlPokemonType
            // 
            this.lvlPokemonType.AutoSize = true;
            this.lvlPokemonType.Location = new System.Drawing.Point(225, 26);
            this.lvlPokemonType.Name = "lvlPokemonType";
            this.lvlPokemonType.Size = new System.Drawing.Size(79, 13);
            this.lvlPokemonType.TabIndex = 8;
            this.lvlPokemonType.Text = "Pokemon Type";
            // 
            // lblPokemonNature
            // 
            this.lblPokemonNature.AutoSize = true;
            this.lblPokemonNature.Location = new System.Drawing.Point(372, 26);
            this.lblPokemonNature.Name = "lblPokemonNature";
            this.lblPokemonNature.Size = new System.Drawing.Size(87, 13);
            this.lblPokemonNature.TabIndex = 9;
            this.lblPokemonNature.Text = "Pokemon Nature";
            // 
            // lblPokemonGender
            // 
            this.lblPokemonGender.AutoSize = true;
            this.lblPokemonGender.Location = new System.Drawing.Point(516, 26);
            this.lblPokemonGender.Name = "lblPokemonGender";
            this.lblPokemonGender.Size = new System.Drawing.Size(90, 13);
            this.lblPokemonGender.TabIndex = 10;
            this.lblPokemonGender.Text = "Pokemon Gender";
            // 
            // lblPokemonLevel
            // 
            this.lblPokemonLevel.AutoSize = true;
            this.lblPokemonLevel.Location = new System.Drawing.Point(640, 26);
            this.lblPokemonLevel.Name = "lblPokemonLevel";
            this.lblPokemonLevel.Size = new System.Drawing.Size(81, 13);
            this.lblPokemonLevel.TabIndex = 11;
            this.lblPokemonLevel.Text = "Pokemon Level";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(328, 114);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Visible = false;
            // 
            // AddPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 220);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPokemonLevel);
            this.Controls.Add(this.lblPokemonGender);
            this.Controls.Add(this.lblPokemonNature);
            this.Controls.Add(this.lvlPokemonType);
            this.Controls.Add(this.lblPokemonName);
            this.Controls.Add(this.txtPokemonLevel);
            this.Controls.Add(this.txtPokemonGender);
            this.Controls.Add(this.txtPokemonNature);
            this.Controls.Add(this.txtPokemonType);
            this.Controls.Add(this.txtPokemonName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddPokemon";
            this.Text = "AddPokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPokemonName;
        private System.Windows.Forms.TextBox txtPokemonType;
        private System.Windows.Forms.TextBox txtPokemonNature;
        private System.Windows.Forms.TextBox txtPokemonGender;
        private System.Windows.Forms.TextBox txtPokemonLevel;
        private System.Windows.Forms.Label lblPokemonName;
        private System.Windows.Forms.Label lvlPokemonType;
        private System.Windows.Forms.Label lblPokemonNature;
        private System.Windows.Forms.Label lblPokemonGender;
        private System.Windows.Forms.Label lblPokemonLevel;
        private System.Windows.Forms.Label lblMessage;
    }
}