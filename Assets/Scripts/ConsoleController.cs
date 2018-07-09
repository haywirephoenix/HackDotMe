using UnityEngine;

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UnityEngine.SceneManagement;

public delegate void CommandHandler(string[] args);

//namespace com.hack.me{
public class ConsoleController {
	
	
	public delegate bool DebugMode(bool debugMode);
	
	public delegate bool PromptMode(bool promptMode);
	
	public delegate bool UserMode(bool userMode);
	
	public delegate bool LoggedIn(bool loggedIn);
	
	
	public delegate string UserString(string userString);
	public delegate string MessageStr(string messageStr);
	
	//public delegate void LogChangedHandler(string[] log);
	public delegate void LogChangedHandler(List<string> log);
	public event LogChangedHandler logChanged;
	
	public delegate void LoggedInHandler(bool loggedIn);
	public event LoggedInHandler loggedInChanged;
	
	public delegate void UserNameChangedHandler(string userName);
	public event UserNameChangedHandler userNameChanged;
	
	public delegate void PromptModeHandler(bool promptMode);
	public event PromptModeHandler promptChanged;
	
	public delegate void UserModeHandler(bool userMode);
	public event UserModeHandler userModeChanged;
	
	public delegate void ExecuteModeHandler(bool executing);
	public event ExecuteModeHandler executingChanged;
	
	public delegate void VisibilityChangedHandler(bool visible);
	public event VisibilityChangedHandler visibilityChanged;
	
	public delegate void StartHostHandler(string[] hostAddress);
	public event StartHostHandler startHosting;
	
	public delegate void StartJoinHandler(string[] joinAddress);
	public event StartJoinHandler startJoining;


	class CommandRegistration {
		public string command { get; private set; }
		public CommandHandler handler { get; private set; }
		public string help { get; private set; }
		
		public CommandRegistration(string command, CommandHandler handler, string help) {
			this.command = command;
			this.handler = handler;
			this.help = help;
		}
	}

	const int scrollbackSize = 20;

	Queue<string> scrollback = new Queue<string>(scrollbackSize);
	List<string> commandHistory = new List<string>();
	Dictionary<string, CommandRegistration> commands = new Dictionary<string, CommandRegistration>();

	//public string[] log { get; set; }
	
	public List<string> log { get; set; }
	
	public bool debugMode { get; set; } 
	public bool promptMode { get; set; } 
	public bool userMode { get; set; } 
	public bool loggedIn { get; set; } 
	
	public string userName { get; set; }
	public string userString { get; set; } 
	public string messageStr { get; set; }
	
	public string[] hostAddress { get; set; } 
	public string[] joinAddress { get; set; } 
	
	const string repeatCmdName = "!!"; 
	
	public ConsoleController() {
		
		
		
		
		//if(loggedIn){}
			registerCommand("host", host, "Host a server");
			registerCommand("join", join, "Join a server");
			registerCommand("echo", echo, "echoes arguments back as array");

			/*registerCommand("echo", echo, "echoes arguments back as array");
			registerCommand(repeatCmdName, repeatCommand, "Repeat last command.");
			registerCommand("reload", reload, "Reload game.");
			registerCommand("resetprefs", resetPrefs, "Reset & saves PlayerPrefs.");*/
		
			//registerCommand("start", start, "Start Game");
			registerCommand("help", help, "Print this help.");
			registerCommand("setusr", setusr, "Set username");
			registerCommand("clear", clear, "Clear log");
		
	}
	
	/*void start(string[] args){
		
		
			
		
		
		}
		
	}*/
	
	void clear(string[] args){
		//Array.Clear(log,0,log.Length);
		
		log.Clear();
		commandHistory.Clear();
		scrollback.Clear();
		logChanged(log);
		
	}
	
	void setusr(string[] args){
		
		if(args.Length < 1){
			
		userMode = true;
		
		string printStr = "Type a new Username: ";
		appendLogLine(printStr);
		
		messageStr = "Username- ";			
	
			userModeChanged(true);
		
		}else{
			setusr(args[0]);
		}
		
	}
	
	public void setusr(string usrString){
		
		userString = CleanString(usrString);
		
		//userModeChanged(true);
		userName = userString;
		
		userNameChanged(userName);
		
		string printStr = "Username changed successfully.";
		appendLogLine(printStr);
	
	}
	
	void host(string[] args){
		hostAddress = new string[] {"127.0.0.1","15937"};
		startHosting(hostAddress);
	}
	
	void join(string[] args){
		if(args.Length != 1){
			//appendLogLine("Please specify an ip address:portnumber in this format.");
			appendLogLine("Please specify an ip address.");
		}else{
			//joinAddress = new string[] {"192.168.0.10","15937"};
			joinAddress = new string[] {"192.168.0.10"};
		}
		
		startJoining(args);
	}
	void setLoggedInCommands(){
		
		loggedIn = true;
		
		registerCommand("echo", echo, "echoes arguments back as array");
		registerCommand(repeatCmdName, repeatCommand, "Repeat last command.");
		registerCommand("reload", reload, "Reload game.");
		registerCommand("resetprefs", resetPrefs, "Reset & saves PlayerPrefs.");
		
		removeCommand("start");
	}
	
	void registerCommand(string command, CommandHandler handler, string help) {
		commands.Add(command, new CommandRegistration(command, handler, help));
	}
	
