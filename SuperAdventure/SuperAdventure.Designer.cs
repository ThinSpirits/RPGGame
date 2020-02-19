namespace SuperAdventure
{
    partial class SuperAdventure
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboWeapons = new System.Windows.Forms.ComboBox();
            this.comboPotions = new System.Windows.Forms.ComboBox();
            this.buttonUseWeapon = new System.Windows.Forms.Button();
            this.buttonUsePotion = new System.Windows.Forms.Button();
            this.buttonNorth = new System.Windows.Forms.Button();
            this.buttonEast = new System.Windows.Forms.Button();
            this.buttonSouth = new System.Windows.Forms.Button();
            this.buttonWest = new System.Windows.Forms.Button();
            this.richTextBoxLocation = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 19);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 13);
            this.lblHitPoints.TabIndex = 3;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 4;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(110, 73);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 13);
            this.lblExperience.TabIndex = 5;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 99);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 13);
            this.lblLevel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select action";
            // 
            // comboWeapons
            // 
            this.comboWeapons.FormattingEnabled = true;
            this.comboWeapons.Location = new System.Drawing.Point(369, 559);
            this.comboWeapons.Name = "comboWeapons";
            this.comboWeapons.Size = new System.Drawing.Size(121, 21);
            this.comboWeapons.TabIndex = 9;
            // 
            // comboPotions
            // 
            this.comboPotions.FormattingEnabled = true;
            this.comboPotions.Location = new System.Drawing.Point(369, 553);
            this.comboPotions.Name = "comboPotions";
            this.comboPotions.Size = new System.Drawing.Size(121, 21);
            this.comboPotions.TabIndex = 10;
            // 
            // buttonUseWeapon
            // 
            this.buttonUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.buttonUseWeapon.Name = "buttonUseWeapon";
            this.buttonUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.buttonUseWeapon.TabIndex = 11;
            this.buttonUseWeapon.Text = "Use";
            this.buttonUseWeapon.UseVisualStyleBackColor = true;
            // 
            // buttonUsePotion
            // 
            this.buttonUsePotion.Location = new System.Drawing.Point(620, 593);
            this.buttonUsePotion.Name = "buttonUsePotion";
            this.buttonUsePotion.Size = new System.Drawing.Size(75, 23);
            this.buttonUsePotion.TabIndex = 12;
            this.buttonUsePotion.Text = "Use";
            this.buttonUsePotion.UseVisualStyleBackColor = true;
            // 
            // buttonNorth
            // 
            this.buttonNorth.Location = new System.Drawing.Point(493, 433);
            this.buttonNorth.Name = "buttonNorth";
            this.buttonNorth.Size = new System.Drawing.Size(75, 23);
            this.buttonNorth.TabIndex = 13;
            this.buttonNorth.Text = "North";
            this.buttonNorth.UseVisualStyleBackColor = true;
            // 
            // buttonEast
            // 
            this.buttonEast.Location = new System.Drawing.Point(573, 457);
            this.buttonEast.Name = "buttonEast";
            this.buttonEast.Size = new System.Drawing.Size(75, 23);
            this.buttonEast.TabIndex = 14;
            this.buttonEast.Text = "East";
            this.buttonEast.UseVisualStyleBackColor = true;
            // 
            // buttonSouth
            // 
            this.buttonSouth.Location = new System.Drawing.Point(493, 487);
            this.buttonSouth.Name = "buttonSouth";
            this.buttonSouth.Size = new System.Drawing.Size(75, 23);
            this.buttonSouth.TabIndex = 15;
            this.buttonSouth.Text = "South";
            this.buttonSouth.UseVisualStyleBackColor = true;
            // 
            // buttonWest
            // 
            this.buttonWest.Location = new System.Drawing.Point(412, 457);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(75, 23);
            this.buttonWest.TabIndex = 16;
            this.buttonWest.Text = "West";
            this.buttonWest.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLocation
            // 
            this.richTextBoxLocation.Location = new System.Drawing.Point(347, 19);
            this.richTextBoxLocation.Name = "richTextBoxLocation";
            this.richTextBoxLocation.ReadOnly = true;
            this.richTextBoxLocation.Size = new System.Drawing.Size(360, 286);
            this.richTextBoxLocation.TabIndex = 17;
            this.richTextBoxLocation.Text = "";
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Location = new System.Drawing.Point(347, 130);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.ReadOnly = true;
            this.richTextBoxMessages.Size = new System.Drawing.Size(360, 286);
            this.richTextBoxMessages.TabIndex = 18;
            this.richTextBoxMessages.Text = "";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.AllowUserToResizeColumns = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewInventory.Enabled = false;
            this.dataGridViewInventory.Location = new System.Drawing.Point(16, 130);
            this.dataGridViewInventory.MultiSelect = false;
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowHeadersVisible = false;
            this.dataGridViewInventory.Size = new System.Drawing.Size(312, 309);
            this.dataGridViewInventory.TabIndex = 19;
            // 
            // dataGridViewQuests
            // 
            this.dataGridViewQuests.AllowUserToAddRows = false;
            this.dataGridViewQuests.AllowUserToDeleteRows = false;
            this.dataGridViewQuests.AllowUserToResizeRows = false;
            this.dataGridViewQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewQuests.Enabled = false;
            this.dataGridViewQuests.Location = new System.Drawing.Point(16, 446);
            this.dataGridViewQuests.MultiSelect = false;
            this.dataGridViewQuests.Name = "dataGridViewQuests";
            this.dataGridViewQuests.ReadOnly = true;
            this.dataGridViewQuests.RowHeadersVisible = false;
            this.dataGridViewQuests.Size = new System.Drawing.Size(312, 189);
            this.dataGridViewQuests.TabIndex = 20;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.dataGridViewQuests);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.richTextBoxLocation);
            this.Controls.Add(this.buttonWest);
            this.Controls.Add(this.buttonSouth);
            this.Controls.Add(this.buttonEast);
            this.Controls.Add(this.buttonNorth);
            this.Controls.Add(this.buttonUsePotion);
            this.Controls.Add(this.buttonUseWeapon);
            this.Controls.Add(this.comboPotions);
            this.Controls.Add(this.comboWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboWeapons;
        private System.Windows.Forms.ComboBox comboPotions;
        private System.Windows.Forms.Button buttonUseWeapon;
        private System.Windows.Forms.Button buttonUsePotion;
        private System.Windows.Forms.Button buttonNorth;
        private System.Windows.Forms.Button buttonEast;
        private System.Windows.Forms.Button buttonSouth;
        private System.Windows.Forms.Button buttonWest;
        private System.Windows.Forms.RichTextBox richTextBoxLocation;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewQuests;
    }
}

