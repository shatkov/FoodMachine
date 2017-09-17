namespace FoodAutomat.Components.Drink
{
    /// <summary>
    /// Компонент напитка Сахар
    /// </summary>
    internal class Sugar : Component
    {
        public readonly int Quantity;

        internal Sugar(int price, int quantity) : base(price)
        {
            Quantity = quantity;
        }
    }
}
