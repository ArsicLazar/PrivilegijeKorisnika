
namespace PrivilegijeKorisnika
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
            this.cmdKorsnikInfo = new System.Windows.Forms.Button();
            this.cmdDodajKorisnika = new System.Windows.Forms.Button();
            this.cmdInfoProfil = new System.Windows.Forms.Button();
            this.cmdDodajProfil = new System.Windows.Forms.Button();
            this.cmdKorGrupa = new System.Windows.Forms.Button();
            this.cmdGrupaProfil = new System.Windows.Forms.Button();
            this.cmdNePokPri = new System.Windows.Forms.Button();
            this.cmdSistemProv = new System.Windows.Forms.Button();
            this.cmdPrivilegije = new System.Windows.Forms.Button();
            this.cmdInfoGrupa = new System.Windows.Forms.Button();
            this.cmdEmailAdr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdKorsnikInfo
            // 
            this.cmdKorsnikInfo.Location = new System.Drawing.Point(12, 12);
            this.cmdKorsnikInfo.Name = "cmdKorsnikInfo";
            this.cmdKorsnikInfo.Size = new System.Drawing.Size(216, 34);
            this.cmdKorsnikInfo.TabIndex = 0;
            this.cmdKorsnikInfo.Text = "Ucitaj_Informacije_Korisnika";
            this.cmdKorsnikInfo.UseVisualStyleBackColor = true;
            this.cmdKorsnikInfo.Click += new System.EventHandler(this.cmdKorsnikInfo_Click);
            // 
            // cmdDodajKorisnika
            // 
            this.cmdDodajKorisnika.Location = new System.Drawing.Point(264, 14);
            this.cmdDodajKorisnika.Name = "cmdDodajKorisnika";
            this.cmdDodajKorisnika.Size = new System.Drawing.Size(216, 32);
            this.cmdDodajKorisnika.TabIndex = 1;
            this.cmdDodajKorisnika.Text = "Dodaj_Korisnika";
            this.cmdDodajKorisnika.UseVisualStyleBackColor = true;
            this.cmdDodajKorisnika.Click += new System.EventHandler(this.cmdDodajKorisnika_Click);
            // 
            // cmdInfoProfil
            // 
            this.cmdInfoProfil.Location = new System.Drawing.Point(12, 174);
            this.cmdInfoProfil.Name = "cmdInfoProfil";
            this.cmdInfoProfil.Size = new System.Drawing.Size(216, 34);
            this.cmdInfoProfil.TabIndex = 2;
            this.cmdInfoProfil.Text = "Ucitaj_Informacije_Profila";
            this.cmdInfoProfil.UseVisualStyleBackColor = true;
            this.cmdInfoProfil.Click += new System.EventHandler(this.cmdInfoProfil_Click);
            // 
            // cmdDodajProfil
            // 
            this.cmdDodajProfil.Location = new System.Drawing.Point(264, 168);
            this.cmdDodajProfil.Name = "cmdDodajProfil";
            this.cmdDodajProfil.Size = new System.Drawing.Size(216, 31);
            this.cmdDodajProfil.TabIndex = 3;
            this.cmdDodajProfil.Text = "Dodaj_Profil";
            this.cmdDodajProfil.UseVisualStyleBackColor = true;
            this.cmdDodajProfil.Click += new System.EventHandler(this.cmdDodajProfil_Click);
            // 
            // cmdKorGrupa
            // 
            this.cmdKorGrupa.Location = new System.Drawing.Point(515, 15);
            this.cmdKorGrupa.Name = "cmdKorGrupa";
            this.cmdKorGrupa.Size = new System.Drawing.Size(216, 31);
            this.cmdKorGrupa.TabIndex = 4;
            this.cmdKorGrupa.Text = "Kor_Obuhvata_Grupu";
            this.cmdKorGrupa.UseVisualStyleBackColor = true;
            this.cmdKorGrupa.Click += new System.EventHandler(this.cmdKorGrupa_Click);
            // 
            // cmdGrupaProfil
            // 
            this.cmdGrupaProfil.Location = new System.Drawing.Point(515, 52);
            this.cmdGrupaProfil.Name = "cmdGrupaProfil";
            this.cmdGrupaProfil.Size = new System.Drawing.Size(216, 34);
            this.cmdGrupaProfil.TabIndex = 5;
            this.cmdGrupaProfil.Text = "Grupa_Poseduje_Profil";
            this.cmdGrupaProfil.UseVisualStyleBackColor = true;
            this.cmdGrupaProfil.Click += new System.EventHandler(this.cmdGrupaProfil_Click);
            // 
            // cmdNePokPri
            // 
            this.cmdNePokPri.Location = new System.Drawing.Point(12, 90);
            this.cmdNePokPri.Name = "cmdNePokPri";
            this.cmdNePokPri.Size = new System.Drawing.Size(216, 37);
            this.cmdNePokPri.TabIndex = 6;
            this.cmdNePokPri.Text = "Ucitaj_Neuspele_Pok";
            this.cmdNePokPri.UseVisualStyleBackColor = true;
            this.cmdNePokPri.Click += new System.EventHandler(this.cmdNePokPri_Click);
            // 
            // cmdSistemProv
            // 
            this.cmdSistemProv.Location = new System.Drawing.Point(12, 214);
            this.cmdSistemProv.Name = "cmdSistemProv";
            this.cmdSistemProv.Size = new System.Drawing.Size(216, 33);
            this.cmdSistemProv.TabIndex = 7;
            this.cmdSistemProv.Text = "Ucitaj_Sistem_Prov";
            this.cmdSistemProv.UseVisualStyleBackColor = true;
            this.cmdSistemProv.Click += new System.EventHandler(this.cmdSistemProv_Click);
            // 
            // cmdPrivilegije
            // 
            this.cmdPrivilegije.Location = new System.Drawing.Point(12, 133);
            this.cmdPrivilegije.Name = "cmdPrivilegije";
            this.cmdPrivilegije.Size = new System.Drawing.Size(216, 35);
            this.cmdPrivilegije.TabIndex = 8;
            this.cmdPrivilegije.Text = "Ucitaj_Privilegije";
            this.cmdPrivilegije.UseVisualStyleBackColor = true;
            this.cmdPrivilegije.Click += new System.EventHandler(this.cmdPrivilegije_Click);
            // 
            // cmdInfoGrupa
            // 
            this.cmdInfoGrupa.Location = new System.Drawing.Point(12, 52);
            this.cmdInfoGrupa.Name = "cmdInfoGrupa";
            this.cmdInfoGrupa.Size = new System.Drawing.Size(216, 32);
            this.cmdInfoGrupa.TabIndex = 9;
            this.cmdInfoGrupa.Text = "Ucitaj_Info_Grupe";
            this.cmdInfoGrupa.UseVisualStyleBackColor = true;
            this.cmdInfoGrupa.Click += new System.EventHandler(this.cmdInfoGrupa_Click);
            // 
            // cmdEmailAdr
            // 
            this.cmdEmailAdr.Location = new System.Drawing.Point(12, 253);
            this.cmdEmailAdr.Name = "cmdEmailAdr";
            this.cmdEmailAdr.Size = new System.Drawing.Size(216, 33);
            this.cmdEmailAdr.TabIndex = 10;
            this.cmdEmailAdr.Text = "Ucitaj_Email_Adr";
            this.cmdEmailAdr.UseVisualStyleBackColor = true;
            this.cmdEmailAdr.Click += new System.EventHandler(this.cmdEmailAdr_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1017, 484);
            this.Controls.Add(this.cmdEmailAdr);
            this.Controls.Add(this.cmdInfoGrupa);
            this.Controls.Add(this.cmdPrivilegije);
            this.Controls.Add(this.cmdSistemProv);
            this.Controls.Add(this.cmdNePokPri);
            this.Controls.Add(this.cmdGrupaProfil);
            this.Controls.Add(this.cmdKorGrupa);
            this.Controls.Add(this.cmdDodajProfil);
            this.Controls.Add(this.cmdInfoProfil);
            this.Controls.Add(this.cmdDodajKorisnika);
            this.Controls.Add(this.cmdKorsnikInfo);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInfoKorisnika;
        private System.Windows.Forms.Button cmdKorsnikInfo;
        private System.Windows.Forms.Button cmdDodajKorisnika;
        private System.Windows.Forms.Button cmdInfoProfil;
        private System.Windows.Forms.Button cmdDodajProfil;
        private System.Windows.Forms.Button cmdKorGrupa;
        private System.Windows.Forms.Button cmdGrupaProfil;
        private System.Windows.Forms.Button cmdNePokPri;
        private System.Windows.Forms.Button cmdSistemProv;
        private System.Windows.Forms.Button cmdPrivilegije;
        private System.Windows.Forms.Button cmdInfoGrupa;
        private System.Windows.Forms.Button cmdEmailAdr;
    }
}

