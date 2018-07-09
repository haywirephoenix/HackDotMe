using UnityEngine;
using BeardedManStudios.Forge.Networking.Unity;
public class GameManager : MonoBehaviour
{

	public bool instantiated;
	
	
	
	private void Update()
	{
		
		if (NetworkManager.Instance != null && !instantiated){
			
			Debug.Log("Hacker Found!");
	
		
			var hacker = NetworkManager.Instance.InstantiateHacker();
			
			//Booleans
			hacker.networkObject.Online = true;
			hacker.networkObject.Scanning = false;
			hacker.networkObject.Breached = false;	
			
			//Lifecoin
			hacker.networkObject.LifeCoin = 100f;
			
			//System Load
			hacker.networkObject.Firewall = 0f;
			hacker.networkObject.CPU = 0f;
			hacker.networkObject.RAM = 0f;
			
			//Hardware
			hacker.networkObject.RAMLvl = 1;
			hacker.networkObject.CPULvl = 1;
			hacker.networkObject.FirewallLvl = 1;
			
			
			instantiated = true;
		}
		
		//mgr = Instantiate(networkManager).GetComponent<NetworkManager>();
		
		//mgr = GetComponent<MultiplayerMenu>().networkManager.GetComponent<NetworkManager>();
		
		//NetworkManager.Instance.InstantiateHacker(0,null,null,false);
		//mgr.InstantiateHacker(0,null,null,false);
	}
}