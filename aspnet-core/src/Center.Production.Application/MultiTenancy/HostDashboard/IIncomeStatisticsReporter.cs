using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Center.Production.MultiTenancy.HostDashboard.Dto;

namespace Center.Production.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}