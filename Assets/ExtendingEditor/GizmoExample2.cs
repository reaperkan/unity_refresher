using UnityEngine;
using UnityEditor;

// To Seperate out Gizmo Drawing to a separate script
public class GizmoExample2
{
    [DrawGizmo (GizmoType.Selected | GizmoType.NotInSelectionHierarchy, typeof(GizmosExample1))]
    public static void DrawGizmo(GizmosExample1 obj, GizmoType type){
        var gizmoMatrix = Gizmos.matrix;
        var gizmoColor = Gizmos.color;

        Gizmos.matrix = Matrix4x4.TRS(obj.transform.position, obj.transform.rotation, obj.transform.lossyScale);
        Gizmos.color = Color.black;
        Gizmos.DrawFrustum (Vector3.zero, obj.GetFOV(), obj.GetMaxRange(), obj.GetMinRange(), obj.GetAspect());

        Gizmos.matrix = gizmoMatrix;
        Gizmos.color = gizmoColor;

        // And check on the parameter
        if((type & GizmoType.Selected) == GizmoType.Selected){
            Handles.DrawWireDisc(obj.transform.position, Vector3.up, obj.GetDetectionRadius());
        }
    }
}
