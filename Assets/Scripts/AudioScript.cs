using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour {
    public GameObject Questions;
    public AudioClip bell;
    public AudioSource bellSound;

	// Use this for initialization
	void Start () {
        bellSound.clip = bell;
	}

    public void PlaySound()
    {
        bellSound.Play();
    }

	// Update is called once per frame
	void Update () {
        Button q = Questions.GetComponent<Button>();
        q.onClick.AddListener(PlaySound);
	}
}
