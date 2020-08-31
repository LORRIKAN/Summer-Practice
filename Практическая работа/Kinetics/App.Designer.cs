namespace Kinetics
{
  partial class App
  {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
          if (disposing && (components != null))
          {
              components.Dispose();
          }
          base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.build_button = new System.Windows.Forms.Button();
            this.step_tb = new System.Windows.Forms.TextBox();
            this.conB_tb = new System.Windows.Forms.TextBox();
            this.conA_tb = new System.Windows.Forms.TextBox();
            this.step_lbl = new System.Windows.Forms.Label();
            this.conB_lbl = new System.Windows.Forms.Label();
            this.conA_lbl = new System.Windows.Forms.Label();
            this.ConChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.tColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // build_button
            // 
            this.build_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.build_button.Location = new System.Drawing.Point(60, 509);
            this.build_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.build_button.Name = "build_button";
            this.build_button.Size = new System.Drawing.Size(214, 77);
            this.build_button.TabIndex = 23;
            this.build_button.Text = "Построить графики";
            this.build_button.UseVisualStyleBackColor = true;
            this.build_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.build_button_MouseClick);
            // 
            // step_tb
            // 
            this.step_tb.Location = new System.Drawing.Point(16, 431);
            this.step_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.step_tb.MaxLength = 10;
            this.step_tb.Name = "step_tb";
            this.step_tb.ShortcutsEnabled = false;
            this.step_tb.Size = new System.Drawing.Size(120, 26);
            this.step_tb.TabIndex = 20;
            this.step_tb.Text = "0,1";
            this.step_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.step_tb_KeyPress);
            // 
            // conB_tb
            // 
            this.conB_tb.Location = new System.Drawing.Point(18, 332);
            this.conB_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conB_tb.MaxLength = 10;
            this.conB_tb.Name = "conB_tb";
            this.conB_tb.ShortcutsEnabled = false;
            this.conB_tb.Size = new System.Drawing.Size(120, 26);
            this.conB_tb.TabIndex = 19;
            this.conB_tb.Text = "50";
            this.conB_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.step_tb_KeyPress);
            // 
            // conA_tb
            // 
            this.conA_tb.Location = new System.Drawing.Point(18, 240);
            this.conA_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conA_tb.MaxLength = 10;
            this.conA_tb.Name = "conA_tb";
            this.conA_tb.ShortcutsEnabled = false;
            this.conA_tb.Size = new System.Drawing.Size(120, 26);
            this.conA_tb.TabIndex = 18;
            this.conA_tb.Text = "100";
            this.conA_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.step_tb_KeyPress);
            // 
            // step_lbl
            // 
            this.step_lbl.AutoSize = true;
            this.step_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.step_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.step_lbl.Location = new System.Drawing.Point(16, 385);
            this.step_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step_lbl.Name = "step_lbl";
            this.step_lbl.Size = new System.Drawing.Size(63, 29);
            this.step_lbl.TabIndex = 15;
            this.step_lbl.Text = "Шаг:";
            // 
            // conB_lbl
            // 
            this.conB_lbl.AutoSize = true;
            this.conB_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.conB_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conB_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conB_lbl.Location = new System.Drawing.Point(18, 286);
            this.conB_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conB_lbl.Name = "conB_lbl";
            this.conB_lbl.Size = new System.Drawing.Size(348, 29);
            this.conB_lbl.TabIndex = 14;
            this.conB_lbl.Text = "Начальная концентрация B: ";
            // 
            // conA_lbl
            // 
            this.conA_lbl.AutoSize = true;
            this.conA_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.conA_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conA_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conA_lbl.Location = new System.Drawing.Point(18, 194);
            this.conA_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conA_lbl.Name = "conA_lbl";
            this.conA_lbl.Size = new System.Drawing.Size(347, 29);
            this.conA_lbl.TabIndex = 13;
            this.conA_lbl.Text = "Начальная концентрация A: ";
            // 
            // ConChart
            // 
            this.ConChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea1.Name = "ChartArea1";
            this.ConChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this.ConChart.Legends.Add(legend1);
            this.ConChart.Location = new System.Drawing.Point(621, 48);
            this.ConChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConChart.Name = "ConChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend";
            series1.LegendText = "A";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend";
            series2.LegendText = "B";
            series2.Name = "Series2";
            this.ConChart.Series.Add(series1);
            this.ConChart.Series.Add(series2);
            this.ConChart.Size = new System.Drawing.Size(688, 591);
            this.ConChart.TabIndex = 25;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            title1.DockedToChartArea = "ChartArea1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Время, мин";
            title1.Visible = false;
            title2.Alignment = System.Drawing.ContentAlignment.TopRight;
            title2.DockedToChartArea = "ChartArea1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "Концентрация, моль/л";
            title2.Visible = false;
            this.ConChart.Titles.Add(title1);
            this.ConChart.Titles.Add(title2);
            this.ConChart.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1322, 38);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePngToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SavePngToolStripMenuItem
            // 
            this.SavePngToolStripMenuItem.Name = "SavePngToolStripMenuItem";
            this.SavePngToolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.SavePngToolStripMenuItem.Text = "Сохранить график";
            this.SavePngToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.ColumnHeadersHeight = 34;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tColumn,
            this.AColumn,
            this.BColumn});
            this.dataTable.Location = new System.Drawing.Point(369, 46);
            this.dataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 15;
            this.dataTable.Size = new System.Drawing.Size(243, 592);
            this.dataTable.TabIndex = 27;
            // 
            // tColumn
            // 
            this.tColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tColumn.HeaderText = "t";
            this.tColumn.MinimumWidth = 30;
            this.tColumn.Name = "tColumn";
            this.tColumn.ReadOnly = true;
            this.tColumn.Width = 50;
            // 
            // AColumn
            // 
            this.AColumn.HeaderText = "Ca";
            this.AColumn.MinimumWidth = 30;
            this.AColumn.Name = "AColumn";
            this.AColumn.ReadOnly = true;
            this.AColumn.Width = 66;
            // 
            // BColumn
            // 
            this.BColumn.HeaderText = "Cb";
            this.BColumn.MinimumWidth = 30;
            this.BColumn.Name = "BColumn";
            this.BColumn.ReadOnly = true;
            this.BColumn.Width = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 68);
            this.label1.TabIndex = 28;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 68);
            this.label2.TabIndex = 29;
            this.label2.Text = "-->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(147, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 68);
            this.label3.TabIndex = 30;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(66, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 35);
            this.label4.TabIndex = 31;
            this.label4.Text = "k = 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(195, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 35);
            this.label5.TabIndex = 33;
            this.label5.Text = "k = 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(192, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 68);
            this.label6.TabIndex = 32;
            this.label6.Text = "-->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(279, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 68);
            this.label7.TabIndex = 34;
            this.label7.Text = "A";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 657);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.ConChart);
            this.Controls.Add(this.build_button);
            this.Controls.Add(this.step_tb);
            this.Controls.Add(this.conB_tb);
            this.Controls.Add(this.conA_tb);
            this.Controls.Add(this.step_lbl);
            this.Controls.Add(this.conB_lbl);
            this.Controls.Add(this.conA_lbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинетика A<->B";
            ((System.ComponentModel.ISupportInitialize)(this.ConChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

      #endregion
      private System.Windows.Forms.Button build_button;
      private System.Windows.Forms.TextBox step_tb;
      private System.Windows.Forms.TextBox conB_tb;
      private System.Windows.Forms.TextBox conA_tb;
      private System.Windows.Forms.Label step_lbl;
      private System.Windows.Forms.Label conB_lbl;
      private System.Windows.Forms.Label conA_lbl;
      private System.Windows.Forms.DataVisualization.Charting.Chart ConChart;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem SavePngToolStripMenuItem;
      private System.Windows.Forms.DataGridView dataTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn tColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn BColumn;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

