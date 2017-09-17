namespace FoodAutomat
{
    class FoodAuto
    {
        /// <summary>
        /// Создание напитка
        /// </summary>
        /// <param name="DrinkBuilder">Строитель напитка(тип напитка)</param>
        /// <param name="nameDrink">Наименование напитка</param>
        /// <param name="qSugar">Количество едениц сахара</param>
        /// <param name="addMilk">Наличие молока</param>
        /// <param name="addSyrup">Наличие сиропа</param>
        /// <param name="addCappuccinoFoam">Наличие молочной пенки</param>
        /// <returns>Напиток(Drink)</returns>
        public Drink CreateDrink(DrinkBuilder DrinkBuilder, string nameDrink, int qSugar, bool addMilk, bool addSyrup, bool addCappuccinoFoam)
        {
            DrinkBuilder.CreateDrink(nameDrink);
            DrinkBuilder.AddCoffee();
            DrinkBuilder.AddTea();
            DrinkBuilder.AddWater();
            DrinkBuilder.AddMilk(addMilk);
            DrinkBuilder.AddSyrup(addSyrup);
            DrinkBuilder.AddSugar(qSugar);
            DrinkBuilder.AddCappuccinoFoam(addCappuccinoFoam);
            return DrinkBuilder.Drink;
        }

        /// <summary>
        /// Создание блюда
        /// </summary>
        /// <param name="DishBuilder">Строитель блюда(тип блюда)</param>
        /// <param name="nameDish">Наименование блюда</param>
        /// <param name="addBread">Наличие хлеба</param>
        /// <param name="addBun">Наличие булочки</param>
        /// <param name="addHam">Наличие ветчины</param>
        /// <param name="addCheese">Наличие сыра</param>
        /// <param name="addJam">Наличие джема</param>
        /// <returns>Блюдо(Dish)</returns>
        public Dish CreateDish(DishBuilder DishBuilder, string nameDish, bool addBread, bool addBun, bool addHam, bool addCheese, bool addJam)
        {
            DishBuilder.CreateDish(nameDish);
            DishBuilder.AddBread(addBread);
            DishBuilder.AddBun(addBun);
            DishBuilder.AddChips();
            DishBuilder.AddBiscuit();
            DishBuilder.AddHam(addHam);
            DishBuilder.AddCheese(addCheese);
            DishBuilder.AddJam(addJam);
            return DishBuilder.Dish;
        }
    }
}
