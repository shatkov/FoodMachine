using System;
using System.Text;

namespace FoodAutomat
{
    class Drink
    {
        string Name;

        public Coffee Coffee { get; internal set; }
        public Tea Tea { get; internal set; }
        public Water Water { get; internal set; }

        public Sugar Sugar { get; internal set; }
        public Milk Milk { get; internal set; }
        public Syrup Syrup { get; internal set; }
        public CappuccinoFoam CappuccinoFoam { get; internal set; }

        public Drink(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Name))
                sb.Append(Name);
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
            int sum = Coffee != null ? Coffee.Price : 0;
            sum += Tea != null ? Tea.Price : 0;
            sum += Water != null ? Water.Price : 0;
            sum += Milk != null ? Milk.Price : 0;
            sum += Syrup != null ? Syrup.Price : 0;
            sum += CappuccinoFoam != null ? CappuccinoFoam.Price : 0;
            sum += Sugar != null ? Sugar.Price * Sugar.Quantity : 0;
            return sum;
        }
    }
}
