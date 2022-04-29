using System;
using UnityEngine;
public class PlayerModel{
    public delegate void PositionEvent(Vector3 position);
    public event PositionEvent onPositionChanged;

    private Vector3 _position;

    public Vector3 position{
        get{
            return _position;
        }set{
            if (_position != value){
                _position = value;
                if(onPositionChanged != null){
                    onPositionChanged(value);
                }
            }
        }
    }
}