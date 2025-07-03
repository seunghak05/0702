using UnityEngine;

public class Bulletspawner : MonoBehaviour
{
    public GameObject bulletPrefab; // The bullet prefab to spawn
    public float spawnRatemin = 0.5f; // Minimum time between spawns
    public float spawnRatemax = 3f;

    private Transform target;
    private float spawnrate;
    private float timeAfterSpawn;

    private AudioSource spawnSound; // Sound to play when spawning a bullet

    public AudioClip spawnClip; // The audio clip to play when spawning a bullet
    void Start()

    {
        timeAfterSpawn = 0f;
        spawnrate = Random.Range(spawnRatemin, spawnRatemax);
        var player = FindFirstObjectByType<playercontroller>();
        if (player != null)
        {
            target = player.transform;
        }
        else
        {
            Debug.LogWarning("playercontroller 오브젝트를 찾을 수 없습니다.");
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnrate)
        {
            if (target == null)
            {
                Debug.LogWarning("target이 null입니다. 총알을 생성하지 않습니다.");
                return;
            }
            // spawnSound.PlayOneShot(spawnClip); // Play the spawn sound
            timeAfterSpawn = 0f;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target); // Make the bullet face the player
            spawnrate = Random.Range(spawnRatemin, spawnRatemax); // Reset the spawn rate
        }   
        
    }
}
