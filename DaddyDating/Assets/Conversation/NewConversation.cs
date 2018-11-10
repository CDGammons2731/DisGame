using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewConversation : MonoBehaviour {
    public GameObject playerimage;
    public GameObject npcimage;
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public GameObject Option4;
    public Text text;
    public int wordIndex = 0;
    public string[] ConversateWords;
    public bool Player = true;
    public bool Narrator = false;
    public bool FruitLoops = false;

    void Start()
    {
        if (Narrator == false)
        {
            playerimage.SetActive(true);
            npcimage.SetActive(false);
        }
        else
        {
            playerimage.SetActive(false);
            npcimage.SetActive(false);
            Narrator = false;
        }
        Option1.SetActive(false);
        Option2.SetActive(false);
        Option3.SetActive(false);
        Option4.SetActive(false);
        text.text = ConversateWords[wordIndex];
        wordIndex++;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) || FruitLoops == true)
        {
            FruitLoops = false;
            if (wordIndex < ConversateWords.Length)
            {
                if (Narrator == false)
                {
                    if (Player == false)
                    {
                        Option1.SetActive(false);
                        Option2.SetActive(false);
                        Option3.SetActive(false);
                        Option4.SetActive(false);
                        playerimage.SetActive(false);
                        npcimage.SetActive(true);
                        text.text = ConversateWords[wordIndex];
                        Player = true;
                        wordIndex++;
                    }
                    else
                    {
                        Option1.SetActive(true);
                        Option2.SetActive(true);
                        Option3.SetActive(true);
                        Option4.SetActive(true);
                        playerimage.SetActive(true);
                        npcimage.SetActive(false);
                        text.text = ConversateWords[wordIndex];
                        Player = false;
                        wordIndex++;
                    }
                }
                else
                {
                    playerimage.SetActive(false);
                    npcimage.SetActive(false);
                    text.text = ConversateWords[wordIndex];
                    wordIndex++;
                }
            }
        }      
    }
}
