using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kinetics
{
  public partial class App : Form
  {
    internal enum Symbols
    {
      Backspace = 8
    }

    internal enum TextBoxes
    {
      conA = 1,
      conB,
      step
    }

    public App()
    {
      InitializeComponent();

    }

    private double func(double conA, double conB, int num) // расчёт производных f1,f2
    {
      double res = 0;
      switch(num){
        case 1:
          res = -2 * conA + 2 * conB;
          break;
        case 2:
          res = 2 * conA - 2 * conB;
          break;
      }
      return res;
    }

    private void build_button_MouseClick(object sender, MouseEventArgs e)
    {
      dataTable.Rows.Clear();

      ConChart.Series[0].Points.Clear();
      ConChart.Series[1].Points.Clear();

      try
      {
        double.TryParse(conA_tb.Text, out double conA);
        double.TryParse(conB_tb.Text, out double conB);
        double.TryParse(step_tb.Text, out double step);

        if (AllTests.AllChecks(conA, conB, step))
        {

          ConChart.ChartAreas[0].AxisY.Minimum = 0;
          ConChart.ChartAreas[0].AxisY.Maximum = conA>=conB ? conA : conB;

          double x = 0, ya = conA, yb = conB, ka1, ka2, ka3, ka4, kb1, kb2, kb3, kb4, conAChck, 
                        conBChck, t = step;

          ConChart.Series[0].Points.AddXY(0, conA);
          ConChart.Series[1].Points.AddXY(0, conB);

          ConChart.Series[0].IsVisibleInLegend = true;
          ConChart.Series[1].IsVisibleInLegend = true;

          ConChart.Titles[0].Visible = true;
          ConChart.Titles[1].Visible = true;

          dataTable.Rows.Insert(0,
            0,
            Configurate.ToFixed(conA, 2),
            Configurate.ToFixed(conB, 2)
          );

            do
            {
                x = t;
                ka1 = step * func(conA, conB, 1);
                kb1 = step * func(conA, conB, 2);

                ka2 = step * func(conA + ka1 / 2, conB + kb1 / 2, 1);
                kb2 = step * func(conA + ka1 / 2, conB + kb1 / 2, 2);

                ka3 = step * func(conA + ka2 / 2, conB + kb2 / 2, 1);
                kb3 = step * func(conA + ka2 / 2, conB + kb2 / 2, 2);

                ka4 = step * func(conA + ka3, conB + kb3, 1);
                kb4 = step * func(conA + ka3, conB + kb3, 2);

                conAChck = conA;
                conBChck = conB;

                conA = conA + (ka1 + 2 * ka2 + 2 * ka3 + ka4) / 6;
                conB = conB + (kb1 + 2 * kb2 + 2 * kb3 + kb4) / 6;

                dataTable.Rows.Add(Configurate.ToFixed(x, 2),
                Configurate.ToFixed(conA, 2),
                Configurate.ToFixed(conB, 2)
                );

                t += step;
            } while (Math.Abs(conAChck - conA) > 0.005 && Math.Abs(conBChck - conB) > 0.005);

          ConChart.ChartAreas[0].AxisX.Minimum = 0;
          ConChart.ChartAreas[0].AxisX.Maximum = x;

                    for (int i = 0; i < dataTable.RowCount; i++)
          {
            ConChart.Series[0].Points.AddXY(dataTable[0, i].Value, dataTable[1, i].Value);
            ConChart.Series[1].Points.AddXY(dataTable[0, i].Value, dataTable[2, i].Value);
          }
          ConChart.Visible = true;
        }
      }
      catch
      {
        MessageBox.Show("Введены некорректные значения!");
      }
    }

    private void step_tb_KeyPress(object sender, KeyPressEventArgs e)// Проверка ввода для шага
    {
      char ch = e.KeyChar;
      if (!Char.IsDigit(ch) && ch != (int)Symbols.Backspace && ch != ',')
      {
        e.Handled = true;
        MessageBox.Show("Введите шаг в формате 0,1");
      }
    }

    private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
    {
       MessageBox.Show("Данная программа предоставляет решения прямой задачи кинетики обратимой реакции А<->B.\n©Зобнин Илья 485 гр.");
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (ConChart.Visible)
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
          Filter = "PNG Image|*.png",
          Title = "Сохранить как png",
          FileName = "Sample.png"
        };

        DialogResult result = saveFileDialog.ShowDialog();
        saveFileDialog.RestoreDirectory = true;

        ConChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
      } 
      else
      {
        MessageBox.Show("Сперва необходимо построить график!");
      }
    }
  }
}
