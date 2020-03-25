using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerScript : MonoBehaviour
{
    public Sprite[] cardFaces;
    public GameObject cardPrefab;

    public static string[] suits = new string[] { "C", "D", "H", "S" };
    public static string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    public List<string> deck;

    // Start is called before the first frame update
    void Start()
    {
        NextHand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextHand()
    {
        deck = GenerateDeck();
        Shuffle(deck);

        //test cards in deck
        foreach (string card in deck)
        {
            print(card);
        }
        DealHand();
    }

    public static List<string> GenerateDeck()
    {
        List<string> newDeck = new List<string>();
        foreach (string s in suits)
        {
            foreach (string v in values)
            { 
                newDeck.Add(s + v);
            }
        }

        return newDeck;
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    void DealHand()
    {
        float yOffset = 0;
        float zOffset = 0.03f;
        foreach (string card in deck)
        {
            GameObject newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z - zOffset), Quaternion.identity);
            newCard.name = card;
            newCard.GetComponent<RoundSection>().faceUp = true;

            yOffset = yOffset + 0.3f;
            zOffset = zOffset + 0.03f;
        }
    }
}
