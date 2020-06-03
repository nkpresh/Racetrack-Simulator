using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
    
        public Bet(int Amount,int Dog,Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }
        public string GetDescription()
        {
            string description;
            if (Amount > 0)
            {
                return description=(Bettor.Name + " Bets "+Amount+" on Dog " + Dog);
            }else
            {
                return description=(Bettor.Name + " has not placed a bet yet");
            }
        }
        public int PayOut(int Winner)
        {
            if (Winner != 0)

                if (Winner == Dog)
                {
                    return Bettor.Cash += Amount;
                }
                else { return Bettor.Cash -= Amount; }
            else
                return Bettor.Cash;
        }
    }
}
