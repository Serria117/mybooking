using mybooking.domain.Entities;
using mybooking.domain.Enum;
using mybooking.repository.Contract;
using mybooking.services.ApartmentService.Dto;
using X.PagedList;

namespace mybooking.services.ApartmentService;

public class ApartmentService : IAparmentService
{
    private readonly IBaseRepository<Apartment, long> apartmentRepo;

    public ApartmentService(IBaseRepository<Apartment, long> apartmentRepo)
    {
        this.apartmentRepo = apartmentRepo;
    }

    public async Task<IPagedList<ViewApartmentDto>> GetAll(PagedRequest paging)
    {
        return (await apartmentRepo.GetAll(paging.Page, paging.PageSize))
            .Select(a => new ViewApartmentDto()
            {
                Id            = a.Id,
                Description   = a.Description,
                ApartmentType = a.ApartmentType.TypeName,
                RoomClass     = a.RoomClass.ClassName,
                RoomNumber    = a.RoomNumber,
                RoomStatus    = a.RoomStatus.ToString(),
                IsBeachView   = a.IsBeachView,
                IsLakeView    = a.IsLakeView
            });
    }

    public async Task<IPagedList<ViewApartmentDto>> FindAvailable(PagedRequest paging)
    {
        return (await apartmentRepo.FindAsync(a =>
            a.RoomStatus == RoomStatus.Available, 
                paging.Page, 
                paging.PageSize))
            .Select(a => new ViewApartmentDto()
            {
                Id            = a.Id,
                Description   = a.Description,
                ApartmentType = a.ApartmentType.TypeName,
                RoomClass     = a.RoomClass.ClassName,
                RoomNumber    = a.RoomNumber,
                RoomStatus    = a.RoomStatus.ToString(),
                IsBeachView   = a.IsBeachView,
                IsLakeView    = a.IsLakeView
            });
        
    }

    public Task<ViewApartmentDto> FindById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ViewApartmentDto> Create(CreateApartmentDto request)
    {
        throw new NotImplementedException();
    }
}