using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class GetName : MonoBehaviour {

    public Text display;
    public Text buttonClicked;
    public Text TypeText;
    string lastWord;
    public GameObject done;
    public string WordInProg;
    public List<string> WordInProgList;
    public GameObject keyboardImage;

    //adding spaces

    public void Keyboard()
    {
        /*if (display.text == "")
        {
            display.text = display.text + EventSystem.current.currentSelectedGameObject.name;
        }
        else
        {
            display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name;
        }*/
        TypeText.text = TypeText.text + EventSystem.current.currentSelectedGameObject.name;
    }
    
    //figure out how to combine some of these functions
    public void MakeWord()
    {
        WordInProgList.Add(EventSystem.current.currentSelectedGameObject.name);
        
    }

    public void JoinLetters()
    {
        //WordInProg = string.Join("", WordInProgList.ToArray());
        buttonClicked.text = TypeText.text;
        if (display.text == "")
        {
            display.text = buttonClicked.text;
        }
        else
        {
            display.text = display.text + " " + buttonClicked.text;
        }
        WordInProg = "";
        WordInProgList.Clear();
    }
    
    
    public void Wear()
    {
        if (display.text == "")
        {
            display.text = "wear";
            buttonClicked.text = "wear";
        }
        else
        {
            display.text = display.text + " wear";
            buttonClicked.text = " wear";
        }
    }
    public void Restroom()
    {
        if (display.text == "")
        {
            display.text = "to use the restroom";
            buttonClicked.text = "to use the restroom";
        }
        else
        {
            display.text = display.text + " to use the restroom";
            buttonClicked.text = " to use the restroom";
        }
            
    }

    public void JiboName()
    {
        if (display.text == "")
        {
            display.text = EventSystem.current.currentSelectedGameObject.name;
            buttonClicked.text = "Jeebo";
        }
        else
        {
            display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name;
            buttonClicked.text = "Jeebo";
        }
    }

    public void GettingName () {
        if (display.text == "")
        {
            display.text = EventSystem.current.currentSelectedGameObject.name;
            buttonClicked.text = EventSystem.current.currentSelectedGameObject.name;
        }
        else
        {
            display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name;
            buttonClicked.text = EventSystem.current.currentSelectedGameObject.name;
        }
    }

    //go and watch only two exceptions
    public void EndsInES()
    {
        var words = display.text.Split(' ');
        lastWord = words.Last();
        if (words.Length >= 3)
        {
            if ((lastWord != "Jibo" && lastWord != "Mom" && lastWord != "Dad" && lastWord != "he"
            && lastWord != "she" && lastWord != "teacher" && lastWord != "brother" &&
            lastWord != "sister" && lastWord != "aide") || (words[words.Length - 3] == "I" ||
            words[words.Length - 3] == "People" || words[words.Length - 3] == "Mom" ||
            words[words.Length - 3] == "Dad" || words[words.Length - 3] == "me" ||
            words[words.Length - 3] == "he" || words[words.Length - 3] == "she" ||
            words[words.Length - 3] == "you" || words[words.Length - 3] == "teacher" ||
            words[words.Length - 3] == "sister" || words[words.Length - 3] == "aide") &&
            words[words.Length - 2] == "and")
            {
                GettingName();
            }
            else
            {
                display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name + "es";
                buttonClicked.text = EventSystem.current.currentSelectedGameObject.name + "es";
            }
        }
        else
        {
            if (buttonClicked.text == "Jeebo" || buttonClicked.text == "Mom" || buttonClicked.text == "Dad" || buttonClicked.text == "he"
            || buttonClicked.text == "she" || buttonClicked.text == "teacher" || buttonClicked.text == "brother" ||
            buttonClicked.text == "sister" || buttonClicked.text == "aide")
            {
                display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name + "es";
                buttonClicked.text = EventSystem.current.currentSelectedGameObject.name + "es";
            }
            else
            {
                GettingName();
            }
        }
    }

    public void GettingNameActions()
    {
        var words = display.text.Split(' ');
        lastWord = words.Last();
        if (words.Length >= 3)
        {
            if ((lastWord != "Jibo" && lastWord != "Mom" && lastWord != "Dad" && lastWord != "he"
            && lastWord != "she" && lastWord != "teacher" && lastWord != "brother" &&
            lastWord != "sister" && lastWord != "aide") || (words[words.Length - 3] == "I" ||
            words[words.Length - 3] == "People" || words[words.Length - 3] == "Mom" ||
            words[words.Length - 3] == "Dad" || words[words.Length - 3] == "me" ||
            words[words.Length - 3] == "he" || words[words.Length - 3] == "she" ||
            words[words.Length - 3] == "you" || words[words.Length - 3] == "teacher" ||
            words[words.Length - 3] == "sister" || words[words.Length - 3] == "aide") &&
            words[words.Length - 2] == "and")
            {
                GettingName();
            }
            else
            {
                display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name + "s";
                buttonClicked.text = EventSystem.current.currentSelectedGameObject.name + "s";
            }
        }
        else
        {
            if (buttonClicked.text == "Jeebo" || buttonClicked.text == "Mom" || buttonClicked.text == "Dad" || buttonClicked.text == "he"
            || buttonClicked.text == "she" || buttonClicked.text == "teacher" || buttonClicked.text == "brother" ||
            buttonClicked.text == "sister" || buttonClicked.text == "aide")
            {
                display.text = display.text + " " + EventSystem.current.currentSelectedGameObject.name + "s";
                buttonClicked.text = EventSystem.current.currentSelectedGameObject.name + "s";
            }
            else
            {
                GettingName();
            }
        }
        
    }
    
    void Update()
    {
         
    }

}
