using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tractor.Models;

namespace Tractor.Forms
{
    public partial class MainForm : Form
    {
        // Список тракторів, який зберігає всі дані, що відображаються у табоиці
        private List<TractorModel> tractorList = new();
        // Шлях до JSON-файлу для збереження та завантаження даних
        private readonly string dataFile = "tractors.json";

        // Ініціалізує компоненти інтерфейсу та завантажує список тракторів
        public MainForm()
        {
            InitializeComponent();
            LoadTractors();
            findButton.Click += FindButton_Click;
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
        }

        // Завантажує список тракторів з файлу, або створює стандартні записи, якщо файл відсутній
        private void LoadTractors()
        {
            string fileName = "tractors.json";
            if (System.IO.File.Exists(fileName))
            {
                string json = System.IO.File.ReadAllText(fileName);
                tractorList = System.Text.Json.JsonSerializer.Deserialize<List<TractorModel>>(json) ?? new List<TractorModel>();
            }
            else
            {
                tractorList = GetDefaultTractors(); 
                SaveTractors();
            }

            ShowAllTractors();
        }
        private List<TractorModel> GetDefaultTractors()
        {
            return new List<TractorModel>
    {
        new TractorModel
        {
            Model = "John Deere 6155M",
            Year = 2020,
            EngineType = "6.8L дизель",
            HorsePower = "155",
            PowerKW = "114",
            Price = 125000
        },
        new TractorModel
        {
            Model = "John Deere 8370R",
            Year = 2019,
            EngineType = "9.0L дизель",
            HorsePower = "370",
            PowerKW = "272",
            Price = 339000
        }
       
    };
}
        // Зберігає поточний список тракторів у JSON-файл
        private void SaveTractors()
        {
            string json = JsonSerializer.Serialize(tractorList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFile, json);
        }
        // Виводить повний список тракторів у таблицю DataGridView. Кожен рядок містить характеристики моделі
        private void ShowAllTractors()
        {
            var result = tractorList.Select(t => new
            {
                Model = t.Model,
                Year = t.Year,
                Engine = t.EngineType,
                HorsePower = t.HorsePower,
                PowerKW = t.PowerKW,
                Price = $"{t.Price:C}"
            }).ToList();

            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Модель";
            dataGridView1.Columns[1].HeaderText = "Рік";
            dataGridView1.Columns[2].HeaderText = "Двигун";
            dataGridView1.Columns[3].HeaderText = "Кінські сили";
            dataGridView1.Columns[4].HeaderText = "Потужність (кВт)";
            dataGridView1.Columns[5].HeaderText = "Ціна";
        }
        // Фільтрує список тракторів за моделлю та/або роком на основі введених користувачем значень
        private void FindButton_Click(object sender, EventArgs e)
        {
            string model = modelBox.Text.Trim();
            string yearText = yearBox.Text.Trim();
            bool yearParsed = int.TryParse(yearText, out int year);

            IEnumerable<TractorModel> filtered = tractorList;

            if (!string.IsNullOrEmpty(model) && string.IsNullOrEmpty(yearText))
            {
                filtered = tractorList.Where(t => t.Model.Contains(model, StringComparison.OrdinalIgnoreCase));
            }
            else if (string.IsNullOrEmpty(model) && yearParsed)
            {
                filtered = tractorList.Where(t => t.Year == year);
            }
            else if (!string.IsNullOrEmpty(model) && yearParsed)
            {
                filtered = tractorList.Where(t => t.Model.Contains(model, StringComparison.OrdinalIgnoreCase) && t.Year == year);
            }
            else if (string.IsNullOrEmpty(model) && string.IsNullOrEmpty(yearText))
            {
                ShowAllTractors();
                return;
            }
            else
            {
                MessageBox.Show("Невірно введений рік.");
                return;
            }
            // Вивід результатів у таблицю
            var result = filtered.Select(t => new
            {
                Model = t.Model,
                Year = t.Year,
                Engine = t.EngineType,
                HorsePower = t.HorsePower,
                PowerKW = t.PowerKW,
                Price = $"{t.Price:C}"
            })
                .ToList();

            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (result.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Модель";
                dataGridView1.Columns[1].HeaderText = "Рік";
                dataGridView1.Columns[2].HeaderText = "Двигун";
                dataGridView1.Columns[3].HeaderText = "Кінські сили";
                dataGridView1.Columns[4].HeaderText = "Потужність (кВт)";
                dataGridView1.Columns[5].HeaderText = "Ціна";
            }
            else
            {
                MessageBox.Show("Трактор не знайдено. Перевірте модель або рік.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void findButton_Click_1(object sender, EventArgs e)
        {

        }
        // Обробляє подію натискання кнопки "Додати". Створює новий об'єкт трактора з введених даних, додає його до списку і зберігає у файл
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string model = "John Deere " + modelBox1.Text.Trim();
                int year = int.Parse(yearBox1.Text.Trim());
                string engine = engineBox.Text.Trim() + " L дизель";
                string hp = horsepowerBox.Text.Trim() + " к.с.";
                string kw = powerBox.Text.Trim() + " кВт";
                decimal price = decimal.Parse(priceBox.Text.Trim());

                tractorList.Add(new TractorModel
                {
                    Model = model,
                    Year = year,
                    EngineType = engine,
                    HorsePower = hp,
                    PowerKW = kw,
                    Price = price
                });

                SaveTractors(); 
                ShowAllTractors();
                MessageBox.Show("Трактор успішно додано.");

                // очищення полів після  додавання трактора 
                modelBox1.Clear();
                yearBox1.Clear();
                engineBox.Clear();
                horsepowerBox.Clear();
                powerBox.Clear();
                priceBox.Clear();
            }
            catch
            {
                MessageBox.Show("Помилка при додаванні. Перевірте введені дані.");
            }
        }
        // Обробляє подію натискання кнопки "Видалити". Видаляє обраний запис трактора зі списку та зберігає оновлення у файл
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string selectedModel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int selectedYear = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                var toRemove = tractorList.FirstOrDefault(t => t.Model == selectedModel && t.Year == selectedYear);
                if (toRemove != null)
                {
                    tractorList.Remove(toRemove);
                    SaveTractors(); 
                    ShowAllTractors();
                    MessageBox.Show("Трактор видалено.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть трактор для видалення.");
            }
        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
