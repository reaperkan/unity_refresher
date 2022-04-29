using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NativeEvents : MonoBehaviour
{
    // Delegates are function containers
    // Delegeats can also be used to pass a function into a function
    delegate void Attack();
    Attack attack;

    void Start(){
        // We can change this function later as well
        attack = MyAttack;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            // if(attack != null){
            //     attack();
            // }
            // Better null check
            attack?.Invoke();
        }
        if(Input.GetMouseButton(0)){
            attack = MyAttack;
        }

        if(Input.GetMouseButton(1)){
            attack = MyAwesomeAttack;
        }
    }

    void MyAttack(){
        Debug.Log("attacking");
    }

    void MyAwesomeAttack(){
        Debug.Log("Awesome Attacking");
    }
}
