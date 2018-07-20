using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public Text buttonClicked;

    TextToSpeech tts;
    void Start()
    {
        tts = GetComponent<TextToSpeech>();
    }

    public void Speak()
    {
        tts.Speak(buttonClicked.text, (string msg) =>
        {
            tts.ShowToast(msg);
        });
    }
    public void ChangeSpeed()
    {
        tts.SetSpeed(0.5f);
    }
    public void ChangeLanguage()
    {
        tts.SetLanguage(TextToSpeech.Locale.UK);
    }
    public void ChangePitch()
    {
        tts.SetPitch(0.6f);
    }
}
