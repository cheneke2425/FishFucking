using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {

    // Use this for initialization
    private GameObject[] textButton = new GameObject[4];
    private Color[] buttColor = new Color[4];
  
	void Start () {
        textButton[0] = GameObject.FindGameObjectWithTag("StartButt");
        textButton[1] = GameObject.FindGameObjectWithTag("WorkButt");
        textButton[2] = GameObject.FindGameObjectWithTag("TutButt");
        textButton[3] = GameObject.FindGameObjectWithTag("ExitButt");
        buttColor[0] = textButton[0].GetComponent<Text>().color;
        buttColor[1] = textButton[1].GetComponent<Text>().color;
        buttColor[2] = textButton[2].GetComponent<Text>().color;
        buttColor[3] = textButton[3].GetComponent<Text>().color;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        for(int i = 0; i < textButton.Length; i++)
        {
            float buttonAlpha = textButton[i].GetComponent<CanvasRenderer>().GetAlpha();
            if (buttonAlpha == 0f)
            {
                textButton[i].SetActive(false);
                Debug.Log("LOAD SCENE HERE");
            }
        }
    }
    public void onTextClick()
    {
        StartCoroutine(fadingFunction());
    }
    IEnumerator fadingFunction()
    {
        for (int i = 0; i < textButton.Length; i++)
        {
            textButton[i].GetComponent<Button>().enabled = false;
            textButton[i].GetComponent<Text>().CrossFadeAlpha(0f, 3f, false);
            //button[i].GetComponent<Text>().enabled = false;
            yield return null;
        }
    }
}
