using Godot;

public partial class Passive_Resource : Resource
{
    [Export]
    public string Name {get;set;}
    [Export]
    public string Description {get;set;}
    [Export]
    public int Power {get;set;}
}
