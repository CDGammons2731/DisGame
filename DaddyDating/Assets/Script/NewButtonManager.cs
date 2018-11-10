using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewButtonManager : MonoBehaviour {
    public NewConversation newcon;
    public Text text;


    void Start()
    {
        GameObject theConvoObject = GameObject.FindGameObjectWithTag("TheConvo");
        newcon = theConvoObject.GetComponent<NewConversation>();
    }

    public void Option1()
    {

        if (newcon.wordIndex == 2)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 4)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 6)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 8)
        {
            newcon.FruitLoops = true;

        }


        if (newcon.wordIndex == 10)
        {
            newcon.FruitLoops = true;

        }


        if (newcon.wordIndex == 12)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 14)
        {
            text.text = "Only one way to know";
            newcon.FruitLoops = true;

        }
    }

    public void Option2()
    {
        if (newcon.wordIndex == 2)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 4)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 6)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 8)
        {
            newcon.FruitLoops = true;

        }


        if (newcon.wordIndex == 10)
        {
            newcon.FruitLoops = true;

        }


        if (newcon.wordIndex == 12)
        {
            newcon.FruitLoops = true;

        }

        if (newcon.wordIndex == 14)
        {
            text.text = "Only one way to know";
            newcon.FruitLoops = true;

        }
    }

    public void Option3()
    {


        if (newcon.wordIndex == 14)
        {
            text.text = "Only one way to know";
            newcon.FruitLoops = true;

        }
    }

    public void Option4()
    {

        if (newcon.wordIndex == 14)
        {
            text.text = "Only one way to know";
            newcon.FruitLoops = true;

        }
    }
}
