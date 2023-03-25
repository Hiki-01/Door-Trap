using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int LevelNumber=0;
    private int Health = 400;
    public int HP;
    [SerializeField] private Animator Die;
    [SerializeField] AudioSource Play;
    private void Start()
    {
        HP = Health;
    }
    //Player Health & Damage
    public void damage(int Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            Debug.Log("oh Noo");
            Die.SetTrigger("death");

        }
        else if (HP<400) 
        {
            Play.Play();
        }
    }
    public void Resetart()
    {
        SceneManager.LoadScene(LevelNumber);
    }

}
