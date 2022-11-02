﻿using RideSaver.Server.Models;

namespace EstimateAPI.Repository
{
    public interface IEstimateRepository
    {
        Task<List<Estimate>> GetRideEstimatesAsync(Location startPoint, Location endPoint, List<Guid> services, int? seats);
        Task<List<Estimate>> GetLyftEstimatesAsync(Location startPoint, Location endPoint, List<Guid> services, int? seats);
        Task<List<Estimate>> GetUberEstimatesAsync(Location startPoint, Location endPoint, List<Guid> services, int? seats);
        Task<List<Estimate>> GetRideEstimatesRefreshAsync(List<object> ids);
        Task<Estimate> GetLyftRideEstimateRefreshAsync(Estimate estimate_id);
        Task<Estimate> GetUberRideEstimateRefreshAsync(Estimate estimate_id);

    }
}