	void removeCommand(string command){
		commands.Remove(command);
	}
	
	public void appendLogLine(string line) {
		
		if(debugMode){
			Debug.Log(line);
		}
		
		if (scrollback.Count >= ConsoleController.scrollbackSize) {
			scrollback.Dequeue();
		}
		scrollback.Enqueue(line);
		
		//log = scrollback.ToArray();
		log = scrollback.ToList();
		if (logChanged != null) {
			logChanged(log);
		}
	}
	
	public void runPromptString(string promptString) {
		
		/*
		string[] commandSplit = parseArguments(promptString);
		string[] args = new string[0];
		if (commandSplit.Length < 1) {
			return;
		}else if (commandSplit.Length >= 2) {
			int numArgs = commandSplit.Length - 1;
			args = new string[numArgs];
			Array.Copy(commandSplit, 1, args, 0, numArgs);
		}
		runCommand(commandSplit[0].ToLower(), args);
		commandHistory.Add(promptString);
		*/
	}
	
	
	
	/*public void usernameString(string usernameString) {
		
		return CleanString(usernameString);
		
	}*/
	
	public static string CleanString(string dirtyString)
	{
		HashSet<char> removeChars = new HashSet<char>(" ?&^$#@!()+-,:;<>’\'-_*");
		StringBuilder result = new StringBuilder(dirtyString.Length);
		foreach (char c in dirtyString)
			if (!removeChars.Contains(c)) // prevent dirty chars
				result.Append(c);
		return result.ToString();
	}
	
	public void runCommandString(string commandString, bool silent) {
		
	
			
		if(!silent){
			appendLogLine(userString + " " + commandString);
		}
		
		string[] commandSplit = parseArguments(commandString);
		string[] args = new string[0];
		if (commandSplit.Length < 1) {
			//appendLogLine(string.Format("Unable to process command '{0}'", commandString));
			return;
			
		} else if (commandSplit.Length >= 2) {
			int numArgs = commandSplit.Length - 1;
			args = new string[numArgs];
			Array.Copy(commandSplit, 1, args, 0, numArgs);
		}
		runCommand(commandSplit[0].ToLower(), args);
		commandHistory.Add(commandString);
	}
	
	public void runCommand(string command, string[] args) {
		CommandRegistration reg = null;
		if (!commands.TryGetValue(command, out reg)) {
			appendLogLine(string.Format("Unknown command '{0}', type 'help' for list.", command));
		} else {
			if (reg.handler == null) {
				//appendLogLine(string.Format("Unable to process command '{0}', handler was null.", command));
			} else {
				reg.handler(args);
			}
		}
	}
	
	static string[] parseArguments(string commandString)
	{
		LinkedList<char> parmChars = new LinkedList<char>(commandString.ToCharArray());
		bool inQuote = false;
		var node = parmChars.First;
		while (node != null)
		{
			var next = node.Next;
			if (node.Value == '"') {
				inQuote = !inQuote;
				parmChars.Remove(node);
			}
			if (!inQuote && node.Value == ' ') {
				node.Value = '\n';
			}
			node = next;
		}
		char[] parmCharsArr = new char[parmChars.Count];
		parmChars.CopyTo(parmCharsArr, 0);
		return (new string(parmCharsArr)).Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
	}

	#region Command handlers
	//Implement new commands in this region of the file.

	/// <summary>
	/// A test command to demonstrate argument checking/parsing.
	/// Will repeat the given word a specified number of times.
	/// </summary>
	void babble(string[] args) {
		if (args.Length < 2) {
			appendLogLine("Expected 2 arguments.");
			return;
		}
		string text = args[0];
		if (string.IsNullOrEmpty(text)) {
			appendLogLine("Expected arg1 to be text.");
		} else {
			int repeat = 0;
			if (!Int32.TryParse(args[1], out repeat)) {
				appendLogLine("Expected an integer for arg2.");
			} else {
				for(int i = 0; i < repeat; ++i) {
					appendLogLine(string.Format("{0} {1}", text, i));
				}
			}
		}
	}

	void echo(string[] args) {
		StringBuilder sb = new StringBuilder();
		if(args.Length > 0){
		foreach (string arg in args)
		{
			sb.AppendFormat("{0} ", arg);
		}
		sb.Remove(sb.Length - 1, 1);
			appendLogLine(sb.ToString());
		}
	}

	void help(string[] args) {
		foreach(CommandRegistration reg in commands.Values) {
			appendLogLine(string.Format("{0}: {1}", reg.command, reg.help));
		}
	}
	
	void hide(string[] args) {
		if (visibilityChanged != null) {
			visibilityChanged(false);
		}
	}
	
	void repeatCommand(string[] args) {
		for (int cmdIdx = commandHistory.Count - 1; cmdIdx >= 0; --cmdIdx) {
			string cmd = commandHistory[cmdIdx];
			if (String.Equals(repeatCmdName, cmd)) {
				continue;
			}
			runCommandString(cmd,false);
			break;
		}
	}
	
	void reload(string[] args) {
		//Application.LoadLevel(Application.loadedLevel);
		SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);   
	}
	
	void resetPrefs(string[] args) {
		PlayerPrefs.DeleteAll();
		PlayerPrefs.Save();
	}

	#endregion
}
//}