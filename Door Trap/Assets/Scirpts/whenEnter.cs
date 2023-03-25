using UnityEngine.SceneManagement;
using UnityEngine;

public class whenEnter : MonoBehaviour
{
    public int Scencedie;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(Scencedie);
        }
    }
}
