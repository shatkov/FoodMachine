using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAutomat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            int countSugar  = (int)numericUpDown1.Value;
            string nameDrink = "";


            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    nameDrink = rb.Text;
                }
            }



            FoodAuto foodAuto = new FoodAuto();

            DrinkBuilder builder = new CoffeeBuilder();
            Drink coffee = foodAuto.Create(builder, nameDrink, countSugar);
            
            richTextBox1.Text = coffee.ToString();

        }
    }

    class Coffee{ }
    class Tea { }
    class Water{ }
    class Sugar
    {
        public int Quantity { get; set; }
    }

    class Drink
    {
        string Name;
        public Coffee Coffee { get; set; }
        public Tea Tea { get; set; }
        public Water Water { get; set; }
        public Sugar Sugar { get; set; }

        public Drink(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Name))
                sb.Append("Наименование напитка "+ Name);
            if (Coffee != null)
                sb.Append("Кофе\n");
            if (Tea != null)
                sb.Append("Чай\n");
            if (Water != null)
                sb.Append("Вода\n");
            if (Sugar != null)
                sb.Append("Сахар: " + Sugar.Quantity + " \n");
            return sb.ToString();
        }
    }
    // абстрактный класс строителя
    abstract class DrinkBuilder
    {
        public Drink Drink { get; private set; }
        public void CreateDrink(string nameDrink)
        {
            Drink = new Drink(nameDrink);
        }
        public abstract void AddCoffee();
        public abstract void AddTea();
        public abstract void AddWater();
        public abstract void AddSugar(int qSugar = 0);
    }
    // пекарь
    class FoodAuto
    {
        public Drink Create(DrinkBuilder DrinkBuilder, string nameDrink, int qSugar)
        {
            DrinkBuilder.CreateDrink(nameDrink);
            DrinkBuilder.AddCoffee();
            DrinkBuilder.AddTea();
            DrinkBuilder.AddWater();
            DrinkBuilder.AddSugar(qSugar);
            return DrinkBuilder.Drink;
        }
    }
    // строитель coffee
    class CoffeeBuilder : DrinkBuilder
    {
        public override void AddCoffee()
        {
            this.Drink.Coffee = new Coffee();
        }

        public override void AddTea()
        {
           //не используется
        }

        public override void AddWater()
        {
            this.Drink.Water = new Water();
        }

        public override void AddSugar(int qSugar)
        {
            this.Drink.Sugar = new Sugar { Quantity = qSugar };
        }
    }


    // строитель tea
    class TeaBuilder : DrinkBuilder
    {
        public override void AddCoffee()
        {
            //не используется
        }

        public override void AddTea()
        {
            this.Drink.Tea = new Tea();
        }

        public override void AddWater()
        {
            this.Drink.Water = new Water();
        }

        public override void AddSugar(int qSugar)
        {
            this.Drink.Sugar = new Sugar { Quantity = qSugar };
        }
    }
}
