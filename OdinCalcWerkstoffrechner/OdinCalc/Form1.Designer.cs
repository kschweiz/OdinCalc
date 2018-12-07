namespace OdinCalc
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonMaterialListe = new System.Windows.Forms.RadioButton();
            this.radioButtonManuel = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.bt_clearAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gewicht = new System.Windows.Forms.TextBox();
            this.tb_volumen = new System.Windows.Forms.TextBox();
            this.tb_dichte = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clearList = new System.Windows.Forms.Button();
            this.lv_Materialien = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_erstellenMaterialName = new System.Windows.Forms.TextBox();
            this.tb_erstellenDichte = new System.Windows.Forms.TextBox();
            this.tb_erstellenWerkstoffklasse = new System.Windows.Forms.TextBox();
            this.bt_newMaterial = new System.Windows.Forms.Button();
            this.btn_deleteMaterial = new System.Windows.Forms.Button();
            this.lv_materialListe = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clearDichteFeld = new System.Windows.Forms.Button();
            this.btn_clearVolumenFeld = new System.Windows.Forms.Button();
            this.btn_clearMasseFeld = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMaterialListe
            // 
            this.radioButtonMaterialListe.AutoSize = true;
            this.radioButtonMaterialListe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaterialListe.Location = new System.Drawing.Point(23, 9);
            this.radioButtonMaterialListe.Name = "radioButtonMaterialListe";
            this.radioButtonMaterialListe.Size = new System.Drawing.Size(75, 21);
            this.radioButtonMaterialListe.TabIndex = 0;
            this.radioButtonMaterialListe.TabStop = true;
            this.radioButtonMaterialListe.Text = "Material";
            this.radioButtonMaterialListe.UseVisualStyleBackColor = true;
            this.radioButtonMaterialListe.CheckedChanged += new System.EventHandler(this.radioButtonMaterialListe_CheckedChanged);
            // 
            // radioButtonManuel
            // 
            this.radioButtonManuel.AutoSize = true;
            this.radioButtonManuel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManuel.Location = new System.Drawing.Point(472, 9);
            this.radioButtonManuel.Name = "radioButtonManuel";
            this.radioButtonManuel.Size = new System.Drawing.Size(74, 21);
            this.radioButtonManuel.TabIndex = 1;
            this.radioButtonManuel.TabStop = true;
            this.radioButtonManuel.Text = "manuell";
            this.radioButtonManuel.UseVisualStyleBackColor = true;
            this.radioButtonManuel.CheckedChanged += new System.EventHandler(this.radioButtonManuel_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 243);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.bt_calculate);
            this.panel4.Controls.Add(this.bt_clearAll);
            this.panel4.Location = new System.Drawing.Point(4, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 36);
            this.panel4.TabIndex = 20;
            // 
            // bt_calculate
            // 
            this.bt_calculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.Location = new System.Drawing.Point(263, 6);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(180, 25);
            this.bt_calculate.TabIndex = 21;
            this.bt_calculate.Text = "Calculate";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // bt_clearAll
            // 
            this.bt_clearAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clearAll.Location = new System.Drawing.Point(6, 6);
            this.bt_clearAll.Name = "bt_clearAll";
            this.bt_clearAll.Size = new System.Drawing.Size(180, 25);
            this.bt_clearAll.TabIndex = 28;
            this.bt_clearAll.Text = "Clear All";
            this.bt_clearAll.UseVisualStyleBackColor = true;
            this.bt_clearAll.Click += new System.EventHandler(this.bt_clearAll_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btn_clearMasseFeld);
            this.panel3.Controls.Add(this.btn_clearVolumenFeld);
            this.panel3.Controls.Add(this.btn_clearDichteFeld);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_gewicht);
            this.panel3.Controls.Add(this.tb_volumen);
            this.panel3.Controls.Add(this.tb_dichte);
            this.panel3.Location = new System.Drawing.Point(464, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 186);
            this.panel3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Masse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Volumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dichte";
            // 
            // tb_gewicht
            // 
            this.tb_gewicht.Location = new System.Drawing.Point(6, 139);
            this.tb_gewicht.Name = "tb_gewicht";
            this.tb_gewicht.Size = new System.Drawing.Size(151, 20);
            this.tb_gewicht.TabIndex = 20;
            this.tb_gewicht.TextChanged += new System.EventHandler(this.tb_gewicht_TextChanged);
            // 
            // tb_volumen
            // 
            this.tb_volumen.Location = new System.Drawing.Point(6, 82);
            this.tb_volumen.Name = "tb_volumen";
            this.tb_volumen.Size = new System.Drawing.Size(151, 20);
            this.tb_volumen.TabIndex = 19;
            this.tb_volumen.TextChanged += new System.EventHandler(this.tb_volumen_TextChanged);
            // 
            // tb_dichte
            // 
            this.tb_dichte.Location = new System.Drawing.Point(6, 29);
            this.tb_dichte.Name = "tb_dichte";
            this.tb_dichte.Size = new System.Drawing.Size(151, 20);
            this.tb_dichte.TabIndex = 18;
            this.tb_dichte.TextChanged += new System.EventHandler(this.tb_dichte_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btn_clearList);
            this.panel2.Controls.Add(this.lv_Materialien);
            this.panel2.Controls.Add(this.lb_material);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 186);
            this.panel2.TabIndex = 18;
            // 
            // btn_clearList
            // 
            this.btn_clearList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearList.Location = new System.Drawing.Point(218, 29);
            this.btn_clearList.Name = "btn_clearList";
            this.btn_clearList.Size = new System.Drawing.Size(95, 23);
            this.btn_clearList.TabIndex = 20;
            this.btn_clearList.Text = "Clear List";
            this.btn_clearList.UseVisualStyleBackColor = true;
            this.btn_clearList.Click += new System.EventHandler(this.btn_clearList_Click);
            // 
            // lv_Materialien
            // 
            this.lv_Materialien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Materialien.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_Materialien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Materialien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.lv_Materialien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Materialien.FullRowSelect = true;
            this.lv_Materialien.GridLines = true;
            this.lv_Materialien.Location = new System.Drawing.Point(6, 56);
            this.lv_Materialien.MultiSelect = false;
            this.lv_Materialien.Name = "lv_Materialien";
            this.lv_Materialien.Size = new System.Drawing.Size(409, 103);
            this.lv_Materialien.TabIndex = 19;
            this.lv_Materialien.UseCompatibleStateImageBehavior = false;
            this.lv_Materialien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Material";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dichte";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Werkstoffklasse";
            this.columnHeader1.Width = 150;
            // 
            // lb_material
            // 
            this.lb_material.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_material.FormattingEnabled = true;
            this.lb_material.Location = new System.Drawing.Point(6, 29);
            this.lb_material.Name = "lb_material";
            this.lb_material.Size = new System.Drawing.Size(206, 21);
            this.lb_material.Sorted = true;
            this.lb_material.TabIndex = 17;
            this.lb_material.SelectedIndexChanged += new System.EventHandler(this.lb_material_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Auswahlliste für Berechnung:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(12, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(642, 284);
            this.panel5.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.tb_erstellenMaterialName);
            this.panel8.Controls.Add(this.tb_erstellenDichte);
            this.panel8.Controls.Add(this.tb_erstellenWerkstoffklasse);
            this.panel8.Controls.Add(this.bt_newMaterial);
            this.panel8.Controls.Add(this.btn_deleteMaterial);
            this.panel8.Controls.Add(this.lv_materialListe);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(4, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(631, 273);
            this.panel8.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Werkstoffklasse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Dichte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Material Name:";
            // 
            // tb_erstellenMaterialName
            // 
            this.tb_erstellenMaterialName.Location = new System.Drawing.Point(8, 247);
            this.tb_erstellenMaterialName.Name = "tb_erstellenMaterialName";
            this.tb_erstellenMaterialName.Size = new System.Drawing.Size(146, 20);
            this.tb_erstellenMaterialName.TabIndex = 100;
            // 
            // tb_erstellenDichte
            // 
            this.tb_erstellenDichte.Location = new System.Drawing.Point(160, 247);
            this.tb_erstellenDichte.Name = "tb_erstellenDichte";
            this.tb_erstellenDichte.Size = new System.Drawing.Size(146, 20);
            this.tb_erstellenDichte.TabIndex = 101;
            // 
            // tb_erstellenWerkstoffklasse
            // 
            this.tb_erstellenWerkstoffklasse.Location = new System.Drawing.Point(312, 247);
            this.tb_erstellenWerkstoffklasse.Name = "tb_erstellenWerkstoffklasse";
            this.tb_erstellenWerkstoffklasse.Size = new System.Drawing.Size(146, 20);
            this.tb_erstellenWerkstoffklasse.TabIndex = 102;
            // 
            // bt_newMaterial
            // 
            this.bt_newMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_newMaterial.Location = new System.Drawing.Point(511, 244);
            this.bt_newMaterial.Name = "bt_newMaterial";
            this.bt_newMaterial.Size = new System.Drawing.Size(95, 23);
            this.bt_newMaterial.TabIndex = 103;
            this.bt_newMaterial.Text = "Create New";
            this.bt_newMaterial.UseVisualStyleBackColor = true;
            this.bt_newMaterial.Click += new System.EventHandler(this.bt_newMaterial_Click);
            // 
            // btn_deleteMaterial
            // 
            this.btn_deleteMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteMaterial.Location = new System.Drawing.Point(522, 18);
            this.btn_deleteMaterial.Name = "btn_deleteMaterial";
            this.btn_deleteMaterial.Size = new System.Drawing.Size(95, 23);
            this.btn_deleteMaterial.TabIndex = 20;
            this.btn_deleteMaterial.Text = "Delete";
            this.btn_deleteMaterial.UseVisualStyleBackColor = true;
            this.btn_deleteMaterial.Click += new System.EventHandler(this.btn_deleteMaterial_Click);
            // 
            // lv_materialListe
            // 
            this.lv_materialListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_materialListe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_materialListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_materialListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_materialListe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_materialListe.FullRowSelect = true;
            this.lv_materialListe.GridLines = true;
            this.lv_materialListe.Location = new System.Drawing.Point(6, 47);
            this.lv_materialListe.Name = "lv_materialListe";
            this.lv_materialListe.Size = new System.Drawing.Size(611, 172);
            this.lv_materialListe.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_materialListe.TabIndex = 19;
            this.lv_materialListe.UseCompatibleStateImageBehavior = false;
            this.lv_materialListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Material";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dichte";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Werkstoffklasse";
            this.columnHeader6.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Matarial Liste:";
            // 
            // btn_clearDichteFeld
            // 
            this.btn_clearDichteFeld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearDichteFeld.Location = new System.Drawing.Point(97, 5);
            this.btn_clearDichteFeld.Name = "btn_clearDichteFeld";
            this.btn_clearDichteFeld.Size = new System.Drawing.Size(60, 20);
            this.btn_clearDichteFeld.TabIndex = 24;
            this.btn_clearDichteFeld.Text = "Clear";
            this.btn_clearDichteFeld.UseVisualStyleBackColor = true;
            this.btn_clearDichteFeld.Click += new System.EventHandler(this.btn_clearDichteFeld_Click);
            // 
            // btn_clearVolumenFeld
            // 
            this.btn_clearVolumenFeld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearVolumenFeld.Location = new System.Drawing.Point(97, 59);
            this.btn_clearVolumenFeld.Name = "btn_clearVolumenFeld";
            this.btn_clearVolumenFeld.Size = new System.Drawing.Size(60, 20);
            this.btn_clearVolumenFeld.TabIndex = 25;
            this.btn_clearVolumenFeld.Text = "Clear";
            this.btn_clearVolumenFeld.UseVisualStyleBackColor = true;
            this.btn_clearVolumenFeld.Click += new System.EventHandler(this.btn_clearVolumenFeld_Click);
            // 
            // btn_clearMasseFeld
            // 
            this.btn_clearMasseFeld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearMasseFeld.Location = new System.Drawing.Point(97, 116);
            this.btn_clearMasseFeld.Name = "btn_clearMasseFeld";
            this.btn_clearMasseFeld.Size = new System.Drawing.Size(60, 20);
            this.btn_clearMasseFeld.TabIndex = 26;
            this.btn_clearMasseFeld.Text = "Clear";
            this.btn_clearMasseFeld.UseVisualStyleBackColor = true;
            this.btn_clearMasseFeld.Click += new System.EventHandler(this.btn_clearMasseFeld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 581);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonManuel);
            this.Controls.Add(this.radioButtonMaterialListe);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 620);
            this.MinimumSize = new System.Drawing.Size(680, 620);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdinCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMaterialListe;
        private System.Windows.Forms.RadioButton radioButtonManuel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lb_material;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Button bt_clearAll;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_clearList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_deleteMaterial;
        private System.Windows.Forms.ListView lv_materialListe;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_newMaterial;
        public System.Windows.Forms.TextBox tb_gewicht;
        public System.Windows.Forms.TextBox tb_volumen;
        public System.Windows.Forms.TextBox tb_dichte;
        public System.Windows.Forms.ListView lv_Materialien;
        public System.Windows.Forms.TextBox tb_erstellenMaterialName;
        public System.Windows.Forms.TextBox tb_erstellenDichte;
        public System.Windows.Forms.TextBox tb_erstellenWerkstoffklasse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clearMasseFeld;
        private System.Windows.Forms.Button btn_clearVolumenFeld;
        private System.Windows.Forms.Button btn_clearDichteFeld;
    }
}

