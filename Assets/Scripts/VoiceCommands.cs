using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceCommands : MonoBehaviour
{
	private KeywordRecognizer keywordRecognizer;
	private Dictionary<string, Action> actions = new Dictionary<string, Action>();

	void Start(){
		actions.Add("bigger", Bigger);
		actions.Add("smaller", Smaller);
		actions.Add("reset", Reset);
		actions.Add("limitoff", Limitoff);
		keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), ConfidenceLevel.Low);
		keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
		keywordRecognizer.Start();
	}

	private void RecognizedSpeech(PhraseRecognizedEventArgs speech){
		Debug.Log(speech.text);
		actions[speech.text].Invoke();
	}

	private void Bigger(){
		// Fission, give preference to keyboard over voice
		if (!(Input.GetKey("t") || Input.GetKey("r")
			|| Input.GetKey("f") || Input.GetKey("g"))
			|| Input.GetKey("v") || Input.GetKey("b"))
		StartCoroutine(waiter(new Vector3(0.2f,0.2f,0.2f)));
	}

	private void Smaller(){
		// Fission, give preference to keyboard over voice
		if (!(Input.GetKey("t") || Input.GetKey("r")
			|| Input.GetKey("f") || Input.GetKey("g"))
			|| Input.GetKey("v") || Input.GetKey("b"))
		StartCoroutine(waiter(new Vector3(-0.2f,-0.2f,-0.2f)));
	}

	private void Reset(){
		transform.position += new Vector3(0,0,0);
		transform.rotation = Quaternion.Euler(0, 180, 0);
	}

	private void Limitoff(){
		StartCoroutine(repeater());
	}

	IEnumerator waiter(Vector3 t){
		for(int i = 0; i < 10; i++){

			if (transform.localScale[0] > 0.5 && transform.localScale[0] < 20
				&& transform.localScale[1] > 0.5 && transform.localScale[1] < 20
				&& transform.localScale[2] > 0.5 && transform.localScale[2] < 20){


				transform.localScale += t; 
				yield return new WaitForSeconds(0.2f);


			}
		}
			transform.localScale = new Vector3(Mathf.Clamp(transform.localScale[0],0.55f,19.95f),
			Mathf.Clamp(transform.localScale[1],0.55f,19.95f),
			Mathf.Clamp(transform.localScale[2],0.55f,19.95f));

	}

	IEnumerator repeater(){
		for(int i = 0; i < 20; i++){

						if (Input.GetKey("t"))
						{
							if (transform.localScale[2] < 35) { 
								transform.localScale += new Vector3(0, 0, 0.5f); 
							}
						}

						if (Input.GetKey("r"))
						{
							if (transform.localScale[2] > 0.5)
							{
								transform.localScale += new Vector3(0, 0, -0.5f);
							}
						}

						///////////X///////////
						if (Input.GetKey("g"))
						{
							if (transform.localScale[0] < 35)
							{
								transform.localScale += new Vector3(0.5f, 0, 0);
							}

						}

						if (Input.GetKey("f"))
						{
							if (transform.localScale[0] > 0.5 )
							{
									transform.localScale += new Vector3(-0.5f, 0, 0);
							}
						}


						/////////Y/////////
						if (Input.GetKey("b"))
						{
							if (transform.localScale[1] < 35)
							{
								transform.localScale += new Vector3(0, 0.5f, 0);
							}
						}

						if (Input.GetKey("v"))
						{
							if (transform.localScale[1] > 0.5)
							{
								transform.localScale += new Vector3(0, -0.5f, 0);
							}
						}
				yield return new WaitForSeconds(0.1f);


			
		}

	}


}