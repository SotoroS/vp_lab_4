using System;
using System.Linq;
using System.Windows.Forms;

namespace vp_lab_4
{
    public partial class Form1 : Form
    {
        private dynamic genericsSet; // Ссылка на двухсвязный список
        private Type typeOfData;    // Тип данных элемента списка
        private Type listType;      // Тип данных списка

        public Form1()
        {
            InitializeComponent();
        }

        // Создание нового списка элементов
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Получаем название класса типа данных списка элементов в виде неопределенной переменной
            var a = from RadioButton r in groupBoxTypeDate.Controls where r.Checked == true select r as RadioButton;

            // Запоминаем тип данных элементов списка
            typeOfData = Type.GetType(a.First<RadioButton>().Text);

            // Формирование типа данных для создания объекта списка из полученного типа данных
            listType = typeof(GenericsSet<>).MakeGenericType(new Type[] { typeOfData });

            // Создание двухсвязного списка
            genericsSet = Activator.CreateInstance(listType);

            // Отключаем возможность изменения типа данных списка
            groupBoxTypeDate.Enabled = false;

            // Включаем возможность добавлять элементы, находить элементы, обновлять счетчик элементов
            groupBoxAddValue.Enabled = true;
            groupBoxGet.Enabled = true;
            groupBoxCount.Enabled = true;

            // Выключаем возможность сново создать список и включаем возможность удалить список
            buttonCreate.Enabled = false;
            buttonDelete.Enabled = true;
        }

        // Удаление списка элементов
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Удаляем двухсвязный список
            genericsSet = null;

            // Включаем возможность изменения типа данных списка
            groupBoxTypeDate.Enabled = true;

            // ВЫключаем возможность добавлять элементы, находить элементы, обновлять счетчик элементов
            groupBoxAddValue.Enabled = false;
            groupBoxGet.Enabled = false;
            groupBoxCount.Enabled = false;

            // Включаем возможность сново создать список и выключаем возможность удалить список
            buttonCreate.Enabled = true;
            buttonDelete.Enabled = false;

            // TODO: Реализовать очистку данных в полях доступных при созданном списке

        }

        // Добавление элемента в список
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Добавление элемента в список с преобразование относительно типа данных элементов списка
            genericsSet.Add((dynamic)(Convert.ChangeType(textBoxValue.Text, typeOfData)));
            // Очиска поля значения нового элемента и фокусировка на нем
            textBoxValue.Text = "";
            textBoxValue.Focus();
        }

        // Обновляем счетчик количества элементов
        private void buttonGetCount_Click(object sender, EventArgs e)
        {
            textBoxCount.Text = genericsSet.Count.ToString();
        }

        // Получение элемента из списка по его порядковому номеру
        private void buttonGetElement_Click(object sender, EventArgs e)
        {
            uint n = (uint)Convert.ToInt32(textBoxN.Text); 

            // Проверка области допустимых значений
            if (n >= genericsSet.Count)
            {
                // Корректировка, если есть нарушения
                n = genericsSet.Count - 1;
                textBoxN.Text = n.ToString();
            }

            // Выводим результат поиска
            textBoxGetResult.Text = genericsSet.Get(Convert.ToInt32(textBoxN.Text)).ToString();
            // Фокусровка на поле n и выделение введенного текста
            textBoxN.Focus();
            textBoxN.SelectionStart = 0;
            textBoxN.SelectionLength = textBoxN.Text.Length;
        }
    }
}
