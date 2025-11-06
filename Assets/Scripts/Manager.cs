using UnityEngine;

// Esta es la clase que se introduce en el objeto y desde el cual se crean las instancias y se llaman los diferentes métodos.
public class Manager : MonoBehaviour
{
    // Public Properties
    public bool feedPet = false;
    public bool learnSkill = false;
    public bool makeSound = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AlienPet pet = new AlienPet("Zorgo");
        CosmicSkill laserEyes = new CosmicSkill("Laser Eyes", 5);
        AlienSound squeak = new AlienSound("Space Squak", 2.5f);
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
            pet.Learn(laserEyes);
        }

        if (makeSound)
        {
            makeSound = false;
            pet.MakeSound(squeak);
        }
    }
}
