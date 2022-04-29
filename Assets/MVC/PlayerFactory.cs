using System;
using UnityEngine;
public class PlayerFactory{
    public PlayerController controller {get; private set;}
    public PlayerModel model {get; private set;}
    public PlayerView view {get; private set;}

    public void Load(){
        GameObject gameObject = new GameObject();
        gameObject.name = "PlayerObj";
        this.model = new PlayerModel();
        this.view = gameObject.AddComponent<PlayerView>();
        this.controller = new PlayerController(this.model, this.view);
    }
}