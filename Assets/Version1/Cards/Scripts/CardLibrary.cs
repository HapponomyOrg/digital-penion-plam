using System.Collections.Generic;
using UnityEngine;

namespace Version1.Cards.Scripts
{
[CreateAssetMenu(fileName = "CardLibrary", menuName ="Version2/Cards/CardLibrary")]
    public class CardLibrary : ScriptableObject
    {
        public CardData[] cards;

        private Dictionary<int, CardData> cardList;

        private void FillCardList()
        {
            cardList = new Dictionary<int, CardData>();
            foreach (var card in cards)
            {
                cardList.Add(card.ID, card);
            }
        }

        /// <summary>
        /// CardData is a way to get all the information of a card with only its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CardData CardData(int id)
        {
            if (cardList.ContainsKey(id))
            {
                return cardList[id];
            }
            return null;
        }

        private void OnEnable()
        {
            FillCardList();
        }
    }
}
