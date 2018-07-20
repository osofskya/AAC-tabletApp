using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clear : MonoBehaviour {

    public GameObject clear;
    public Text display;
    public Text buttonClicked;
    public GameObject keyboardImage;
    public Text TypeText;
    
    public GameObject backspace;

    public void ClearText()
    {
        if (!keyboardImage.activeInHierarchy)
        {
            display.text = "";
            buttonClicked.text = "";
        }
        else
        {
            TypeText.text = "";
        }
    }

    public void ClearButton()
    {
        Button btn = clear.GetComponent<Button>();
        btn.onClick.AddListener(ClearText);
    }

    public void Backspace()
    {
        if (!keyboardImage.activeInHierarchy)
        {
            string[] split = display.text.Trim().Split(null);
            split = split.Where((o, i) => i != split.Length - 1).ToArray();
            display.text = string.Join(" ", split);
            buttonClicked.text = display.text.Split(' ').Last();
        }
        else
        {
            TypeText.text = TypeText.text.Remove(TypeText.text.Length-1);
        }
        //display.text = display.text.Substring(display.text.LastIndexOf(" ", display.text.Length));
    }

	// Update is called once per frame
	void Update () {
        ClearButton();
	}
}
