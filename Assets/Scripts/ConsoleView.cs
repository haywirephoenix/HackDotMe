using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Collections;
using UnityEngine.EventSystems;
//using BeardedManStudios.Forge.Networking.Generated;


//namespace com.hack.me{
public class ConsoleView : MonoBehaviour {
	
	
	public ConsoleController console = new ConsoleController();
	
	//bool didShow = false;
	
	public bool DebugMode;
	public bool PromptMode;
	public bool UserMode;
	
	public bool Executing;
	
	public MultiplayerMenu multiPlayerMenu;

	public GameObject Content;
	public RectTransform ContentRect;
	
	public Text Dir;
	public GameObject logObj;
	public Text logTextArea;
	public ScrollRect scrollView;
	
	public GameObject DirObj;
	//public Text DirObjTxt;
	
	public GameObject MessageObj;
	public Text MessageObjTxt;
	
	public GameObject inputObj;
	public Text inputObjTxt;
	
	public InputField inputField;
	//public EventSystem eventSystem;
	
	public Transform gameManager;
	
	public bool LoggedIn;
	public bool Prompt;
	
	public string ipAddress;
	public string portNumber;
	public string currentUsr;
	public string currentSvr;
	public string currentDir;
	public string caret;
	public string UserString;
	public string messageStr;

	void Start() {
		
		multiPlayerMenu = GameObject.FindWithTag("GameManager").GetComponent<MultiplayerMenu>();
		
		ContentRect = Content.GetComponent<RectTransform>();
		
		messageStr = "";
		
		
		
		/*if (networkObject.IsOwner)
		{
		Debug.Log("Client");
		console.runCommandString("echo Client", true);
		return;
		}*/

		setUserString();
		
		
		if (console != null) {
			checkLogEmpty();
			console.logChanged += onLogChanged;
			console.promptChanged += onPromptChanged;
			console.userModeChanged += onUserModeChanged;
			console.userNameChanged += onUserNameChanged;
			
			console.startHosting += onStartHosting;
			console.startJoining += onStartJoining;
			
			console.debugMode = DebugMode;
			
			console.userMode = UserMode;
			console.loggedIn = LoggedIn;
			console.userString = UserString;
			console.userName = currentUsr;
			
			//console.hostAddress = ipAddress;
			
			PromptMode = console.promptMode;
			messageStr = console.messageStr;
			
			
			//StartCoroutine(Counter(10,0.1f)); //hello
		}
		updateLogStr(console.log);
		
	}
	 
	~ConsoleView() {
		
		console.logChanged -= onLogChanged;
		console.promptChanged -= onPromptChanged;
		console.executingChanged -= onExecutingChanged;
		console.loggedInChanged -= onloggedInChanged;
		console.userModeChanged -= onUserModeChanged;
		console.userNameChanged -= onUserNameChanged;
		
		console.startHosting -= onStartHosting;
		console.startJoining -= onStartJoining;
	}
	
	void setUserString(){
		if(currentUsr == "") {currentUsr = "guest";}
		
		if(currentSvr == "") {currentSvr = "hdot";}
		
		if(currentDir == "") {currentDir = "~";}
		
		if(caret == ""){ caret = "$";}
		
		
		UserString = currentUsr +"@"+currentSvr+":" + currentDir + "" + caret + " ";
		
		Dir.text = UserString;
	}
	
	void Update() {
		
		/*
		if(!LoggedIn){
			LoggedIn = console.loggedIn;
		}
		*/
		//PromptMode = console.promptMode;
		
		//togglePrompt(PromptMode);
		
		
		//SelectInput();
		
		//checkExecuting();
		
		
	}
	
	void togglePrompt(bool prompt){
		
		if(prompt){
			//MessageObjTxt.enabled = true;
			//DirObjTxt.enabled = false;
			Dir.text = messageStr;
		}else{
			//MessageObjTxt.enabled = false;
			//DirObjTxt.enabled = true;
			Dir.text = UserString;
		}
		
	}
	void toggleInput(bool active){
		if(active){
			//inputObjTxt.enabled = true;
			inputObj.SetActive(true);
		}else{
			//inputObjTxt.enabled = false;
			inputObj.SetActive(false);
		}
	}
	
