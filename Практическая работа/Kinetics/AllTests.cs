using System;
using System.Windows.Forms;

namespace Kinetics
{
  class AllTests
  {
    internal static bool AllChecks(double conA, double conB, double step) // Все проверки значений
    {
      if (ValidInput() && AllFieldsFilled() && ValidValues(conA, conB, step))
      {
        return true;
      }
      return false;
    }

    internal static bool AllFieldsFilled() // Проверка заполнености всех полей
    {
      for (int i = 1; i < (int)App.TextBoxes.step; i++)
      {
        string tempStr = Enum.GetName(typeof(App.TextBoxes), i) + "_tb";
        if (Form.ActiveForm.Controls[tempStr].Text.Length == 0)
        {
          MessageBox.Show("Заполните все поля!");
          return false;
        }
      }
      return true;
    }

    internal static bool ValidValues(double conA, double conB, double step) // Проверка корректности значений
    {
      if (step <= 0)
      {
        MessageBox.Show("Некорректное значение шага! Введите шаг больше 0");
        return false;
      }

      if (step < 0.01)
      {
        MessageBox.Show("Шаг слишком маленький! Введите шаг больше 0,01");
        return false;
      }

      if (step > 0.5)
      {
        MessageBox.Show("Шаг слишком большой! Введите шаг меньше 0,5");
        return false;
      }

      if (conA < 0 || conB < 0)
      {
        MessageBox.Show("Концентрация не может быть отрицательной!");
        return false;
      }

      return true;
    }

    internal static bool ValidInput()
    {
      for (int i = 1; i < (int)App.TextBoxes.step; i++)
      {
        string tempStr = Enum.GetName(typeof(App.TextBoxes), i) + "_tb";
        double.TryParse(Form.ActiveForm.Controls[tempStr].Text, out double num);
        if (num == 0 && Form.ActiveForm.Controls[tempStr].Text != "0")
        {
          MessageBox.Show("Некорректные значения!");
          return false;
        }
      }
      return true;
    }
  }
}
