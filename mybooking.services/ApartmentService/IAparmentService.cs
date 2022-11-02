using mybooking.domain.Entities;
using mybooking.repository.Contract;
using mybooking.services.ApartmentService.Dto;
using X.PagedList;

namespace mybooking.services.ApartmentService;

public interface IAparmentService
{
    Task<IPagedList<ViewApartmentDto>> GetAll(PagedRequest paging);

    Task<IPagedList<ViewApartmentDto>> FindAvailable(PagedRequest paging);

    Task<ViewApartmentDto> FindById(long id);
    
    Task<ViewApartmentDto> Create(CreateApartmentDto request);
}