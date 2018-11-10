using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    public Conversation con;
    public Text Uppertext, DisplayResponse;
    int drinkCounter = 0;
    public float xTimer = 0;
    bool yas = false;

    void Start()
    {
        GameObject theConvoObject = GameObject.FindGameObjectWithTag("TheConvo");
        con = theConvoObject.GetComponent<Conversation>();
    }

    void Update()
    {
        if(yas == true)
        { 
            if(xTimer < 1)
            {
                xTimer += Time.deltaTime;
            } else
            {
                DisplayResponse.text = "";
                yas = false;
            }

        }
        else if(yas == false)
        {
            xTimer = 0;
        }
    }
	
	public void option1()
	{
 
		Debug.Log("You chose option 1 on the first question");
		con.YouChooseBlehBlehBleh = true;
                
        if(Uppertext.text == "Buy Drink")
        {
            con.Action = "choice";
            con.ChoiceIndex = 0;
            con.wordIndex = 4;
            DisplayResponse.text = "You buy a drink";
            yas = true;
            drinkCounter++;
            con.ChoiceIndex = 0;
        }
		if(drinkCounter>=3)
			SceneManager.LoadScene(3);
	}
	public void option2()
	{
			    Debug.Log("You chose option 1 on the first question");
                con.YouChooseBlehBlehBleh = true;

                if (Uppertext.text == "Talk")
                {
                    con.Action = "choice";
                    con.ChoiceIndex = 0;
                    con.wordIndex = 4;
                    DisplayResponse.text = "You buy a drink";
                    yas = true;
                    drinkCounter++;
                    con.ChoiceIndex = 0;
                }
    }
	public void option3()
	{
                
			    Debug.Log("You chose option 1 on the first question");
                con.YouChooseBlehBlehBleh = true;
    }
	public void option4()
	{
        if (Uppertext.text == "Buy Drink")
        {
            
        }
        Debug.Log("You chose option 1 on the first question");
        con.YouChooseBlehBlehBleh = true;
    }
}
