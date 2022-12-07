
namespace SQLIHM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConnectBTN = new System.Windows.Forms.Button();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.txtBoxDB = new System.Windows.Forms.TextBox();
            this.txtBoxUID = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelDB = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxConnectBDD = new System.Windows.Forms.GroupBox();
            this.groupBoxAddMember = new System.Windows.Forms.GroupBox();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.txtBoxSexe = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxMemberList = new System.Windows.Forms.GroupBox();
            this.listViewMembre = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonActualiser = new System.Windows.Forms.Button();
            this.groupBoxRecherche = new System.Windows.Forms.GroupBox();
            this.buttonSearchNom = new System.Windows.Forms.Button();
            this.textBoxNomSearch = new System.Windows.Forms.TextBox();
            this.labelNomSearch = new System.Windows.Forms.Label();
            this.buttonSearchNomAge = new System.Windows.Forms.Button();
            this.textBoxSearchNom2 = new System.Windows.Forms.TextBox();
            this.labelNomAgeSearch = new System.Windows.Forms.Label();
            this.buttonSearchID = new System.Windows.Forms.Button();
            this.textBoxIDSearch = new System.Windows.Forms.TextBox();
            this.labelIDSearch = new System.Windows.Forms.Label();
            this.buttonSearchAge = new System.Windows.Forms.Button();
            this.textBoxAgeSearch = new System.Windows.Forms.TextBox();
            this.labelAgeSearch = new System.Windows.Forms.Label();
            this.textBoxSearchAge2 = new System.Windows.Forms.TextBox();
            this.groupBoxConnectBDD.SuspendLayout();
            this.groupBoxAddMember.SuspendLayout();
            this.groupBoxMemberList.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.groupBoxRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Location = new System.Drawing.Point(36, 139);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(120, 23);
            this.ConnectBTN.TabIndex = 0;
            this.ConnectBTN.Text = "Se connecter";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.Location = new System.Drawing.Point(71, 26);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(120, 20);
            this.txtBoxHost.TabIndex = 1;
            // 
            // txtBoxDB
            // 
            this.txtBoxDB.Location = new System.Drawing.Point(71, 52);
            this.txtBoxDB.Name = "txtBoxDB";
            this.txtBoxDB.Size = new System.Drawing.Size(120, 20);
            this.txtBoxDB.TabIndex = 2;
            // 
            // txtBoxUID
            // 
            this.txtBoxUID.Location = new System.Drawing.Point(71, 78);
            this.txtBoxUID.Name = "txtBoxUID";
            this.txtBoxUID.Size = new System.Drawing.Size(120, 20);
            this.txtBoxUID.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(71, 104);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(120, 20);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(30, 29);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(35, 13);
            this.labelHost.TabIndex = 5;
            this.labelHost.Text = "Host :";
            // 
            // labelDB
            // 
            this.labelDB.AutoSize = true;
            this.labelDB.Location = new System.Drawing.Point(30, 55);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(28, 13);
            this.labelDB.TabIndex = 6;
            this.labelDB.Text = "DB :";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(30, 78);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(32, 13);
            this.labelUID.TabIndex = 7;
            this.labelUID.Text = "UID :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 107);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password :";
            // 
            // groupBoxConnectBDD
            // 
            this.groupBoxConnectBDD.Controls.Add(this.labelPassword);
            this.groupBoxConnectBDD.Controls.Add(this.ConnectBTN);
            this.groupBoxConnectBDD.Controls.Add(this.labelUID);
            this.groupBoxConnectBDD.Controls.Add(this.txtBoxPassword);
            this.groupBoxConnectBDD.Controls.Add(this.labelHost);
            this.groupBoxConnectBDD.Controls.Add(this.txtBoxHost);
            this.groupBoxConnectBDD.Controls.Add(this.labelDB);
            this.groupBoxConnectBDD.Controls.Add(this.txtBoxDB);
            this.groupBoxConnectBDD.Controls.Add(this.txtBoxUID);
            this.groupBoxConnectBDD.Location = new System.Drawing.Point(576, 13);
            this.groupBoxConnectBDD.Name = "groupBoxConnectBDD";
            this.groupBoxConnectBDD.Size = new System.Drawing.Size(200, 178);
            this.groupBoxConnectBDD.TabIndex = 6;
            this.groupBoxConnectBDD.TabStop = false;
            this.groupBoxConnectBDD.Text = "Connexion BDD";
            // 
            // groupBoxAddMember
            // 
            this.groupBoxAddMember.Controls.Add(this.btnAjouterMembre);
            this.groupBoxAddMember.Controls.Add(this.txtBoxSexe);
            this.groupBoxAddMember.Controls.Add(this.txtBoxAge);
            this.groupBoxAddMember.Controls.Add(this.txtBoxPrenom);
            this.groupBoxAddMember.Controls.Add(this.txtBoxNom);
            this.groupBoxAddMember.Controls.Add(this.labelSexe);
            this.groupBoxAddMember.Controls.Add(this.labelage);
            this.groupBoxAddMember.Controls.Add(this.labelPrenom);
            this.groupBoxAddMember.Controls.Add(this.labelNom);
            this.groupBoxAddMember.Location = new System.Drawing.Point(13, 13);
            this.groupBoxAddMember.Name = "groupBoxAddMember";
            this.groupBoxAddMember.Size = new System.Drawing.Size(194, 177);
            this.groupBoxAddMember.TabIndex = 7;
            this.groupBoxAddMember.TabStop = false;
            this.groupBoxAddMember.Text = "Ajouter membre";
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.Location = new System.Drawing.Point(43, 138);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(93, 23);
            this.btnAjouterMembre.TabIndex = 8;
            this.btnAjouterMembre.Text = "Ajouter";
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            this.btnAjouterMembre.Click += new System.EventHandler(this.btnAjouterMembre_Click);
            // 
            // txtBoxSexe
            // 
            this.txtBoxSexe.Location = new System.Drawing.Point(77, 102);
            this.txtBoxSexe.Name = "txtBoxSexe";
            this.txtBoxSexe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSexe.TabIndex = 7;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(77, 76);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAge.TabIndex = 6;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(77, 50);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenom.TabIndex = 5;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(77, 24);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 4;
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(7, 106);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(37, 13);
            this.labelSexe.TabIndex = 3;
            this.labelSexe.Text = "Sexe :";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Location = new System.Drawing.Point(7, 80);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(32, 13);
            this.labelage.TabIndex = 2;
            this.labelage.Text = "Âge :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(6, 54);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(9, 27);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // groupBoxMemberList
            // 
            this.groupBoxMemberList.Controls.Add(this.listViewMembre);
            this.groupBoxMemberList.Location = new System.Drawing.Point(13, 217);
            this.groupBoxMemberList.Name = "groupBoxMemberList";
            this.groupBoxMemberList.Size = new System.Drawing.Size(763, 239);
            this.groupBoxMemberList.TabIndex = 8;
            this.groupBoxMemberList.TabStop = false;
            this.groupBoxMemberList.Text = "Liste des membres";
            // 
            // listViewMembre
            // 
            this.listViewMembre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNom,
            this.columnHeaderPrenom,
            this.columnHeaderAge,
            this.columnHeaderSexe});
            this.listViewMembre.ContextMenuStrip = this.contextMenuStripListView;
            this.listViewMembre.FullRowSelect = true;
            this.listViewMembre.HideSelection = false;
            this.listViewMembre.Location = new System.Drawing.Point(7, 19);
            this.listViewMembre.MultiSelect = false;
            this.listViewMembre.Name = "listViewMembre";
            this.listViewMembre.Size = new System.Drawing.Size(750, 214);
            this.listViewMembre.TabIndex = 0;
            this.listViewMembre.UseCompatibleStateImageBehavior = false;
            this.listViewMembre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Nom";
            this.columnHeaderNom.Width = 146;
            // 
            // columnHeaderPrenom
            // 
            this.columnHeaderPrenom.Text = "Prénom";
            this.columnHeaderPrenom.Width = 137;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Âge";
            // 
            // columnHeaderSexe
            // 
            this.columnHeaderSexe.Text = "Sexe";
            this.columnHeaderSexe.Width = 80;
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outilsToolStripMenuItem});
            this.contextMenuStripListView.Name = "contextMenuStrip1";
            this.contextMenuStripListView.Size = new System.Drawing.Size(106, 26);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem1,
            this.editerToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editerToolStripMenuItem.Text = "Editer";
            this.editerToolStripMenuItem.Click += new System.EventHandler(this.editerToolStripMenuItem_Click);
            // 
            // buttonActualiser
            // 
            this.buttonActualiser.Location = new System.Drawing.Point(691, 197);
            this.buttonActualiser.Name = "buttonActualiser";
            this.buttonActualiser.Size = new System.Drawing.Size(85, 23);
            this.buttonActualiser.TabIndex = 9;
            this.buttonActualiser.Text = "Actualiser";
            this.buttonActualiser.UseVisualStyleBackColor = true;
            this.buttonActualiser.Click += new System.EventHandler(this.buttonActualiser_Click);
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.Controls.Add(this.textBoxSearchAge2);
            this.groupBoxRecherche.Controls.Add(this.buttonSearchAge);
            this.groupBoxRecherche.Controls.Add(this.buttonSearchNomAge);
            this.groupBoxRecherche.Controls.Add(this.textBoxAgeSearch);
            this.groupBoxRecherche.Controls.Add(this.labelAgeSearch);
            this.groupBoxRecherche.Controls.Add(this.textBoxSearchNom2);
            this.groupBoxRecherche.Controls.Add(this.labelNomAgeSearch);
            this.groupBoxRecherche.Controls.Add(this.buttonSearchID);
            this.groupBoxRecherche.Controls.Add(this.buttonSearchNom);
            this.groupBoxRecherche.Controls.Add(this.textBoxIDSearch);
            this.groupBoxRecherche.Controls.Add(this.labelIDSearch);
            this.groupBoxRecherche.Controls.Add(this.textBoxNomSearch);
            this.groupBoxRecherche.Controls.Add(this.labelNomSearch);
            this.groupBoxRecherche.Location = new System.Drawing.Point(214, 13);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Size = new System.Drawing.Size(356, 177);
            this.groupBoxRecherche.TabIndex = 10;
            this.groupBoxRecherche.TabStop = false;
            this.groupBoxRecherche.Text = "Recherche Avancée";
            // 
            // buttonSearchNom
            // 
            this.buttonSearchNom.Location = new System.Drawing.Point(248, 50);
            this.buttonSearchNom.Name = "buttonSearchNom";
            this.buttonSearchNom.Size = new System.Drawing.Size(94, 23);
            this.buttonSearchNom.TabIndex = 8;
            this.buttonSearchNom.Text = "Rechercher";
            this.buttonSearchNom.UseVisualStyleBackColor = true;
            this.buttonSearchNom.Click += new System.EventHandler(this.buttonSearchNom_Click);
            // 
            // textBoxNomSearch
            // 
            this.textBoxNomSearch.Location = new System.Drawing.Point(38, 48);
            this.textBoxNomSearch.Name = "textBoxNomSearch";
            this.textBoxNomSearch.Size = new System.Drawing.Size(186, 20);
            this.textBoxNomSearch.TabIndex = 7;
            // 
            // labelNomSearch
            // 
            this.labelNomSearch.AutoSize = true;
            this.labelNomSearch.Location = new System.Drawing.Point(3, 55);
            this.labelNomSearch.Name = "labelNomSearch";
            this.labelNomSearch.Size = new System.Drawing.Size(35, 13);
            this.labelNomSearch.TabIndex = 6;
            this.labelNomSearch.Text = "Nom :";
            // 
            // buttonSearchNomAge
            // 
            this.buttonSearchNomAge.Location = new System.Drawing.Point(248, 143);
            this.buttonSearchNomAge.Name = "buttonSearchNomAge";
            this.buttonSearchNomAge.Size = new System.Drawing.Size(94, 23);
            this.buttonSearchNomAge.TabIndex = 5;
            this.buttonSearchNomAge.Text = "Rechercher";
            this.buttonSearchNomAge.UseVisualStyleBackColor = true;
            this.buttonSearchNomAge.Click += new System.EventHandler(this.buttonSearchNomAge_Click);
            // 
            // textBoxSearchNom2
            // 
            this.textBoxSearchNom2.Location = new System.Drawing.Point(82, 139);
            this.textBoxSearchNom2.Name = "textBoxSearchNom2";
            this.textBoxSearchNom2.Size = new System.Drawing.Size(99, 20);
            this.textBoxSearchNom2.TabIndex = 4;
            // 
            // labelNomAgeSearch
            // 
            this.labelNomAgeSearch.AutoSize = true;
            this.labelNomAgeSearch.Location = new System.Drawing.Point(7, 143);
            this.labelNomAgeSearch.Name = "labelNomAgeSearch";
            this.labelNomAgeSearch.Size = new System.Drawing.Size(69, 13);
            this.labelNomAgeSearch.TabIndex = 3;
            this.labelNomAgeSearch.Text = "Nom et Âge :";
            // 
            // buttonSearchID
            // 
            this.buttonSearchID.Location = new System.Drawing.Point(248, 21);
            this.buttonSearchID.Name = "buttonSearchID";
            this.buttonSearchID.Size = new System.Drawing.Size(94, 23);
            this.buttonSearchID.TabIndex = 2;
            this.buttonSearchID.Text = "Rechercher";
            this.buttonSearchID.UseVisualStyleBackColor = true;
            this.buttonSearchID.Click += new System.EventHandler(this.buttonSearchID_Click);
            // 
            // textBoxIDSearch
            // 
            this.textBoxIDSearch.Location = new System.Drawing.Point(38, 24);
            this.textBoxIDSearch.Name = "textBoxIDSearch";
            this.textBoxIDSearch.Size = new System.Drawing.Size(186, 20);
            this.textBoxIDSearch.TabIndex = 1;
            // 
            // labelIDSearch
            // 
            this.labelIDSearch.AutoSize = true;
            this.labelIDSearch.Location = new System.Drawing.Point(7, 27);
            this.labelIDSearch.Name = "labelIDSearch";
            this.labelIDSearch.Size = new System.Drawing.Size(24, 13);
            this.labelIDSearch.TabIndex = 0;
            this.labelIDSearch.Text = "ID :";
            // 
            // buttonSearchAge
            // 
            this.buttonSearchAge.Location = new System.Drawing.Point(248, 79);
            this.buttonSearchAge.Name = "buttonSearchAge";
            this.buttonSearchAge.Size = new System.Drawing.Size(94, 23);
            this.buttonSearchAge.TabIndex = 11;
            this.buttonSearchAge.Text = "Rechercher";
            this.buttonSearchAge.UseVisualStyleBackColor = true;
            this.buttonSearchAge.Click += new System.EventHandler(this.buttonSearchAge_Click);
            // 
            // textBoxAgeSearch
            // 
            this.textBoxAgeSearch.Location = new System.Drawing.Point(38, 77);
            this.textBoxAgeSearch.Name = "textBoxAgeSearch";
            this.textBoxAgeSearch.Size = new System.Drawing.Size(186, 20);
            this.textBoxAgeSearch.TabIndex = 10;
            // 
            // labelAgeSearch
            // 
            this.labelAgeSearch.AutoSize = true;
            this.labelAgeSearch.Location = new System.Drawing.Point(6, 84);
            this.labelAgeSearch.Name = "labelAgeSearch";
            this.labelAgeSearch.Size = new System.Drawing.Size(32, 13);
            this.labelAgeSearch.TabIndex = 9;
            this.labelAgeSearch.Text = "Âge :";
            // 
            // textBoxSearchAge2
            // 
            this.textBoxSearchAge2.Location = new System.Drawing.Point(187, 140);
            this.textBoxSearchAge2.Name = "textBoxSearchAge2";
            this.textBoxSearchAge2.Size = new System.Drawing.Size(55, 20);
            this.textBoxSearchAge2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 468);
            this.Controls.Add(this.groupBoxRecherche);
            this.Controls.Add(this.buttonActualiser);
            this.Controls.Add(this.groupBoxMemberList);
            this.Controls.Add(this.groupBoxAddMember);
            this.Controls.Add(this.groupBoxConnectBDD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PHPMyAdmin App";
            this.groupBoxConnectBDD.ResumeLayout(false);
            this.groupBoxConnectBDD.PerformLayout();
            this.groupBoxAddMember.ResumeLayout(false);
            this.groupBoxAddMember.PerformLayout();
            this.groupBoxMemberList.ResumeLayout(false);
            this.contextMenuStripListView.ResumeLayout(false);
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectBTN;
        private System.Windows.Forms.TextBox txtBoxHost;
        private System.Windows.Forms.TextBox txtBoxDB;
        private System.Windows.Forms.TextBox txtBoxUID;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.GroupBox groupBoxConnectBDD;
        private System.Windows.Forms.GroupBox groupBoxAddMember;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.TextBox txtBoxSexe;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.GroupBox groupBoxMemberList;
        private System.Windows.Forms.ListView listViewMembre;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenom;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderSexe;
        private System.Windows.Forms.Button buttonActualiser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxRecherche;
        private System.Windows.Forms.Button buttonSearchNom;
        private System.Windows.Forms.TextBox textBoxNomSearch;
        private System.Windows.Forms.Label labelNomSearch;
        private System.Windows.Forms.Button buttonSearchNomAge;
        private System.Windows.Forms.TextBox textBoxSearchNom2;
        private System.Windows.Forms.Label labelNomAgeSearch;
        private System.Windows.Forms.Button buttonSearchID;
        private System.Windows.Forms.TextBox textBoxIDSearch;
        private System.Windows.Forms.Label labelIDSearch;
        private System.Windows.Forms.Button buttonSearchAge;
        private System.Windows.Forms.TextBox textBoxAgeSearch;
        private System.Windows.Forms.Label labelAgeSearch;
        private System.Windows.Forms.TextBox textBoxSearchAge2;
    }
}

