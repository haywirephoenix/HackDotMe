using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;

public class Hacker : HackerBehavior {
	ConsoleController console = new ConsoleController();
	
	
		
	
	[Header("LifeCoin")][Space]
	public float LifeCoin = 100f;
	
[Header("Status")][Space]
	public bool Online;
	public bool Scanning;
	public bool Breached;
	
	
[Header("Hardware")][Space]
	public int RAMLvl = 1;
	public int CPULvl = 1;
	public int FirewallLvl = 1;
	
[Header("System Load")][Space]
	public float Firewall = 0f;
	public float CPU = 0f;
	public float RAM = 0f;
			

	// Use this for initialization
	/*private void Update()
	{
		
		
		
		
	}*/
	
	private void Start(){
		
		if (networkObject.IsServer)
		{
			//Debug.Log("server");
			if (console != null) {
				//Debug.Log("Found console");
				console.appendLogLine("Server Running");

				
			}
			
			
		}
		
		
		//Booleans
		Online = networkObject.Online;
		Scanning = networkObject.Scanning;
		Breached = networkObject.Breached;	
			
		//Lifecoin
		LifeCoin = networkObject.LifeCoin;
			
		//System Load
		Firewall = networkObject.Firewall;
		CPU = networkObject.CPU;
		RAM = networkObject.RAM;
			
		//Hardware
		RAMLvl = networkObject.RAMLvl;
		CPULvl = networkObject.CPULvl;
		FirewallLvl = networkObject.FirewallLvl;
		
		
		
	}
	
	// Update is called once per frame
	
	
}
