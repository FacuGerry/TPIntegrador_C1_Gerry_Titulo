using UnityEngine;
using UnityEngine.SceneManagement;

public class OnEnemyTriggerSwitchToFightScene : MonoBehaviour
{
    public string sceneToLoad;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
