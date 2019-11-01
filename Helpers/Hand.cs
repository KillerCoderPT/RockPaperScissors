using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgaints { get; set; }
        public OptionRPS LosesAgaints { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }
            else if (LosesAgaints == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }

            return GameStatus.Victory;
        }
    }
}
