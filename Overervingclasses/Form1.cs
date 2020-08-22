using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overervingclasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Eten> food = new List<Eten>();

        private void Form1_Load(object sender, EventArgs e)
        {
           Eten eten= new Eten("Apple","Red", new List<string>() { "Potassium", "carbohydrate" });
           
            Eten vlees = new Vlees("Chicken", "white","Whey");
            Eten vlees2 = new Vlees("Lamb", "Red", new List<string>() { "Potassium", "Protein" }, "whey isolaat");
           Eten vegetarisch = new Vegetarisch("Paprika","Geel", "C");
            Eten vegetarisch2 = new Vegetarisch("Tomato", "Red", "C");
            Eten groenten = new Groenten("Wortels", "oranje", new List<string>() { "Potassium", "sodium" },"A", "Sulfur");
           Eten groenten2 = new Groenten("Courgette", "Groen", new List<string>() { "¨Phosphorus" }, "B","Magnesium");
           Eten fruit = new Fruit("Mango", "Geel", new List<string>() { "Chloride" }, "C", 50.00);
            Eten fruit2 = new Fruit("Bananan", "Geel", new List<string>() { "Potassium" }, "B",20.00);
            comboBox1.Items.Add("Eten");
            comboBox1.Items.Add("Vegetarisch");
            comboBox1.Items.Add("Vlees");
            food.Add(vlees);
            food.Add(vlees2);
           food.Add(vegetarisch);
            food.Add(vegetarisch2);
            food.Add(groenten);
          food.Add(groenten2);
          food.Add(fruit);
           food.Add(fruit2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Vlees":
                    List<Vlees> vlesen = new List<Vlees>();

                    foreach (var item in food.OfType<Vlees>())
                    {
                        vlesen.Add(item);
                    }

                    listBox1.DataSource = null;
                    listBox1.DataSource = vlesen;
                    break;

                case "Vegetarisch":
                    List<Vegetarisch> vege = new List<Vegetarisch>();

                    foreach (var item in food.OfType<Vegetarisch>())
                    {
                        vege.Add(item);
                    }

                    listBox1.DataSource = null;
                    listBox1.DataSource = vege;
                    break;

                default:
                case "Eten":
                    listBox1.DataSource = null;
                    listBox1.DataSource = food;
                    break;

            }
    }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eten selected = (Eten)listBox1.SelectedItem;

            if (listBox1.DataSource != null)
            {
                label1.Text = selected.Beschrijf();
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}
