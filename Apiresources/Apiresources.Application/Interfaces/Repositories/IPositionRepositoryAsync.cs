﻿namespace Apiresources.Application.Interfaces.Repositories
{
    /// <summary>
    /// Repository interface for Position entity with asynchronous methods.
    /// </summary>
    /// <param name="positionNumber">Position number to check for uniqueness.</param>
    /// <returns>
    /// Task indicating whether the position number is unique.
    /// </returns>
    /// <param name="rowCount">Number of rows to seed.</param>
    /// <returns>
    /// Task indicating the completion of seeding.
    /// </returns>
    /// <param name="requestParameters">Parameters for the query.</param>
    /// <param name="data">Data to be returned.</param>
    /// <param name="recordsCount">Number of records.</param>
    /// <returns>
    /// Task containing the paged response.
    /// </returns>    
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount, IEnumerable<Department> departments, IEnumerable<SalaryRange> salaryRanges);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPositionReponseAsync(GetPositionsQuery requestParameters);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> PagedPositionReponseAsync(PagedPositionsQuery requestParameters);
    }
}