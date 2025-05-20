using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tractor.Models;

namespace Tractor.Forms
{
    public partial class MainForm : Form
    {
        private List<TractorModel> tractorList = new();

        public MainForm()
        {
            InitializeComponent();
            LoadTractors();
            findButton.Click += FindButton_Click;
        }

        private void LoadTractors()
        {
            // Додаємо тестові трактори
            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6155M",
                Year = 2020,
                EngineType = "6.8L дизель",
                HorsePower = "155 к.с.",
                PowerKW = "114 кВт",
                Price = 125000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5075E",
                Year = 2019,
                EngineType = "3.0L дизель",
                HorsePower = "75 к.с.",
                PowerKW = "56 кВт",
                Price = 75000
            });

            ShowAllTractors();
        }

        private void ShowAllTractors()
        {
            dataGridView1.DataSource = tractorList
                .Select(t => new
                {
                    Model = t.Model,
                    Year = t.Year,
                    Engine = t.EngineType,
                    HorsePower = t.HorsePower,
                    PowerKW = t.PowerKW,
                    Price = $"{t.Price:C}"
                })
                .ToList();
        }

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

            var result = filtered
                .Select(t => new
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

            if (result.Count == 0)
            {
                MessageBox.Show("Трактор не знайдено. Перевірте модель або рік.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
