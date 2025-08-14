using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag != "Hit")
        {
            score += 1;
            Debug.Log("You've bumped into a thing " + score + " times!");
        } 
    }
}
