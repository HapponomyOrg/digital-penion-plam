using System.Collections.Generic;
using UnityEngine;

namespace Version1.Cards.Scripts
{
[CreateAssetMenu(fileName = "CardList", menuName ="Version2/Cards/CardList")]
    public class CardLibrary : ScriptableObject
    {
        public Card[] cards;

        private Dictionary<byte, Card> cardList;

        private void FillCardList()
        {
            cardList = new Dictionary<byte, Card>();
            foreach (var card in cards)
            {
                cardList.Add(card.ID, card);
            }
        }

        public Card CardData(byte id)
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