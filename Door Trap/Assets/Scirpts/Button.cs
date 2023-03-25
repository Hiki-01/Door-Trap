using UnityEngine.SceneManagement;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int Scence;
    public void button() 
    {
        SceneManager.LoadScene(Scence);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
