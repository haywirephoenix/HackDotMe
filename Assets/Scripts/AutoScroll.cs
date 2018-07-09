using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(ScrollRect))]
//public class AutoScroll : ScrollRect {
public class AutoScroll : MonoBehaviour {
	
	private ScrollRect scrollRect;
	

	void Start(){
		scrollRect = transform.GetComponent<ScrollRect>();
		
	}
	
	public void ScrollToBottom(){
	
		StartCoroutine(ForceScrollDown());
	}
		

	
	public IEnumerator ForceScrollDown () {
		// Wait for end of frame AND force update all canvases before setting to bottom.
		yield return new WaitForEndOfFrame ();
		Canvas.ForceUpdateCanvases ();
		scrollRect.verticalNormalizedPosition = 0f;
		Canvas.ForceUpdateCanvases ();
	}
	
}
