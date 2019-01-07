﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Deck
    {
        public Deck() // constructor
        {
            Cards = new List<Card>(); //Cards referring to the class which is hy data type is not needed

            //Easier solution to add all cards (52 cards) to the deck
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach (string face in Faces) //loop through 4 times for each suits
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //during each loop a card is created, var ccard onlt exists in the loop
                    card.Suit = suit; //assign suit property, value of suit to each element in the list Suits
                    card.Face = face;
                    Cards.Add(card); //add new card to Cards list 
                }
            }
        }
        public List<Card> Cards { get; set; } //class with data type card with property get set

        public void Shuffle(int times = 1) //shuffle Method now belongs to the object created above
        {                                 //Deck is no longer needed because it is doing everything internally
            
            for (int i = 0; i < times; i++)
            {
                
                List<Card> TempList = new List<Card>();
                Random random = new Random();


                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //get random number between 0 & 52
                    TempList.Add(Cards[randomIndex]); //add cards to the temporary deck
                    Cards.RemoveAt(randomIndex); //delete cards from the list of cards until there is no cards list

                }
                this.Cards = TempList; //"this" is referring to itself, it's own object
            }
        }
    }
}
