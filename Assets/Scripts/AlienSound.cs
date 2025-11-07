using UnityEngine;

// Alien sounds that can be emitted by the pet.
public class AlienSound : MonoBehaviour
{
    // Private Attributes
    private float _pitch; 

    // Public Properties
    public string soundName; // Name of the sound.

    // Methods
    private void Start()
    {
        _pitch = UnityEngine.Random.Range(0.0f, 10.0f); // Frequency of the sound in the range of 0 and 10 Hz.
    }
    public void PlaySound() // Public method to play the sound.
    {
        print(soundName);
    }
}
