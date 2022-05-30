namespace Praktikum_Week_14
{
    partial class FormW14
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lbl_TeamName = new System.Windows.Forms.Label();
            this.lbl_Manager = new System.Windows.Forms.Label();
            this.lbl_Stadium = new System.Windows.Forms.Label();
            this.lbl_TopScorer = new System.Windows.Forms.Label();
            this.lbl_WorstDiscipline = new System.Windows.Forms.Label();
            this.lbl_IsiTeamName = new System.Windows.Forms.Label();
            this.lbl_IsiManager = new System.Windows.Forms.Label();
            this.lbl_IsiStadium = new System.Windows.Forms.Label();
            this.lbl_IsiTopScorer = new System.Windows.Forms.Label();
            this.lbl_IsiWorstDiscipline = new System.Windows.Forms.Label();
            this.dgv_IsiMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IsiMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(69, 22);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(68, 65);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(174, 22);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(68, 65);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(280, 22);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 65);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(385, 22);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(68, 65);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.AutoSize = true;
            this.lbl_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.Location = new System.Drawing.Point(45, 109);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(110, 20);
            this.lbl_TeamName.TabIndex = 4;
            this.lbl_TeamName.Text = "Team Name :";
            this.lbl_TeamName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Manager
            // 
            this.lbl_Manager.AutoSize = true;
            this.lbl_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manager.Location = new System.Drawing.Point(71, 141);
            this.lbl_Manager.Name = "lbl_Manager";
            this.lbl_Manager.Size = new System.Drawing.Size(84, 20);
            this.lbl_Manager.TabIndex = 5;
            this.lbl_Manager.Text = "Manager :";
            // 
            // lbl_Stadium
            // 
            this.lbl_Stadium.AutoSize = true;
            this.lbl_Stadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stadium.Location = new System.Drawing.Point(75, 173);
            this.lbl_Stadium.Name = "lbl_Stadium";
            this.lbl_Stadium.Size = new System.Drawing.Size(80, 20);
            this.lbl_Stadium.TabIndex = 6;
            this.lbl_Stadium.Text = "Stadium :";
            // 
            // lbl_TopScorer
            // 
            this.lbl_TopScorer.AutoSize = true;
            this.lbl_TopScorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TopScorer.Location = new System.Drawing.Point(53, 205);
            this.lbl_TopScorer.Name = "lbl_TopScorer";
            this.lbl_TopScorer.Size = new System.Drawing.Size(102, 20);
            this.lbl_TopScorer.TabIndex = 7;
            this.lbl_TopScorer.Text = "Top Scorer :";
            // 
            // lbl_WorstDiscipline
            // 
            this.lbl_WorstDiscipline.AutoSize = true;
            this.lbl_WorstDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorstDiscipline.Location = new System.Drawing.Point(12, 238);
            this.lbl_WorstDiscipline.Name = "lbl_WorstDiscipline";
            this.lbl_WorstDiscipline.Size = new System.Drawing.Size(143, 20);
            this.lbl_WorstDiscipline.TabIndex = 8;
            this.lbl_WorstDiscipline.Text = "Worst Discipline :";
            // 
            // lbl_IsiTeamName
            // 
            this.lbl_IsiTeamName.AutoSize = true;
            this.lbl_IsiTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsiTeamName.Location = new System.Drawing.Point(179, 109);
            this.lbl_IsiTeamName.Name = "lbl_IsiTeamName";
            this.lbl_IsiTeamName.Size = new System.Drawing.Size(53, 20);
            this.lbl_IsiTeamName.TabIndex = 9;
            this.lbl_IsiTeamName.Text = "label6";
            // 
            // lbl_IsiManager
            // 
            this.lbl_IsiManager.AutoSize = true;
            this.lbl_IsiManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsiManager.Location = new System.Drawing.Point(179, 141);
            this.lbl_IsiManager.Name = "lbl_IsiManager";
            this.lbl_IsiManager.Size = new System.Drawing.Size(53, 20);
            this.lbl_IsiManager.TabIndex = 10;
            this.lbl_IsiManager.Text = "label7";
            // 
            // lbl_IsiStadium
            // 
            this.lbl_IsiStadium.AutoSize = true;
            this.lbl_IsiStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsiStadium.Location = new System.Drawing.Point(179, 173);
            this.lbl_IsiStadium.Name = "lbl_IsiStadium";
            this.lbl_IsiStadium.Size = new System.Drawing.Size(53, 20);
            this.lbl_IsiStadium.TabIndex = 11;
            this.lbl_IsiStadium.Text = "label8";
            // 
            // lbl_IsiTopScorer
            // 
            this.lbl_IsiTopScorer.AutoSize = true;
            this.lbl_IsiTopScorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsiTopScorer.Location = new System.Drawing.Point(179, 205);
            this.lbl_IsiTopScorer.Name = "lbl_IsiTopScorer";
            this.lbl_IsiTopScorer.Size = new System.Drawing.Size(53, 20);
            this.lbl_IsiTopScorer.TabIndex = 12;
            this.lbl_IsiTopScorer.Text = "label9";
            // 
            // lbl_IsiWorstDiscipline
            // 
            this.lbl_IsiWorstDiscipline.AutoSize = true;
            this.lbl_IsiWorstDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsiWorstDiscipline.Location = new System.Drawing.Point(179, 238);
            this.lbl_IsiWorstDiscipline.Name = "lbl_IsiWorstDiscipline";
            this.lbl_IsiWorstDiscipline.Size = new System.Drawing.Size(62, 20);
            this.lbl_IsiWorstDiscipline.TabIndex = 13;
            this.lbl_IsiWorstDiscipline.Text = "label10";
            // 
            // dgv_IsiMatch
            // 
            this.dgv_IsiMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IsiMatch.Location = new System.Drawing.Point(16, 261);
            this.dgv_IsiMatch.Name = "dgv_IsiMatch";
            this.dgv_IsiMatch.RowHeadersWidth = 51;
            this.dgv_IsiMatch.RowTemplate.Height = 24;
            this.dgv_IsiMatch.Size = new System.Drawing.Size(685, 298);
            this.dgv_IsiMatch.TabIndex = 14;
            this.dgv_IsiMatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormW14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 571);
            this.Controls.Add(this.dgv_IsiMatch);
            this.Controls.Add(this.lbl_IsiWorstDiscipline);
            this.Controls.Add(this.lbl_IsiTopScorer);
            this.Controls.Add(this.lbl_IsiStadium);
            this.Controls.Add(this.lbl_IsiManager);
            this.Controls.Add(this.lbl_IsiTeamName);
            this.Controls.Add(this.lbl_WorstDiscipline);
            this.Controls.Add(this.lbl_TopScorer);
            this.Controls.Add(this.lbl_Stadium);
            this.Controls.Add(this.lbl_Manager);
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "FormW14";
            this.Text = "Week 14";
            this.Load += new System.EventHandler(this.FormW14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IsiMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lbl_TeamName;
        private System.Windows.Forms.Label lbl_Manager;
        private System.Windows.Forms.Label lbl_Stadium;
        private System.Windows.Forms.Label lbl_TopScorer;
        private System.Windows.Forms.Label lbl_WorstDiscipline;
        private System.Windows.Forms.Label lbl_IsiTeamName;
        private System.Windows.Forms.Label lbl_IsiManager;
        private System.Windows.Forms.Label lbl_IsiStadium;
        private System.Windows.Forms.Label lbl_IsiTopScorer;
        private System.Windows.Forms.Label lbl_IsiWorstDiscipline;
        private System.Windows.Forms.DataGridView dgv_IsiMatch;
    }
}

