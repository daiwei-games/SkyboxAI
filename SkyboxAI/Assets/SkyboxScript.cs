using UnityEngine;

public class SkyboxScript : MonoBehaviour
{
    public Material skyboxMaterial; // 這裡你可以拖曳你的材質球到Inspector面板中
    public Texture[] panoramaTextures; // 這裡你可以拖曳你的全景圖紋理陣列到Inspector面板中

    void Start()
    {
        // 初始時設置材質球的主紋理
        skyboxMaterial.mainTexture = panoramaTextures[0]; // 默認使用陣列中的第一張全景圖

        // 如果你想在遊戲運行時動態更換紋理，可以呼叫下面的方法
        // ChangePanoramaTexture(1); // 傳入陣列中的索引來更換紋理
    }

    // 你可以在腳本的任何地方呼叫這個方法來更改材質球的主紋理
    public void ChangePanoramaTexture(int textureIndex)
    {
        if (textureIndex >= 0 && textureIndex < panoramaTextures.Length)
        {
            skyboxMaterial.mainTexture = panoramaTextures[textureIndex];
        }
        else
        {
            Debug.LogError("無效的紋理索引！");
        }
    }
}
