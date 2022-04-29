using UnityEngine;

// Transforms hold the majority of data about an object in unity
// including its parents, children , position, rotation and scale
public class TransformExample : MonoBehaviour
{
    void Translate(){
        // will move the object 1 unit forward
        transform.Translate(Vector3.forward);
    }

    void Rotate(){
        // Will rotate 45 degress in y axis
        transform.Rotate(0,45,0);
        // will rotate at the point along the axis by the angle provided
        // transform.RotateAround(point, axis, angle);
        

        // will rotate the forward vector towards the other object
        // transform.LookAt(enemyTransform);
    }

    void SetParent(){
       // transform.SetParent(otherGameobject)

        // check whether it is a child of the other transform or not
       // transform.IsChildOf(otherGameObject);
    }

    void Children(){
        // Find the child object named obj
        transform.Find("obj");
        
        // Can also search for children further down the hierarchy 
        transform.Find("other/obj");

        // Can also fetch a child using its index
        transform.GetChild(3);

        // Fetch the number of children
        int count = transform.childCount;
        
        // Changing the order of the children
        transform.SetSiblingIndex(count - 1);
        transform.SetAsFirstSibling();
        transform.SetAsLastSibling();

        // Release all children of a transform
        foreach(Transform child in transform){
            child.parent = null;
        }

        transform.DetachChildren();
    }
}
