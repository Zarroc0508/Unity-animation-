using UnityEngine;

public class SpriteSequenceController : MonoBehaviour
{
    public GameObject GokuLyingDownSprite;
    public GameObject GokuGettingUpSprite;
    public GameObject GokuPoweringUpSprite;
    public GameObject GokuFinalSprite;

    private float lyingDownTimer = 8f;
    private float gettingUpTimer = 15f;
    private float poweringUpTimer = 20f;

    void Start()
    {
        // Deactivate all sprites at the start
        DeactivateAllSprites();

        // Activate the first sprite
        GokuLyingDownSprite.SetActive(true);
    }

    void DeactivateAllSprites()
    {
        GokuFinalSprite.SetActive(false);
        GokuGettingUpSprite.SetActive(false);
        GokuPoweringUpSprite.SetActive(false);
    }

    void Update()
    {
        // Decrement timers
        lyingDownTimer -= Time.deltaTime;
        gettingUpTimer -= Time.deltaTime;
        poweringUpTimer -= Time.deltaTime;

        // Check if it's time to transition to the next stage
        if (lyingDownTimer <= 0f)
        {
            GokuLyingDownSprite.SetActive(false);
            GokuPoweringUpSprite.SetActive(false);
            GokuFinalSprite.SetActive(false);
            GokuGettingUpSprite.SetActive(true);
        }
        if (gettingUpTimer <= 0f)
        {
            GokuGettingUpSprite.SetActive(false);
            GokuLyingDownSprite.SetActive(false);
            GokuFinalSprite.SetActive(false);
            GokuPoweringUpSprite.SetActive(true);
        }
        if (poweringUpTimer <= 0f)
        {
            GokuPoweringUpSprite.SetActive(false);
            GokuGettingUpSprite.SetActive(false);
            GokuLyingDownSprite.SetActive(false);
            GokuFinalSprite.SetActive(true);
        }
    }
}