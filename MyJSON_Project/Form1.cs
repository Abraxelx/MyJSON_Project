using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyJSON_Project.Models;
using Newtonsoft.Json;

namespace MyJSON_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();


        private void btnSaveDatas_Click(object sender, EventArgs e)
        {
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                var newCar = new Car
                {
                    CarName = txtCarName.Text,
                    CarSeries = txtCarSeries.Text,
                    CarModel = txtCarAge.Text,
                    CarColor = txtCarColor.Text
                    
                };

                var JSONResult = JsonConvert.SerializeObject(newCar);
                File.WriteAllText(sfd.FileName, JSONResult);
                MessageBox.Show("Kaydedildi.");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var json = File.ReadAllText(ofd.FileName);
                var car = JsonConvert.DeserializeObject<Car>(json);
                txtCarName.Text = car.CarName;
                txtCarSeries.Text = car.CarSeries;
                txtCarAge.Text = car.CarModel;
                txtCarColor.Text = car.CarColor;
                MessageBox.Show("Arabalar Yüklendi.");
            }
        }
    }
}
