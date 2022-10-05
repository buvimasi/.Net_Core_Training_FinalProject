using FinalProjectAPI.Data;
using FinalProjectAPI.Entities;
using FinalProjectAPI.IServices;
using FinalProjectAPI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectAPI.Services
{
    public class SoftLockService : ISoftLockService
    {
        private readonly EmployeeDbContext _dbContext;

        public SoftLockService(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string AddSoftLock(SoftLockDto softLockDto)
        {
            if (softLockDto != null)
            {
                _dbContext.Add(new SoftLock
                {
                    EmployeeId = softLockDto.EmployeeId,
                    Manager = softLockDto.Manager,
                    ManagerStatus = softLockDto.ManagerStatus,
                    RequestDate = softLockDto.RequestDate,
                    RequestMessage = softLockDto.RequestMessage,
                });
                _dbContext.SaveChanges();
                return "SoftLock Added successfully";

            }
            else
            {
                return "No Data found";
            }
        }

        public Task<List<SoftLockDto>> GetSoftLocks()
        {
            var softlock =  _dbContext.SoftLocks.Include(s=>s.Employees).Where(s => s.ManagerStatus == "awaiting_confirmation")
                .Select(s => new SoftLockDto
                {
                    LockId = s.LockId,
                    EmployeeName = s.Employees.Name,
                    EmployeeId = s.EmployeeId,
                    Manager = s.Manager,
                    ManagerStatus = s.ManagerStatus,
                    RequestMessage = s.RequestMessage,
                    RequestDate = s.RequestDate,
                });

            return Task.FromResult(softlock.ToList());
                                                       
        }

        public string UpdateSoftLockStatus(int id, SoftLockDto softLockDto)
        {
            var softLock = _dbContext.SoftLocks.Include(s => s.Employees).FirstOrDefault(s => s.LockId == id);
            if (softLock != null)
            {
                if (softLockDto.ManagerStatus == "approved")
                {
                    softLock.ManagerStatus = softLockDto.ManagerStatus;
                    softLock.Employees.LockStatus = "locked";

                }
                else
                {
                    softLock.ManagerStatus = softLockDto.ManagerStatus;
                    softLock.Employees.LockStatus = "not_requested";
                }
                _dbContext.Update(softLock);
                _dbContext.SaveChanges();

                return "Softlock updated successfully";

            }
            else
            {
                return "Softlock not found";
            }
        }
    }
}
