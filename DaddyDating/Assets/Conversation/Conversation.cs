using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour {
    public GameObject playerimage;
    public GameObject npcimage;
    public GameObject[] Buttons;
    public Text text;
    public Text[] ButtonText;
    public string[] ButtonWords;
    public string[] ConversateWords;
    public string Action;
    public bool PlayerMouthing = false;
    public int wordIndex = 0;
    public int ChoiceIndex = 0;
    public int ChoiceIndex2 = 0;
    public int mainIndex = 0;
    public bool YouChooseBlehBlehBleh = false;


	// Use this for initialization
	void Start () {
 

        if (Action == "conversation")
        {
            playerimage.SetActive(false);
            npcimage.SetActive(true);
            text.text = ConversateWords[wordIndex];
        }
        else if (Action == "narrator")
        {
            npcimage.SetActive(false);
            playerimage.SetActive(false);
            text.text = ConversateWords[wordIndex];
        }
        else if (Action == "convochoice")
        {
            ChoiceIndex = mainIndex;
            playerimage.SetActive(true);
            npcimage.SetActive(false);
            text.text = ConversateWords[wordIndex];
            if (wordIndex == 2)
            {
                ButtonText[0].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[0].SetActive(true);
                ButtonText[1].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[1].SetActive(true);
                Buttons[2].SetActive(false);
                Buttons[3].SetActive(false);
            }
            else if (wordIndex == 3)
            {
                ButtonText[0].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[0].SetActive(true);
                ButtonText[1].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[1].SetActive(true);
                ButtonText[2].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[2].SetActive(true);
                Buttons[3].SetActive(false);
            }
            else if (wordIndex == 4)
            {
                ButtonText[0].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[0].SetActive(true);
                ButtonText[1].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[1].SetActive(true);
                ButtonText[2].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[2].SetActive(true);
                ButtonText[3].text = ButtonWords[ChoiceIndex];
                ChoiceIndex++;
                Buttons[3].SetActive(true);
            }
            else if (wordIndex > 4)
            {
                Debug.Log("Options to choose from has a minimum of 2 choices to 4 choices. Redo Editor Entry and try again.");
            }
            else if (wordIndex == 1)
            {
                Debug.Log("Options to choose from has a minimum of 2 choices to 4 choices. Redo Editor Entry and try again.");
            }
            mainIndex = ChoiceIndex;
        }
        else if (Action == "end")
        {
            Debug.Log("your conversation is over");
        }
        else if (Action == "mainchoice")
        {
            text.text = "";
            ChoiceIndex = 0;
            ButtonText[0].text = ButtonWords[ChoiceIndex];
            ChoiceIndex++;
            Buttons[0].SetActive(true);
            ButtonText[1].text = ButtonWords[ChoiceIndex];
            ChoiceIndex++;
            Buttons[1].SetActive(true);
            ButtonText[2].text = ButtonWords[ChoiceIndex];
            ChoiceIndex++;
            Buttons[2].SetActive(true);
            ButtonText[3].text = ButtonWords[ChoiceIndex];
            ChoiceIndex++;
            Buttons[3].SetActive(true);
        }
        else
        {
             Debug.Log("This is a bad, bad choice daddy.");
        }
	}
	
	// Update is called once per frame
	void Update () {

            if (Input.GetKeyDown(KeyCode.Space) || YouChooseBlehBlehBleh == true)
            {
                if (Action == "narrator")
                {
                ChoiceIndex = 0;
                wordIndex = 4;
                Action = "choice";
                }

                YouChooseBlehBlehBleh = false;
                if (wordIndex < ConversateWords.Length)
                {
                    if (Action == "conversation")
                    {
                        playerimage.SetActive(false);
                        npcimage.SetActive(true);
                        text.text = ConversateWords[wordIndex];
                    }
                    else if (Action == "narrator")
                    {
                        npcimage.SetActive(false);
                        playerimage.SetActive(false);
                    }
                    else if (Action == "choice")
                    {
                        playerimage.SetActive(true);
                        npcimage.SetActive(false);
                        if (wordIndex == 2)
                        {
                            ButtonText[0].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[0].SetActive(true);
                            ButtonText[1].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[1].SetActive(true);
                            Buttons[2].SetActive(false);
                            Buttons[3].SetActive(false);
                        }
                        else if (wordIndex == 3)
                        {
                            ButtonText[0].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[0].SetActive(true);
                            ButtonText[1].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[1].SetActive(true);
                            ButtonText[2].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[2].SetActive(true);
                            Buttons[3].SetActive(false);
                        }
                        else if (wordIndex == 4)
                        {
                            ButtonText[0].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[0].SetActive(true);
                            ButtonText[1].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[1].SetActive(true);
                            ButtonText[2].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[2].SetActive(true);
                            ButtonText[3].text = ButtonWords[ChoiceIndex];
                            ChoiceIndex++;
                            Buttons[3].SetActive(true);
                        }
                        else if (wordIndex > 4)
                        {
                            Debug.Log("Options to choose from has a minimum of 2 choices to 4 choices. Redo Editor Entry and try again.");
                        }
                        else if (wordIndex == 1)
                        {
                            Debug.Log("Options to choose from has a minimum of 2 choices to 4 choices. Redo Editor Entry and try again.");
                        }
                    }
                    else if (Action == "end")
                    {
                        Debug.Log("your conversation is over");
                    }
                    else
                    {
                        Debug.Log("This is a bad, bad choice daddy.");
                    }

                    if (wordIndex == 0)
                    {
                        Buttons[0].SetActive(false);
                        Buttons[1].SetActive(false);
                        Buttons[2].SetActive(false);
                        Buttons[3].SetActive(false);
                    }

                    if (wordIndex < ConversateWords.Length)
                    {
                        text.text = ConversateWords[wordIndex];
                    }
                }
            }
		
	}
}
