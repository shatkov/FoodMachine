using System;
using System.Text;
using FoodAutomat.Components.Drink;

namespace FoodAutomat
{
    internal class Drink
    {
        private readonly string _name;

        public Coffee Coffee { get; internal set; }
        public Tea Tea { get; internal set; }
        public Water Water { get; internal set; }

        public Sugar Sugar { get; internal set; }
        public Milk Milk { get; internal set; }
        public Syrup Syrup { get; internal set; }
        public CappuccinoFoam CappuccinoFoam { get; internal set; }

        public Drink(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(_name))
                sb.Append(_name);
            if (Coffee != null)
                sb.Append(" (Кофе зерновой");
            if (Tea != null)
                sb.Append(" (Чай пакетезированный");
            if (Water != null && Tea == null && Coffee == null)
                sb.Append(" (Вода");
            else if(Water != null)
                sb.Append(" + Вода");
            if (Milk != null)
                sb.Append(" + Молоко");
            if(Syrup != null)
                sb.Append(" + Сироп");
            if (CappuccinoFoam != null)
                sb.Append(" + Молочная пенка");
            if (Sugar != null && Sugar.Quantity != 0)
                sb.Append(" + Сахар(" + Sugar.Quantity + " ед.)");
            sb.Append(")");
            return sb.ToString();
        }
        /// <summary>
        /// Сумма цен компонентов
        /// </summary>
        /// <returns>стоимость напитка</returns>
        public int GetPrice()
        {
            int sum = Coffee?.Price ?? 0;
            sum += Tea?.Price ?? 0;
            sum += Water?.Price ?? 0;
            sum += Milk?.Price ?? 0;
            sum += Syrup?.Price ?? 0;
            sum += CappuccinoFoam?.Price ?? 0;
            sum += Sugar?.Price * Sugar?.Quantity ?? 0;
            return sum;
        }
    }
}
