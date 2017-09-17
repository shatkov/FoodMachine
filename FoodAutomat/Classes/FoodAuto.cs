namespace FoodAutomat
{
    internal class FoodAuto
    {
        /// <summary>
        /// Создание напитка
        /// </summary>
        /// <param name="drinkBuilder">Строитель напитка(тип напитка)</param>
        /// <param name="nameDrink">Наименование напитка</param>
        /// <param name="qSugar">Количество едениц сахара</param>
        /// <param name="addMilk">Наличие молока</param>
        /// <param name="addSyrup">Наличие сиропа</param>
        /// <param name="addCappuccinoFoam">Наличие молочной пенки</param>
        /// <returns>Напиток(Drink)</returns>
        public Drink CreateDrink(DrinkBuilder drinkBuilder, string nameDrink, int qSugar, bool addMilk, bool addSyrup, bool addCappuccinoFoam)
        {
            drinkBuilder.CreateDrink(nameDrink);
            drinkBuilder.AddCoffee();
            drinkBuilder.AddTea();
            drinkBuilder.AddWater();
            drinkBuilder.AddMilk(addMilk);
            drinkBuilder.AddSyrup(addSyrup);
            drinkBuilder.AddSugar(qSugar);
            drinkBuilder.AddCappuccinoFoam(addCappuccinoFoam);
            return drinkBuilder.Drink;
        }

        /// <summary>
        /// Создание блюда
        /// </summary>
        /// <param name="dishBuilder">Строитель блюда(тип блюда)</param>
        /// <param name="nameDish">Наименование блюда</param>
        /// <param name="addBread">Наличие хлеба</param>
        /// <param name="addBun">Наличие булочки</param>
        /// <param name="addHam">Наличие ветчины</param>
        /// <param name="addCheese">Наличие сыра</param>
        /// <param name="addJam">Наличие джема</param>
        /// <returns>Блюдо(Dish)</returns>
        public Dish CreateDish(DishBuilder dishBuilder, string nameDish, bool addBread, bool addBun, bool addHam, bool addCheese, bool addJam)
        {
            dishBuilder.CreateDish(nameDish);
            dishBuilder.AddBread(addBread);
            dishBuilder.AddBun(addBun);
            dishBuilder.AddChips();
            dishBuilder.AddBiscuit();
            dishBuilder.AddHam(addHam);
            dishBuilder.AddCheese(addCheese);
            dishBuilder.AddJam(addJam);
            return dishBuilder.Dish;
        }
    }
}
