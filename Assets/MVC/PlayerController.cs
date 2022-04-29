using System;
using UnityEngine;

// Binds the view and controller by syncing the state
// can driver ineteraction between partners
public class PlayerController {
    public PlayerModel model {get; private set;}
    public PlayerView playerView {get; private set;}

    public PlayerController(PlayerModel model, PlayerView playerView){
        this.model = model;
        this.playerView = playerView;

        this.model.onPositionChanged += OnPositionChanged;
    }

    void OnPositionChanged(Vector3 position){
        this.playerView.SetPosition(position);
    }

    void SetPosition(Vector3 position){
        this.model.position = position;
    }
}
