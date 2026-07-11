
using smart_smca.Enums;

namespace smart_smca.Models;

public class MachineUnit
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MachineModelId { get; set; }
    public string SerialNumber { get; set; } = string.Empty;
    public DateOnly InstalledDate { get; set; }
    public string Location { get; set; } = string.Empty;
    public MachineStatus Status { get; set; } = MachineStatus.Active;
    public MachineModel MachineModel { get; set; } = null!;
}