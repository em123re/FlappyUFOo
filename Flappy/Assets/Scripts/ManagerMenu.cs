using UnityEngine;

public class ManagerMenu : MonoBehaviour
{
    //sahneler arasi gecis
    public void StartButon()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
