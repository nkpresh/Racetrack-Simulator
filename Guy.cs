using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

       


        public void UpdateLabels()
        {
            MyLabel.Text =MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }
        private void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyBet.Bettor = this;
        }
        public bool placeBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet(BetAmount, DogToWin, this) { Amount = BetAmount,Dog=DogToWin,Bettor=this };
            if (BetAmount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Collect(int Winner) {
            for (int i = 0; i < 3; i++)
            {
                Winner = i + 1;
                if (MyBet != null)
                    if (MyBet.Dog == Winner)
                    {
                        MyBet.PayOut(Winner);
                        ClearBet();
                    }
                    else
                    {
                        ClearBet();
                    }
                else
                    MessageBox.Show("Nobody Won");
            }
        }
    }
}
