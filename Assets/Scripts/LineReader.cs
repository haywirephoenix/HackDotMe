using UnityEngine;
using System.Collections;
using System;
using System.IO;

using System.Collections.Generic;

using UnityEngine.UI;
using System.Text;

using UnityEngine.EventSystems;


 
public class LineReader : MonoBehaviour
{
	public ConsoleController console;
	
	public ConsoleView consoleView;
	
	protected FileInfo theSourceFile = null;
	protected StreamReader reader = null;
	public TextAsset textFile;
	//	public TextTyper textTyper;
	public TypeTextComponent typeTextComponent;
	
	protected string text = " "; // assigned to allow first line to be read below
 
	public Text textArea;
	public bool printing;
	
	protected string datapath;
	
	public ScrollRect scrollRect;
	

	
	
 
	void Start () {
		
		//	scrollRect = transform.GetComponent<ScrollRect>();
		
		/*consoleView = GetComponent<ConsoleView>();
		console = GetComponent<ConsoleView>().console;*/
		//textTyper = GetComponent<TextTyper>();
		typeTextComponent = GetComponent<TypeTextComponent>();
		
		//theSourceFile = new FileInfo ("Test.txt");

		//reader = theSourceFile.OpenText();
		//if (console != null) {
		
			
		
		datapath = Application.streamingAssetsPath+"/Text/";
		
		StreamReader reader = new StreamReader(datapath+"test.txt");
			
		//typeText(reader.ReadToEnd(),-10);
		
		//typeTextComponent.TypeText("Hello");
		
		textArea = GetComponent<Text>();
		string textstr = reader.ReadToEnd();
		
		printing = true;
		
		StartCoroutine(ForceScrollDown());
		
		textArea.TypeText(textstr, 0.005f, onComplete: () => printComplete());
		
		//textArea.TypeTextJump(textstr,0f,null);
			
		//textTyper.TypeText(reader.ReadToEnd(),-10);
			
			
			//Debug.Log(reader.ReadToEnd());
			//console.appendLogLine(reader.ReadToEnd());
			//console.appendLogLine("lol");
			//Debug.Log(reader.ReadToEnd());
			reader.Close();
			
			//console.logChanged += consoleView.onLogChanged;
			//console.runCommandString("echo hello", false);
			
		//consoleView.updateLogStr(console.log);
		//	}
		
		
		
		
	}
	
	IEnumerator ForceScrollDown () {
		//Debug.Log("running");
		// Wait for end of frame AND force update all canvases before setting to bottom.
		while(printing == true){
		
		Canvas.ForceUpdateCanvases ();
		scrollRect.verticalNormalizedPosition = 0f;
		Canvas.ForceUpdateCanvases ();
			yield return new WaitForEndOfFrame ();
		}
		yield return 0; 
	}
	public void ForceUpdateCanvases(){
		LayoutRebuilder.ForceRebuildLayoutImmediate(scrollRect.transform.root.GetComponent<RectTransform>());
		//Debug.Log("Updated");
	}
	
	void printComplete(){
		printing = false;
		StopCoroutine(ForceScrollDown());
		//Debug.Log("finished");
	}
   
	void Update () {
		
		
		/*if (text != null) {
			text = reader.ReadLine();
			//Console.WriteLine(text);
			print (text);
		}*/
	}
}