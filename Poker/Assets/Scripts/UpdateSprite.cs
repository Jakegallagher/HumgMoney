using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
    private RoundSection roundSection;
    private PokerScript pokerScript;



    // Start is called before the first frame update
    void Start()
    {
        List<string> deck = PokerScript.GenerateDeck();
        pokerScript = FindObjectOfType<PokerScript>();

        int i = 0;
        foreach (string card in deck)
        {
            if (this.name == card)
            {
                cardFace = pokerScript.cardFaces[i];
                break;
            }
            i++;
        }
        spriteRenderer = GetComponent<spriteRenderer>();
        roundSection = GetComponent<RoundSection>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roundSection.faceUp == true)
        {
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
