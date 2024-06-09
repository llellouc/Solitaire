using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solitaire.Client.View;
using Solitaire.Common;
using Solitaire.Common.Utils;

namespace Solitaire.Client.ViewModel
{
    public class SolitaireViewModel
    {
        private Queue<CardView> _deck = new Queue<CardView>();
        private Queue<CardView> _discard = new Queue<CardView>();

        private List<List<CardView>> _foundations = new List<List<CardView>>();
        private List<List<CardView>> _boardGame = new List<List<CardView>>();


        public void InitializeBoard()
        {
            var toRet = new List<CardView>();

            for (int i = 0; i < 2; i++)
            {
                foreach (var color in Enum.GetValues<CardColor>())
                {
                    foreach (var val in Enum.GetValues<CardValue>())
                    {
                        toRet.Add(new CardView(color, val));
                    }
                }
            }s
            _deck = new Queue<CardView>(toRet.Shuffle());
        }
    }
}
