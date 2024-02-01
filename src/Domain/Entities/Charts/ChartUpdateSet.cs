using Domain.Enums;

namespace Domain.Entities.Charts;

class ChartUpdateSet
{
    private ChartType _chartType;

    public ChartUpdateSet(ChartType chartType)
    {
        this._chartType = chartType;
    }
}