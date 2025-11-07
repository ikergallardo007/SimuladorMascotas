using System;
using UnityEngine;

// Representation of the alien pet.
public class AlienPet : MonoBehaviour
{
    // Private Attributes
    private string _petName = "Zorgo"; // The name of the pet.
    private float _happiness; // Level of happiness of the pet.

    // Public Properties
    public CosmicSkill[] learnedSkills; // Array with the cosmic skills learned by the pet.
    
    // Methods
    private void Start()
    {
        _happiness = UnityEngine.Random.Range(0.0f, 5.0f); // Random value for the happiness.
    }

    
    public void Feed() // Method for feeding the pet.
    {
        _happiness += UnityEngine.Random.Range(0.0f, 2.0f); // Increase the happiness of the pet by a random number.
        print("The happiness of " + _petName + " is: " +  _happiness);
    }

     
    public void MakeSound(AlienSound sound) // Method for making a sound.
    {
        print(_petName + " make a sound:");
        sound.PlaySound(); // Use the method of the AlienSound class.
    }

    public void LearnSkill(CosmicSkill skill) // Method for learning skills.
    {
        bool knownSkill = false; // Local variable to know if the skill is in the learned skills array.
        if (learnedSkills.Length == 0) // If the array is empty the skill is added.
        {
            print("Skill learned " + skill.skillName);
            learnedSkills = new CosmicSkill[] { skill };
        }
        else
        {
            for (int i = 0; i < learnedSkills.Length; i++) // Look if the the skill is in the array.
            {
                if (skill == learnedSkills[i])
                {
                    knownSkill = true; 
                }
            }
            if (!knownSkill) // If the skill is not in the array it will increase the size of the array and add the skill in the las position.
            {
                print("Skill learned " + skill.skillName);
                Array.Resize(ref learnedSkills, learnedSkills.Length + 1);
                learnedSkills[learnedSkills.Length - 1] = skill;
            }
        }
    }
}
