using UnityEngine.UI;
using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    public Text Puzzle;
    public Text Hint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Puzzle.enabled = true;
            Hint.enabled = false;
        }
    }
}
