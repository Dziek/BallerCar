using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour {

	public Image img;
	int counter;
	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	
		img = GetComponent<Image>();
		img.fillMethod = (Image.FillMethod)Random.Range(0,5);
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(counter > 100)
		{
			if(img.fillAmount > 0.01f)
			{
				img.fillAmount -= 0.05f;
			}
			else
			{
				gameObject.SetActive(false);
			}
		}
		else
		{
			counter++;
		}
	}
}
