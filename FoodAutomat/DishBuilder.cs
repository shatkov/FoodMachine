namespace FoodAutomat
{
    /// <summary>
    /// Абстрактный строитель блюда
    /// </summary>
    abstract class DishBuilder
    {
        public Dish Dish { get; private set; }
        public void CreateDish (string nameDish)
        {
            Dish = new Dish(nameDish);
        }
        public abstract void AddBread(bool isAdd);
        public abstract void AddBun(bool isAdd);
        public abstract void AddChips();
        public abstract void AddBiscuit();
        public abstract void AddHam(bool isAdd);
        public abstract void AddCheese(bool isAdd);
        public abstract void AddJam(bool isAdd);

        public static DishBuilder GetBuilderForNameDish(string nameDish)
        {
            DishBuilder builder;
            if (nameDish.ToLower().Contains("чипсы"))
                builder = new ChipsDishBuilder();
            else if (nameDish.ToLower().Contains("печенье"))
                builder = new BiscuitDishBuilder();
            else
                builder = new SandwichBuilder(); 
            return builder;
        }
    }

    /// <summary>
    /// строитель блюда бутерброд
    /// </summary>
    class SandwichBuilder : DishBuilder
    {
        public override void AddBread(bool isAdd)
        {
            this.Dish.Bread = isAdd ? new Bread(10) : null;
        }

        public override void AddBun(bool isAdd)
        {
            this.Dish.Bun = isAdd ? new Bun(15): null;
        }

        public override void AddCheese(bool isAdd)
        {
            this.Dish.Cheese = isAdd ? new Cheese(10) : null;
        }

        public override void AddHam(bool isAdd)
        {
            this.Dish.Ham = isAdd ? new Ham(15) : null;
        }

        public override void AddJam(bool isAdd)
        {
            this.Dish.Jam = isAdd ? new Jam(7) : null;
        }

        public override void AddBiscuit()
        {
            //не используется
        }

        public override void AddChips()
        {
            //не используется
        }
    }

    /// <summary>
    /// строитель блюда печенье
    /// </summary>
    class BiscuitDishBuilder : DishBuilder
    {
        public override void AddBread(bool isAdd)
        {
            //не используется
        }

        public override void AddBun(bool isAdd)
        {
            //не используется
        }

        public override void AddCheese(bool isAdd)
        {
            //не используется
        }

        public override void AddHam(bool isAdd)
        {
            //не используется
        }

        public override void AddJam(bool isAdd)
        {
            //не используется
        }

        public override void AddBiscuit()
        {
            this.Dish.Biscuit = new Biscuit(29);
        }

        public override void AddChips()
        {
            //не используется
        }
    }

    /// <summary>
    /// строитель блюда чипсы
    /// </summary>
    class ChipsDishBuilder : DishBuilder
    {
        public override void AddBread(bool isAdd)
        {
            //не используется
        }

        public override void AddBun(bool isAdd)
        {
            //не используется
        }

        public override void AddCheese(bool isAdd)
        {
            //не используется
        }

        public override void AddHam(bool isAdd)
        {
            //не используется
        }

        public override void AddJam(bool isAdd)
        {
            //не используется
        }

        public override void AddBiscuit()
        {
            //не используется
        }

        public override void AddChips()
        {
            this.Dish.Chips = new Chips(34);
        }
    }
}
