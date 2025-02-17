using UnityEngine;

public class Boss
{
    private string name;
    private string ultimateSkillName;
    private float hp;
    public Boss(string name, string ultimateSkillName, float hp)
    {
        this.name = name;
        this.ultimateSkillName = ultimateSkillName;
        this.hp = hp;
    }

    public void Info()
    {
        Debug.Log($"Name: {name}\nUltimate Skill Name: {ultimateSkillName}\nHP: {hp}");
    }
}