using UnityEditor;
using UnityEngine;


// If we use this class we can't edit from Editor
// As when we hit apply this function will run again
public class TexturePostProcessor : AssetPostprocessor
{
    void OnPostprocessTexture(Texture2D texture){
        TextureImporter importer = assetImporter as TextureImporter;
        importer.anisoLevel = 1;
        importer.filterMode = FilterMode.Bilinear;
        importer.mipmapEnabled = true;
        importer.npotScale = TextureImporterNPOTScale.ToLarger;
        importer.textureType = TextureImporterType.Sprite;
    }
}
