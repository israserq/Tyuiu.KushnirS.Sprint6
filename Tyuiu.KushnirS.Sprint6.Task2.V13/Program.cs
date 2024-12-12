using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.KushnirS.Sprint6.Task2.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxStartStop = new GroupBox();
            buttonDone = new Button();
            buttonQuestion = new Button();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            textBoxStartStop = new TextBox();
            groupBoxResult = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Func = new DataGridViewTextBoxColumn();
            groupBoxTask.SuspendLayout();
            groupBoxStartStop.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(551, 292);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 23);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(542, 263);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне. Ответ вывести в DataGridView и построить график функции.";
            // 
            // groupBoxStartStop
            // 
            groupBoxStartStop.Controls.Add(buttonDone);
            groupBoxStartStop.Controls.Add(buttonQuestion);
            groupBoxStartStop.Controls.Add(textBoxStop);
            groupBoxStartStop.Controls.Add(textBoxStart);
            groupBoxStartStop.Controls.Add(textBoxStartStop);
            groupBoxStartStop.Location = new Point(15, 313);
            groupBoxStartStop.Name = "groupBoxStartStop";
            groupBoxStartStop.Size = new Size(548, 125);
            groupBoxStartStop.TabIndex = 1;
            groupBoxStartStop.TabStop = false;
            groupBoxStartStop.Text = "Ввод данных:";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(382, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(148, 71);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonQuestion
            // 
            buttonQuestion.BackColor = Color.Cyan;
            buttonQuestion.Location = new Point(282, 25);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(94, 72);
            buttonQuestion.TabIndex = 1;
            buttonQuestion.Text = "Справка";
            buttonQuestion.UseVisualStyleBackColor = false;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(137, 59);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 2;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 59);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 1;
            // 
            // textBoxStartStop
            // 
            textBoxStartStop.Location = new Point(6, 26);
            textBoxStartStop.Multiline = true;
            textBoxStartStop.Name = "textBoxStartStop";
            textBoxStartStop.ReadOnly = true;
            textBoxStartStop.Size = new Size(270, 71);
            textBoxStartStop.TabIndex = 0;
            textBoxStartStop.Text = "Старт шага:            Конец шага:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartFunction);
            groupBoxResult.Controls.Add(dataGridViewFunction);
            groupBoxResult.Location = new Point(569, 24);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(570, 414);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(173, 26);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(391, 382);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chartFunction";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Func });
            dataGridViewFunction.Location = new Point(6, 26);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(161, 382);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Func
            // 
            Func.HeaderText = "F(x)";
            Func.MinimumWidth = 6;
            Func.Name = "Func";
            Func.ReadOnly = true;
            Func.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxStartStop);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
           
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxStartStop.ResumeLayout(false);
            groupBoxStartStop.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxStartStop;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBoxStartStop;
        private GroupBox groupBoxResult;
        private Button buttonDone;
        private Button buttonQuestion;
        private DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Func;
    }
}