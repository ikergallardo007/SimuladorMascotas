using UnityEngine;

// Game mananing script.
public class Manager : MonoBehaviour
{
    // Public Properties
    public AlienPet pet;
    public CosmicSkill laserEyeSkill;
    public CosmicSkill flySkill;
    public AlienSound sound;
    public bool feedPet = false; // Button to feed
    public bool learnSkill = false; // Button to learn skills
    public bool makeSound = false; // Button to make a sound.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Starting the game...");
    }

    // Update is called once per frame
    void Update()
    {
        if (feedPet)
        {
            feedPet = false;
            pet.Feed();
        }

        if (learnSkill)
        {
            learnSkill = false;
            pet.LearnSkill(laserEyeSkill);
            pet.LearnSkill(flySkill);
        }

        if (makeSound)
        {
            makeSound = false;
            pet.MakeSound(sound);
        }
    }
}
