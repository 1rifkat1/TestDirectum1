using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TestDirectum.FormItems;

namespace TestDirectum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создание примера, его сериализация и сохранение в JSON файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            var generatedData = JsonSerializer.Serialize(LoadExample());
            var sfd = new SaveFileDialog();
            sfd.DefaultExt = "json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, generatedData);
            }

        }
        /// <summary>
        /// Загрузка JSON файла и его диссериализация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.DefaultExt = "json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var readedData = File.ReadAllText(ofd.FileName);
                var generatedData = JsonSerializer.Deserialize<FormGeneratorData>(readedData);
            }
        }
        /// <summary>
        /// Возвращает пример блок формы.
        /// </summary>
        /// <returns></returns>
        public FormGeneratorData LoadExample()
        {
            return new FormGeneratorData
            {
                Name = "name1",
                Postmessage = "OK!",
                Items = new object[]
               {
                    new Filler {Message="Message" },
                    new Text
                    {
                        Name="Name",
                        Placeholder="Placeholder",
                        Required=true,
                        Type=ValidationRule.Email,
                        Value="123@mail.ru",
                        Label="label",
                        Class="class1",
                        Disabled=true
                    },
                    new Checkbox
                    {
                        Name="Name",
                        Placeholder="Placeholder",
                        Required=true,
                        Type=ValidationRule.Email,
                        Label="label",
                        Class="class1",
                        Disabled=true,
                        Checked=true
                    },
                    new FormItems.Button
                    {
                        Class="css-Class",
                        Text= "Text"
                    },
                    new Select
                    {
                        Name="Name",
                        Placeholder="Placeholder",
                        Required=true,
                        Type=ValidationRule.Email,
                        Value="123@mail.ru",
                        Label="label",
                        Class="class1",
                        Disabled=true,
                        Options=new Option
                        {
                            Value="Value",
                            Text="Text",
                            Selected=true
                        }

                    },
                    new Radio
                    {
                        Name="Name",
                        Placeholder="Placeholder",
                        Required=true,
                        Type=ValidationRule.Email,
                        Value="123@mail.ru",
                        Label="label",
                        Class="class1",
                        Disabled=true,
                        Options=new Option
                        {
                            Value="Value",
                            Text="Text",
                            Selected=true
                        }
                    }
               }
            };

        }
    }
}
