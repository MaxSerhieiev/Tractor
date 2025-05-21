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
                Model = "John Deere 8370R",
                Year = 2020,
                EngineType = "9,0L дизель",
                HorsePower = "408 к.с.",
                PowerKW = "155 кВт",
                Price = 272945
            });
            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6155M",
                Year = 2018,
                EngineType = "6.0L дизель",
                HorsePower = "125 к.с.",
                PowerKW = "99 кВт",
                Price = 110000
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

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 7810",
                Year = 2002,
                EngineType = "3.0L дизель",
                HorsePower = "55 к.с.",
                PowerKW = "55 кВт",
                Price = 29000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8370R",
                Year = 2018,
                EngineType = "9.0L дизель",
                HorsePower = "370 к.с.",
                PowerKW = "130 кВт",
                Price = 223407
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 7810",
                Year = 2005,
                EngineType = "5.0L дизель",
                HorsePower = "80 к.с.",
                PowerKW = "75 кВт",
                Price = 50000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 7810",
                Year = 2008,
                EngineType = "7.0L дизель",
                HorsePower = "101 к.с.",
                PowerKW = "98 кВт",
                Price = 83999
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5090 GN",
                Year = 2017,
                EngineType = "3.4L дизель",
                HorsePower = "90 к.с.",
                PowerKW = "67 кВт",
                Price = 50410
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 7310R",
                Year = 2016,
                EngineType = "7.0L дизель",
                HorsePower = "345 к.с.",
                PowerKW = "254,3 кВт",
                Price = 179000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8270R",
                Year = 2015,
                EngineType = "8.5L дизель",
                HorsePower = "270 к.с.",
                PowerKW = "199 кВт",
                Price = 168000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8335R",
                Year = 2014,
                EngineType = "9.0L дизель",
                HorsePower = "330 к.с.",
                PowerKW = "228 кВт",
                Price = 165000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8310R",
                Year = 2013,
                EngineType = "9.0L дизель",
                HorsePower = "335 к.с.",
                PowerKW = "246 кВт",
                Price = 176871
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8320",
                Year = 2004,
                EngineType = "9.0L дизель",
                HorsePower = "320 к.с.",
                PowerKW = "235 кВт",
                Price = 99916
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8335R",
                Year = 2011,
                EngineType = "8.0L дизель",
                HorsePower = "335 к.с.",
                PowerKW = "246 кВт",
                Price = 189295
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8335RT",
                Year = 2013,
                EngineType = "8.8L дизель",
                HorsePower = "350 к.с.",
                PowerKW = "224 кВт",
                Price = 145000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6155M",
                Year = 2024,
                EngineType = "6.8L дизель",
                HorsePower = "155 к.с.",
                PowerKW = "114 кВт",
                Price = 3065000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 8370R",
                Year = 2019,
                EngineType = "9.0L дизель",
                HorsePower = "370 к.с.",
                PowerKW = "272 кВт",
                Price = 339000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5060E",
                Year = 2023,
                EngineType = "2.9L дизель",
                HorsePower = "60 к.с.",
                PowerKW = "45 кВт",
                Price = 45000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5090E",
                Year = 2023,
                EngineType = "4.5L дизель",
                HorsePower = "90 к.с.",
                PowerKW = "67 кВт",
                Price = 65000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6R 155",
                Year = 2023,
                EngineType = "6.8L дизель",
                HorsePower = "230 к.с.",
                PowerKW = "171 кВт",
                Price = 250000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6R230",
                Year = 2023,
                EngineType = "6.8L дизель",
                HorsePower = "230 к.с.",
                PowerKW = "171 кВт",
                Price = 250000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5075M",
                Year = 2023,
                EngineType = "4.5L дизель",
                HorsePower = "75 к.с.",
                PowerKW = "56 кВт",
                Price = 70000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5095M",
                Year = 2023,
                EngineType = "4.5L дизель",
                HorsePower = "95 к.с.",
                PowerKW = "71 кВт",
                Price = 80000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6R250",
                Year = 2023,
                EngineType = "6.8L дизель",
                HorsePower = "250 к.с.",
                PowerKW = "186 кВт",
                Price = 270000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6R215",
                Year = 2023,
                EngineType = "8.8L дизель",
                HorsePower = "215 к.с.",
                PowerKW = "160 кВт",
                Price = 230000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5E 5050E",
                Year = 2023,
                EngineType = "2.9L дизель",
                HorsePower = "50 к.с.",
                PowerKW = "37 кВт",
                Price = 40000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5E 5067E",
                Year = 2023,
                EngineType = "2.9L дизель",
                HorsePower = "67 к.с.",
                PowerKW = "50 кВт",
                Price = 50000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 5M 5075M",
                Year = 2013,
                EngineType = "4.5L дизель",
                HorsePower = "95 к.с.",
                PowerKW = "71 кВт",
                Price = 80000
            });

            tractorList.Add(new TractorModel
            {
                Model = "John Deere 6M 6155M",
                Year = 2013,
                EngineType = "6.8L дизель",
                HorsePower = "155 к.с.",
                PowerKW = "114 кВт",
                Price = 150000
            });
            ShowAllTractors();
        }

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
    }
}
