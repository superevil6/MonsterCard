using Godot;
using System;

public partial class Monster_Resource : Resource
{
    [Export]
    public string Name {get;set;}
    [Export]
    public string Description {get;set;}
    [Export]
    public Rarity Rarity {get;set;}
    [Export]
    public Element PrimaryElement {get;set;}
    [Export]
    public Element SecondaryElement {get;set;}
    [Export]
    public ImageTexture Image {get;set;}
    [Export]
    public int Health {get;set;}
    [Export]
    public int Strength {get;set;}
    [Export]
    public int Intelligence {get;set;}
    [Export]
    public int Spirit {get;set;}
    [Export]
    public int Vigor {get;set;}
    [Export]
    public Attack_Resource AttackOne {get;set;}
    [Export]
    public Attack_Resource AttackTwo {get;set;}
    [Export]
    public Attack_Resource AttackThree {get;set;}
    [Export]
    public Attack_Resource AttackFour {get;set;}
    [Export]
    public Passive_Resource Passive {get;set;}
}
