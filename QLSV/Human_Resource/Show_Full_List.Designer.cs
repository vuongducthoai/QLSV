﻿namespace QLSV.Human_Resource
{
    partial class Show_Full_List
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
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_ShowAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "GROUP";
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 29;
            this.listBoxGroup.Location = new System.Drawing.Point(35, 99);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(266, 352);
            this.listBoxGroup.TabIndex = 1;
            this.listBoxGroup.Click += new System.EventHandler(this.listBoxGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(370, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show All";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView_ShowAll
            // 
            this.dataGridView_ShowAll.AllowUserToAddRows = false;
            this.dataGridView_ShowAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowAll.Location = new System.Drawing.Point(329, 99);
            this.dataGridView_ShowAll.Name = "dataGridView_ShowAll";
            this.dataGridView_ShowAll.RowHeadersWidth = 51;
            this.dataGridView_ShowAll.RowTemplate.Height = 24;
            this.dataGridView_ShowAll.Size = new System.Drawing.Size(916, 348);
            this.dataGridView_ShowAll.TabIndex = 3;
            this.dataGridView_ShowAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ShowAll_CellDoubleClick);
            this.dataGridView_ShowAll.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ShowAll_ColumnHeaderMouseClick);
            this.dataGridView_ShowAll.Click += new System.EventHandler(this.dataGridView_ShowAll_Click);
            // 
            // Show_Full_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1266, 531);
            this.Controls.Add(this.dataGridView_ShowAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.label1);
            this.Name = "Show_Full_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Full_List";
            this.Load += new System.EventHandler(this.Show_Full_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_ShowAll;
    }
}