namespace FoodAutomat
{
    /// <summary>
    /// Абстрактный строитель напитков
    /// </summary>
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
        public abstract void AddMilk(bool isAdd);
        public abstract void AddSyrup(bool isAdd);
        public abstract void AddCappuccinoFoam (bool isAdd);
        public abstract void AddSugar(int qSugar = 0);

        public static DrinkBuilder GetBuilderForNameDrink(string nameDrink)
        {
            DrinkBuilder builder;
            if (nameDrink.ToLower().Contains("вода"))
                builder = new WaterBuilder();
            else if (nameDrink.ToLower().Contains("чай"))
                builder = new TeaBuilder();
            else
                builder = new CoffeeBuilder();
            return builder;
        }
    }

    /// <summary>
    /// Строитель кофе
    /// </summary>
    class CoffeeBuilder : DrinkBuilder
    {
        public override void AddCoffee()
        {
            this.Drink.Coffee = new Coffee(30);
        }

        public override void AddTea()
        {
            //не используется
        }

        public override void AddWater()
        {
            this.Drink.Water = new Water(20);
        }

        public override void AddSugar(int qSugar)
        {
            this.Drink.Sugar = new Sugar(3, qSugar);
        }

        public override void AddMilk(bool isAdd)
        {
            this.Drink.Milk = isAdd ? new Milk(10) : null;
        }

        public override void AddSyrup(bool isAdd)
        {
            this.Drink.Syrup = isAdd ? new Syrup(5) : null;
        }

        public override void AddCappuccinoFoam(bool isAdd)
        {
            this.Drink.CappuccinoFoam = isAdd ? new CappuccinoFoam(10) : null;
        }
    }

    /// <summary>
    // строитель чая
    /// </summary>
    class TeaBuilder : DrinkBuilder
    {
        public override void AddCoffee()
        {
            //не используется
        }

        public override void AddTea()
        {
            this.Drink.Tea = new Tea(5);
        }

        public override void AddWater()
        {
            this.Drink.Water = new Water(20);
        }

        public override void AddSugar(int qSugar)
        {
            this.Drink.Sugar = new Sugar(3, qSugar);
        }

        public override void AddMilk(bool isAdd)
        {
            this.Drink.Milk = isAdd ? new Milk(10) : null;
        }

        public override void AddSyrup(bool isAdd)
        {
            this.Drink.Syrup = isAdd ? new Syrup(5) : null;
        }

        public override void AddCappuccinoFoam(bool isAdd)
        {
            //не используется
        }
    }

    /// <summary>
    /// строитель воды
    /// </summary>
    class WaterBuilder : DrinkBuilder
    {
        public override void AddCoffee()
        {
            //не используется
        }

        public override void AddTea()
        {
            //не используется
        }

        public override void AddWater()
        {
            this.Drink.Water = new Water(20);
        }

        public override void AddSugar(int qSugar)
        {
            this.Drink.Sugar = new Sugar(3, qSugar);
        }

        public override void AddMilk(bool isAdd)
        {
            //не используется
        }

        public override void AddSyrup(bool isAdd)
        {
            this.Drink.Syrup = isAdd ? new Syrup(5) : null;
        }

        public override void AddCappuccinoFoam(bool isAdd)
        {
            //не используется
        }
    }
}
