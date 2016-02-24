using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour {



	public void next(){
		StartCoroutine (DoFadeNext());
	}


	IEnumerator DoFadeNext (){
		
		CanvasGroup canvasGroup = GetComponent<CanvasGroup>();

			while (canvasGroup.alpha>0){
				canvasGroup.alpha -= Time.deltaTime * 2;

				yield return null;
			}

			canvasGroup.interactable = false; // makes invisble buttons unclickable

			yield return new WaitForSeconds (0.5f);
			Application.LoadLevel(Application.loadedLevel + 1);

			yield return null;
		}

	public void previous(){		
		StartCoroutine (DoFadePrevious());
	}

	IEnumerator DoFadePrevious (){
		
		CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
		
		while (canvasGroup.alpha>0){
			canvasGroup.alpha -= Time.deltaTime * 2;
			
			yield return null;
		}
		
		canvasGroup.interactable = false; // makes invisble buttons unclickable
		
		yield return new WaitForSeconds (0.5f);
		Application.LoadLevel(Application.loadedLevel - 1);
		
		yield return null;
	}

	}

	
