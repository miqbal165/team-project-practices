using System;

namespace smart_smca.Models;

public class MachineModel
{
    public Guid Id { get; set; }
    public string ModelName { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public int CalibrationIntervalDays { get; set; }
    public decimal CalibrationUsageThreshold { get; set; }
    public int MaintenanceIntervalsDays { get; set; }
    public decimal MaintenanceUsageThreshold { get; set; }
    public int GracePeriodDays { get; set; }
    public string ToleranceSpec { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}