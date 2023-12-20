using UnityEngine;

public class VolumeController : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("volume")) AudioListener.volume = 1;
    }
    private void Update()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }

}
