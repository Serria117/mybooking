using Microsoft.AspNetCore.Mvc;
using mybooking.services.ApartmentService;
using mybooking.services.ApartmentService.Dto;
using X.PagedList;

namespace mybooking.Controllers;
[Route("/api/apartment")]
public class ApartmentController : ControllerBase
{
    private readonly IAparmentService _aparment;

    public ApartmentController(IAparmentService aparment)
    {
        _aparment = aparment;
    }

    [HttpGet("/get-all")]
    public async Task<IPagedList<ViewApartmentDto>> GetAll(PagedRequest paging)
    {
        return await _aparment.GetAll(paging);
    }
}