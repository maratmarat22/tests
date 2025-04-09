using System.Text;

namespace Tests.Design.Patterns.Creational.Builder;

public class Castle
{
    public bool Motte { get; set; }
    public bool Keep { get; set; }
    public bool Walls { get; set; }
    public bool Towers { get; set; }
    public bool Moat { get; set; }
    public bool Barbican { get; set; }
    public bool Forge { get; set; }
    public bool Stable { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        
        if (Motte) builder.AppendLine("Motte");
        if (Keep) builder.AppendLine("Keep");
        if (Walls) builder.AppendLine("Walls");
        if (Towers) builder.AppendLine("Towers");
        if (Moat) builder.AppendLine("Moat");
        if (Barbican) builder.AppendLine("Barbican");
        if (Forge) builder.AppendLine("Forge");
        if (Stable) builder.AppendLine("Stable");
        
        return builder.ToString();
    }
}