namespace Gestion_de_contation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combsexe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combcours = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpointobt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textpointmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textApplication = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.activer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.combApplication = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbconduite = new System.Windows.Forms.ComboBox();
            this.cbclasse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textpourcentage = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // textnom
            // 
            this.textnom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textnom.BackColor = System.Drawing.Color.White;
            this.textnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom.Location = new System.Drawing.Point(305, 101);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(384, 27);
            this.textnom.TabIndex = 1;
            this.textnom.TextChanged += new System.EventHandler(this.textnom_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(785, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sexe";
            // 
            // combsexe
            // 
            this.combsexe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.combsexe.BackColor = System.Drawing.Color.White;
            this.combsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combsexe.FormattingEnabled = true;
            this.combsexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.combsexe.Location = new System.Drawing.Point(858, 101);
            this.combsexe.Name = "combsexe";
            this.combsexe.Size = new System.Drawing.Size(121, 28);
            this.combsexe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe";
            // 
            // combcours
            // 
            this.combcours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combcours.BackColor = System.Drawing.Color.White;
            this.combcours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combcours.FormattingEnabled = true;
            this.combcours.Items.AddRange(new object[] {
            "1ere annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "2eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "3eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "4eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "5eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "6eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "7eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie",
            "",
            "8eme annee",
            "Anglais",
            "Français",
            "Correspondance Anglaise",
            "Corresponance Francaise",
            "Géographie",
            "Histoire",
            "Informatique",
            "Déontologie",
            "Orgqnisqtion des Entreprises",
            "Physique",
            "Chimie",
            "Biologie",
            "Marketing",
            "Législation sociale",
            "Econimie politique",
            "Sport",
            "Dessin",
            "Statistique",
            "Zoologie"});
            this.combcours.Location = new System.Drawing.Point(344, 152);
            this.combcours.Name = "combcours";
            this.combcours.Size = new System.Drawing.Size(121, 28);
            this.combcours.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cours";
            // 
            // textpointobt
            // 
            this.textpointobt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textpointobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpointobt.Location = new System.Drawing.Point(205, 209);
            this.textpointobt.Multiline = true;
            this.textpointobt.Name = "textpointobt";
            this.textpointobt.Size = new System.Drawing.Size(260, 32);
            this.textpointobt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Point Obtenue";
            // 
            // textpointmax
            // 
            this.textpointmax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textpointmax.BackColor = System.Drawing.Color.White;
            this.textpointmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpointmax.Location = new System.Drawing.Point(205, 262);
            this.textpointmax.Multiline = true;
            this.textpointmax.Name = "textpointmax";
            this.textpointmax.Size = new System.Drawing.Size(260, 32);
            this.textpointmax.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Point Maximal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(421, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Application";
            // 
            // textApplication
            // 
            this.textApplication.BackColor = System.Drawing.Color.White;
            this.textApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApplication.Location = new System.Drawing.Point(565, 481);
            this.textApplication.Multiline = true;
            this.textApplication.Name = "textApplication";
            this.textApplication.Size = new System.Drawing.Size(260, 32);
            this.textApplication.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(338, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(318, 31);
            this.label11.TabIndex = 22;
            this.label11.Text = "FICHE DE COTATION";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(49, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 225);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // activer
            // 
            this.activer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activer.Image = ((System.Drawing.Image)(resources.GetObject("activer.Image")));
            this.activer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activer.Location = new System.Drawing.Point(250, 331);
            this.activer.Name = "activer";
            this.activer.Size = new System.Drawing.Size(167, 37);
            this.activer.TabIndex = 61;
            this.activer.Text = "Ajouter";
            this.activer.UseVisualStyleBackColor = true;
            this.activer.Click += new System.EventHandler(this.activer_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(440, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 62;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(814, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 37);
            this.button2.TabIndex = 64;
            this.button2.Text = "    Exporter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(627, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 37);
            this.button3.TabIndex = 63;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(990, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 45);
            this.button4.TabIndex = 66;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(58, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 37);
            this.button5.TabIndex = 67;
            this.button5.Text = "  Resultat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(509, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 22);
            this.label12.TabIndex = 68;
            this.label12.Text = "Conduite";
            // 
            // combApplication
            // 
            this.combApplication.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.combApplication.BackColor = System.Drawing.Color.White;
            this.combApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combApplication.FormattingEnabled = true;
            this.combApplication.Items.AddRange(new object[] {
            "TB",
            "B",
            "M"});
            this.combApplication.Location = new System.Drawing.Point(858, 156);
            this.combApplication.Name = "combApplication";
            this.combApplication.Size = new System.Drawing.Size(121, 28);
            this.combApplication.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(743, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 22);
            this.label13.TabIndex = 70;
            this.label13.Text = "Application";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 22);
            this.label14.TabIndex = 72;
            this.label14.Text = "Nom, Post-nom et Prenom";
            // 
            // cbconduite
            // 
            this.cbconduite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbconduite.BackColor = System.Drawing.Color.White;
            this.cbconduite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbconduite.FormattingEnabled = true;
            this.cbconduite.Items.AddRange(new object[] {
            "TB",
            "B",
            "M"});
            this.cbconduite.Location = new System.Drawing.Point(605, 156);
            this.cbconduite.Name = "cbconduite";
            this.cbconduite.Size = new System.Drawing.Size(121, 28);
            this.cbconduite.TabIndex = 73;
            // 
            // cbclasse
            // 
            this.cbclasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbclasse.BackColor = System.Drawing.Color.White;
            this.cbclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbclasse.FormattingEnabled = true;
            this.cbclasse.Items.AddRange(new object[] {
            "1ere annee",
            "2eme annee",
            "3eme annee",
            "4eme annee ",
            "5eme annee",
            "6eme annee",
            "7eme annee",
            "8eme annee"});
            this.cbclasse.Location = new System.Drawing.Point(133, 152);
            this.cbclasse.Name = "cbclasse";
            this.cbclasse.Size = new System.Drawing.Size(121, 28);
            this.cbclasse.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(566, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Pourcentage";
            // 
            // textpourcentage
            // 
            this.textpourcentage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textpourcentage.BackColor = System.Drawing.Color.White;
            this.textpourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpourcentage.Location = new System.Drawing.Point(707, 209);
            this.textpourcentage.Multiline = true;
            this.textpourcentage.Name = "textpourcentage";
            this.textpourcentage.Size = new System.Drawing.Size(274, 32);
            this.textpourcentage.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom, Post-nom et Prenom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sexe";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Classe";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cours";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Conduite";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Application";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Point Obtenue";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Point Maximal";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Pourcentage";
            this.Column9.Name = "Column9";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 611);
            this.Controls.Add(this.cbclasse);
            this.Controls.Add(this.cbconduite);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.combApplication);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textApplication);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textpourcentage);
            this.Controls.Add(this.textpointmax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textpointobt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combcours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combsexe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combsexe;
        private System.Windows.Forms.ComboBox combclasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combcours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpointobt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textpointmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textApplication;
        private System.Windows.Forms.TextBox combconduite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button activer;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button5;
       // private System.Windows.Forms.ComboBox combconduite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combApplication;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbconduite;
        private System.Windows.Forms.ComboBox cbclasse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textpourcentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}