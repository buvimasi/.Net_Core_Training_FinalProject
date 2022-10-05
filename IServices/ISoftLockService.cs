using FinalProjectAPI.ViewModels;

namespace FinalProjectAPI.IServices
{
    public interface ISoftLockService
    {
        Task<List<SoftLockDto>> GetSoftLocks();

        string AddSoftLock(SoftLockDto softLockDto);

        string UpdateSoftLockStatus(int id, SoftLockDto softLockDto);
    }
}
