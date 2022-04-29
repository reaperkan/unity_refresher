using UnityEngine;
using UnityEditor;
using System;
public class CustomSceneWindow : EditorWindow
{
    private enum Mode {
        View = 0,
        Paint = 1,
        Erase = 2
    }

    private Mode currentMode = Mode.View;

    [MenuItem ("Window/Custom Scene Window")]
    static void Init(){
        CustomSceneWindow window = (CustomSceneWindow)EditorWindow.GetWindow<CustomSceneWindow>();
        window.Close();
    }

    private void OnEnable() {
        SceneView.duringSceneGui += SceneViewGUI;
        if(SceneView.lastActiveSceneView ) SceneView.lastActiveSceneView.Repaint();
    }

    void SceneViewGUI(SceneView sceneView){
        Handles.BeginGUI();
        var toolBarRect = new Rect((SceneView.lastActiveSceneView.camera.pixelRect.width/6),10,(SceneView.lastActiveSceneView.camera.pixelRect.width*4/6),SceneView.lastActiveSceneView.camera.pixelRect.height/5);
        GUILayout.BeginArea(toolBarRect);
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        currentMode = (Mode) GUILayout.Toolbar((int)currentMode, Enum.GetNames(typeof(Mode)), GUILayout.Height(toolBarRect.height));
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
        Handles.EndGUI();
    }
}
