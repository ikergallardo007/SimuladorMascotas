using UnityEngine;

// Cosmic skills that can be learned by the pet.
public class CosmicSkill : MonoBehaviour
{
    // Private Attributes
    private int _powerLevel; 

    // Public Properties
    public string skillName; // Nombre de la habilidad

    // Methods
    private void Start()
    {
        _powerLevel = UnityEngine.Random.Range(10, 0); // Power level of the skill selected randomly between 1 and 10.
    }

    public void Activate() // Public method to activate the skill.
    {
        print("Skill activated: " + skillName);
    }
}
