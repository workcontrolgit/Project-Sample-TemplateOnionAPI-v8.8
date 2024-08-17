﻿namespace Apiresources.Infrastructure.Shared.Services
{
    public class MockService : IMockService
    {

        public List<Position> GetPositions(int rowCount, IEnumerable<Department> departments, IEnumerable<SalaryRange> salaryRanges)
        {
            var faker = new PositionInsertBogusConfig(departments, salaryRanges);
            return faker.Generate(rowCount);
        }

        public List<Employee> GetEmployees(int rowCount)
        {
            var faker = new EmployeeBogusConfig();
            return faker.Generate(rowCount);
        }

        public List<Position> SeedPositions(int rowCount)
        {
            var faker = new PositionSeedBogusConfig();
            return faker.Generate(rowCount);
        }
    }
}