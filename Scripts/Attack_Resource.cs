using Godot;

public partial class Attack_Resource : Resource
{
    [Export]
    public string Name {get;set;}
    [Export]
    public string Description {get;set;}
    [Export]
    public AttackType AttackType {get;set;}
    [Export]
    public AttackAttribute AttackAttribute{get;set;}
    [Export]
    public int Power {get;set;}
    [Export]
    public int MaxUses {get;set;}
    [Export]
    public Element Element {get;set;}
    [Export]
    public Animation AttackAnimation {get;set;}
}
