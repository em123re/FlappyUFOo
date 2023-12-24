using UnityEngine;

public class Player : MonoBehaviour
{
    // Zipla
    public float ziplamaKuvveti = 5f;
    public float dusmeHizi = -15f;
    private Vector3 yol;

    public AudioClip ziplamaJump;
    public AudioClip gameOverSound;
    public AudioClip skorSound;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            yol = Vector3.up * ziplamaKuvveti;
            SoundManager.instance.SesOynat(ziplamaJump);
        }
        yol.y += dusmeHizi * Time.deltaTime;
        transform.position += yol * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Engel")
        {
            GameManager.instance.GameOver();
            SoundManager.instance.SesOynat(gameOverSound);
        }
        if(other.gameObject.tag == "Skor")
        {
            GameManager.instance.ScoreUp();
            SoundManager.instance.SesOynat(skorSound);
        }
    }
}