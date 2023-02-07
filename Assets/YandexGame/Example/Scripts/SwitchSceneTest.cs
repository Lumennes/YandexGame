using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AddressableAssets;

namespace YG.Example
{
    public class SwitchSceneTest : MonoBehaviour
    {
        public void SwitchScene(string sceneID)
        {
            // SceneManager.LoadScene(sceneID);
            Addressables.LoadSceneAsync(sceneID);
        }
    }
}