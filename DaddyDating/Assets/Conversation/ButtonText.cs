using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour {
    public Text OptionOne, OptionTwo, OptionThree, OptionFour;
    int Choices = 1;
    public NewConversation yes;

    void Start()
    {
        GameObject theConvoObject = GameObject.FindGameObjectWithTag("TheConvo");
        yes = theConvoObject.GetComponent<NewConversation>();
        OptionOne.text = "";
        OptionTwo.text = "";
        OptionThree.text = "";
        OptionFour.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Choices++;
        }

        if (Choices == 2)
        {

            OptionOne.text = "Guess what? I finally got paid today.";
            OptionTwo.text = "Finally finished the job. Guessed who killed it.";
            OptionThree.text = "";
            OptionFour.text = "";
        }

        if (Choices == 4)
        {
            OptionOne.text = "Well you know what they say.";
            OptionTwo.text = "You know who I heard say that recently?";
            OptionThree.text = "";
            OptionFour.text = "";
        }

        if(Choices == 6)
        {
            OptionOne.text = "And that’s just where I like to keep it. Me in the know and you guessing. You mind pouring me some beer?";
            OptionTwo.text = "Well that just seems irritating if not knowing. You mind pouring me some of that beer now? I’m starting to get thirsty.";
            OptionThree.text = "";
            OptionFour.text = "";
        }

        if(Choices == 8)
        {
            OptionOne.text = "I got my eye on you old buddy.";
            OptionTwo.text = "I’ve learned all your tricks and I got my eye on your movements.";
            OptionThree.text = "";
            OptionFour.text = "";
        }

        if (Choices == 10)
        {
            OptionOne.text = "What do you mean?";
            OptionTwo.text = "How you figure?";
            OptionThree.text = "";
            OptionFour.text = "";
        }

        if (Choices == 12)
        {
            OptionOne.text = "You didn’t give me beer did you?";
            OptionTwo.text = "";
            OptionThree.text = "";
            OptionFour.text = "";
        }

        if (Choices == 14)
        {
            OptionOne.text = "If this isn’t beer I’m not paying for this.";
            OptionTwo.text = "You can’t fool me. I know exactly what you’ve done.";
            OptionThree.text = "*Drinks without fear* This isn’t beer!";
            OptionFour.text = "I think I’ll pass on the drink for now.";
        }
    }
}
