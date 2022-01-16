using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        
        var connectedPlayer = conn.identity.GetComponent<MyNetworkPlayer>();
        
        connectedPlayer.SetDisplayColor(new Color(Random.Range(0F,1F), Random.Range(0F,1F),Random.Range(0F,1F),1F));
        
        connectedPlayer.SetDisplayName($"Player {numPlayers}");
    }
}