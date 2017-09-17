using System;
using System.Text;
using FoodAutomat.Components;
using FoodAutomat.Components.Dish;

namespace FoodAutomat
{
    internal class Dish
    {
        private string Name;

        public Bread Bread { get; internal set; }
        public Bun Bun { get; internal set; }
        public Chips Chips { get; internal set; }
        public Biscuit Biscuit { get; internal set; }

        public Ham Ham { get; internal set; }
        public Cheese Cheese { get; internal set; }
        public Jam Jam { get; internal set; }

        public Dish(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Name))
                sb.Append(Name);
            if (Bread != null)
                sb.Append(" (Хлеб");
            if (Bun != null)
                sb.Append(" (Булочка");
            if (Chips != null)
                sb.Append("(Чипсы");
            if (Biscuit != null)
                sb.Append("(Печенье");
            if (Ham != null)
                sb.Append(" + Ветчина");
            if (Cheese != null)
                sb.Append(" + Сыр");
            if (Jam != null)
                sb.Append(" + Джем");
            sb.Append(")");
            return sb.ToString();
        }
        /// <summary>
        /// Сумма цен компонентов
        /// </summary>
        /// <returns>стоимость блюда</returns>
        public int GetPrice()
        {
            int sum = Bread?.Price ?? 0;
            sum += Bun?.Price ?? 0;
            sum += Chips?.Price ?? 0;
            sum += Biscuit?.Price ?? 0;
            sum += Ham?.Price ?? 0;
            sum += Cheese?.Price ?? 0;
            sum += Jam?.Price ?? 0;
            return sum;
        }
    }
}
