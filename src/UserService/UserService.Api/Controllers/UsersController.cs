using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserService.Api.ViewModels;
using UserService.Application.Queries.UseCases.Users.Handlers;

namespace UserService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(nameof(SearchUsers))]
    public async Task<IEnumerable<UserVM>> SearchUsers([FromQuery] string searchTerm)
    {
        return await _mediator.Send(new SearchUsers.Request(searchTerm));
    }
}
