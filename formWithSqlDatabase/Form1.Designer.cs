
namespace formWithSqlDatabase
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
            this.ddl_ids = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btConfirmer = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddl_ids
            // 
            this.ddl_ids.BackColor = System.Drawing.Color.White;
            this.ddl_ids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_ids.FormattingEnabled = true;
            this.ddl_ids.Location = new System.Drawing.Point(487, 108);
            this.ddl_ids.Name = "ddl_ids";
            this.ddl_ids.Size = new System.Drawing.Size(469, 48);
            this.ddl_ids.TabIndex = 30;
            this.ddl_ids.SelectedIndexChanged += new System.EventHandler(this.ddl_ids_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(133, 89);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(187, 56);
            this.ID.TabIndex = 29;
            this.ID.Text = "ID        :";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(1031, 561);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(176, 63);
            this.btAnnuler.TabIndex = 28;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btConfirmer
            // 
            this.btConfirmer.Location = new System.Drawing.Point(780, 561);
            this.btConfirmer.Name = "btConfirmer";
            this.btConfirmer.Size = new System.Drawing.Size(176, 63);
            this.btConfirmer.TabIndex = 27;
            this.btConfirmer.Text = "Confirmer";
            this.btConfirmer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConfirmer.UseVisualStyleBackColor = true;
            this.btConfirmer.Click += new System.EventHandler(this.btConfirmer_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(536, 561);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(176, 63);
            this.btSupprimer.TabIndex = 26;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(286, 561);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(176, 63);
            this.btModifier.TabIndex = 25;
            this.btModifier.Text = "Modifier";
            this.btModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(31, 561);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(176, 63);
            this.btAjouter.TabIndex = 24;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(487, 410);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(469, 48);
            this.txtAge.TabIndex = 23;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(133, 395);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(185, 56);
            this.age.TabIndex = 22;
            this.age.Text = "Age     :";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // txtCin
            // 
            this.txtCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCin.Location = new System.Drawing.Point(487, 308);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(469, 48);
            this.txtCin.TabIndex = 21;
            this.txtCin.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // cin
            // 
            this.cin.AutoSize = true;
            this.cin.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin.Location = new System.Drawing.Point(133, 295);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(192, 56);
            this.cin.TabIndex = 20;
            this.cin.Text = "CIN      :";
            this.cin.Click += new System.EventHandler(this.nom_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(487, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(469, 48);
            this.txtName.TabIndex = 19;
            this.txtName.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(133, 197);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(187, 56);
            this.prenom.TabIndex = 18;
            this.prenom.Text = "Name  :";
            this.prenom.Click += new System.EventHandler(this.prenom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 732);
            this.Controls.Add(this.ddl_ids);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btConfirmer);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.age);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.prenom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_ids;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btConfirmer;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.Label cin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label prenom;
    }
}

