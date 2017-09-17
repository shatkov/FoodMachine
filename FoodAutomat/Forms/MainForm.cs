using System;
using System.Text;
using System.Windows.Forms;

namespace FoodAutomat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Получить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddOrder_Click(object sender, EventArgs e)
        {
            Drink drink = GetFinishDrink();
            Dish dish = GetFinishDish();
            int orderSum = 0;
            StringBuilder sbRes = new StringBuilder();

            if(drink != null)
            {
                sbRes.Append(drink.ToString() + "\n");
                orderSum += drink.GetPrice();
            }
            if (dish != null)
            {
                sbRes.Append(dish.ToString() + "\n");
                orderSum += dish.GetPrice();
            }

            if(cbComplex.Checked)
            {
                if(ComplexOrder(gbAdditDrink) && ComplexOrder(gbAdditFood))
                {
                    orderSum = 90;
                }
                else
                {
                    cbComplex.Checked = false;
                    MessageBox.Show("Комплекс отменен. Для напитка/еды можно выбрать не более одной добавки", "Комплекс отменен", MessageBoxButtons.OK);
                    return;
                }
            }

            sbRes.Append("----------------------------------\n");
            sbRes.Append("Стоимость заказа: " + orderSum + "\n");
            
            string message = sbRes.ToString();
            string caption = "Информация о заказе";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result =  MessageBox.Show(message, caption, buttons);
        }
        /// <summary>
        /// Проверка соответствия правилу комплекса
        /// </summary>
        /// <param name="gp">GroupBox</param>
        /// <returns></returns>
        private bool ComplexOrder(GroupBox gp)
        {
            int i = 0;
            foreach (Object obj in gp.Controls)
            {
                if (obj.GetType().Name == "CheckBox")
                {
                    if (((CheckBox)obj).Checked)
                    {
                        i++;
                    }
                }
            }
            return i <= 1;
        }

        /// <summary>
        /// Получить конечный напиток
        /// </summary>
        /// <returns></returns>
        private Drink GetFinishDrink()
        {
            //сахар
            int countSugar = cbSugar.Checked ? (int)nUDCountSugar.Value : 0;
            //имя напитка
            string nameDrink = "";
            //молоко
            bool isMilk = cbMilk.Checked;
            //сироп
            bool isSyrup = cbSyrup.Checked;
            //молочная пенка
            bool isCappuccinoFoam = rbCappuccino.Checked;

            foreach (RadioButton rb in gbDrink.Controls)
            {
                if (rb.Checked)
                {
                    nameDrink = rb.Text.Split('(').Length != 0 ? rb.Text.Split('(')[0] : "";
                    break;
                }
            }
            if (String.IsNullOrEmpty(nameDrink)) return null;
            FoodAuto foodAuto = new FoodAuto();
            DrinkBuilder builder = DrinkBuilder.GetBuilderForNameDrink(nameDrink);
            return foodAuto.CreateDrink(builder, nameDrink, countSugar, isMilk, isSyrup, isCappuccinoFoam);
        }

        /// <summary>
        /// Получить конечное блюдо
        /// </summary>
        /// <returns></returns>
        private Dish GetFinishDish()
        {
            //имя блюда
            string nameDish = "";
            //Хлеб
            bool isBread = rbBread.Checked;
            //булочка
            bool isBun = rbBun.Checked;
            //ветчина
            bool isHam = cbHam.Checked;
            //Сыр
            bool isCheese = cbCheese.Checked;
            //джем
            bool isJam = cbJam.Checked;

            if(isBread || isBun)
            {
                nameDish = "Бутерброд";
            }
            else
            {
                foreach (RadioButton rb in gbFood.Controls)
                {
                    if (rb.Checked)
                    {
                        nameDish = rb.Text.Split('(').Length != 0 ? rb.Text.Split('(')[0] : "";
                        break;
                    }
                }
            }

            if (String.IsNullOrEmpty(nameDish)) return null;
            FoodAuto foodAuto = new FoodAuto();
            DishBuilder builder = DishBuilder.GetBuilderForNameDish(nameDish);
            return foodAuto.CreateDish(builder, nameDish, isBread, isBun, isHam, isCheese, isJam);
        }
        #region Ограничения по напиткам
        //добавить молоко к воде невозможно
        private void rbWater_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                cbMilk.Checked = false;
                cbMilk.Enabled = false;
            }
            else
            {
                cbMilk.Enabled = true;
            }
        }
        private void rbLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                cbMilk.Checked = true;
                cbMilk.Enabled = false;
            }
            else
            {
                cbMilk.Checked = false;
                cbMilk.Enabled = true;
            }
        }
        private void rbCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                cbMilk.Checked = true;
                cbMilk.Enabled = false;
            }
            else
            {
                cbMilk.Checked = false;
                cbMilk.Enabled = true;
            }
        }
        #endregion Ограничения по напиткам
        #region Ограничения по еде
        private void rbChips_CheckedChanged(object sender, EventArgs e)
        {
            bool senderChecked = ((RadioButton)sender).Checked;
            onOffAdditFood(senderChecked);
        }

        private void rbBiscuit_CheckedChanged(object sender, EventArgs e)
        {
            bool senderChecked = ((RadioButton)sender).Checked;
            onOffAdditFood(senderChecked);
        }

        private void onOffAdditFood(bool senderChecked)
        {
            foreach (CheckBox cb in gbAdditFood.Controls)
            {
                if (senderChecked)
                {
                    cb.Checked = false;
                    cb.Enabled = false;
                }
                else
                {
                    cb.Enabled = true;
                }
            }
        }
        #endregion  Ограничения по еде
    }
}
