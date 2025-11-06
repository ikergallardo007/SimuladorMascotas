using UnityEngine;

// Representa la mascota alienígena principal.
public class AlienPet : MonoBehaviour
{
    // Private Attributes
    private string petName; // Nombre de la mascota
    private float happiness; // Nivel de felicidad

    // Public Properties
    public list<CosmicSkill> learnedSkills; // Habilidades aprendidas

    public void Feed()
    {
        happiness += 1.5f;
    }

    public void MakeSound(AlienSound sound)
    {
        print(petName + " make a sound: " + sound.soundName);
    }

    public void LearnSkill(CosmicSkill skill)
    {
        print("Añadir habilidad a la lista");
    }
}