	public void onStartHosting(string[] hostAddress){
		
		multiPlayerMenu.Host();
		
		string hostAddress1 = multiPlayerMenu.ipAddress+":"+multiPlayerMenu.portNumber;
		
		console.appendLogLine("Hosting on "+hostAddress1);
	}
	
	public void onStartJoining(string[] joinAddress){
		
		multiPlayerMenu.Connect(joinAddress[0]);
		
		//string hostAddress1 = multiPlayerMenu.ipAddress+":"+multiPlayerMenu.portNumber;
		
		console.appendLogLine("Joining "+joinAddress[0]);
	}
	
	/*
	void checkExecuting(){
		
	if (Executing){
			
	if(inputObj.activeSelf){
	inputObj.SetActive(false);
	}
			
	}else{
			
	if(!inputObj.activeSelf){
				
	inputObj.SetActive(true);
	}
			
	}
	}*/
	
	IEnumerator Counter (int number, float speed) {
		//float iduration = Time.time + duration;
		float counter = 0;
		while (counter<number)
		{
			Executing = true;
			console.runCommandString("echo "+counter, true);
			counter++;
			yield return new WaitForSeconds(speed);
		
			Canvas.ForceUpdateCanvases ();
			scrollView.verticalNormalizedPosition = 0f;
			Canvas.ForceUpdateCanvases ();
			
			
		}
		Executing = false;
	}
	
	
	
	void checkLogEmpty(){
		
		if(console.log == null){
			updateLogStr(null);
			
			
		}
		
		if(logTextArea.text.Length == 0){
		
			logObj.SetActive(false);
		}else{
			logObj.SetActive(true);
		}
	}
	
	void setVisibility(GameObject Go, bool visible) {
		Go.SetActive(visible);
	}
	/*
	void toggleVisibility() {
	setVisibility(!viewContainer.activeSelf);
	}
	
	
	void onVisibilityChanged(bool visible) {
	setVisibility(visible);
	}*/
	
	public void onLogChanged(List<string> newLog) {
		updateLogStr(newLog);
		ForceScrollDown();
		checkLogEmpty();
	}
	
	/*void onLogCleared(string[] newLog) {
		logTextArea.text = "";
	}*/
	
	void onExecutingChanged(bool Executing) {
		Debug.Log("executing changed");
		
	}
	
	void onPromptChanged(bool promptMode) {
		messageStr = console.messageStr;
		PromptMode = console.promptMode;
		togglePrompt(PromptMode);
		
	}
	void onloggedInChanged(bool loggedIn) {
		Debug.Log("login changed");
		
	}
	void onUserModeChanged(bool userMode) {
		messageStr = console.messageStr;
		UserMode = console.userMode;
		togglePrompt(UserMode);
	}
	
	void onUserNameChanged(string userName){
		currentUsr = userName;
		setUserString();
		UserMode = false;
		togglePrompt(false);
		
	}
	
	
	public void updateLogStr(List<string> newLog) {
		if (newLog == null) {
			logTextArea.text = "";
		} else {
			logTextArea.text = string.Join("\n", newLog.ToArray());
		}
	}

	
	public void runCommand(bool silent) {
		if(UserMode){
			console.setusr(inputField.text);
		}
		/*if(PromptMode){
			console.runPromptString(inputField.text);
		}*/else{
			console.runCommandString(inputField.text, silent);
		}
		inputField.text = "";
		checkLogEmpty();
		StartCoroutine(ForceScrollDown());
		//SelectInput();
	}
	
	
	/*public void SelectInput(){
	if(EventSystem.current.currentSelectedGameObject != inputField.gameObject){
	EventSystem.current.SetSelectedGameObject(inputField.gameObject, null);
	inputField.OnPointerClick(new PointerEventData(EventSystem.current));
	}

	}*/
	
	public void ForceUpdateCanvases(){
		LayoutRebuilder.ForceRebuildLayoutImmediate(ContentRect);
		//Debug.Log("Updated");
	}
	
	IEnumerator ForceScrollDown () {
		yield return new WaitForEndOfFrame ();
		Canvas.ForceUpdateCanvases ();
		scrollView.verticalNormalizedPosition = 0f;
		Canvas.ForceUpdateCanvases ();
	}

}
//}
