using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roaming.Application.Roaming.Countparties.Commands.CreateCounterparty;
using Roaming.Application.Roaming.Countparties.Commands.DeleteCounterparty;
using Roaming.Application.Roaming.Countparties.Commands.UpdateCounterparty;
using Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyDetails;
using Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyList;
using Roaming.WebApi.Models;
using System;
using System.Threading.Tasks;

namespace Roaming.WebApi.Controllers
{
    public class CounterpartyController : BaseController
    {
        private readonly IMapper _mapper;

        public CounterpartyController(IMapper mapper) => _mapper = mapper;


        /// <summary>
        /// Gets the list of counterparties
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET /counterparty
        /// </remarks>
        /// <returns>Return CounterpartyListVm</returns>
        /// <response code="200">Success</response>
        /// <responce code="401">If the user is unauthorized</responce>
        [HttpGet]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<CounterpartyListVm>> GetAll()
        {
            var query = new GetCounterpartyListQuery
            {
                UserId = UserId,
            };

            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        /// <summary>
        /// Get the document by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET /counterparty/C90B000D-DFD6-4584-BC0B-92BAC02E432F
        /// </remarks>
        /// <param name="id">Document id (guid)</param>
        /// <returns>Returns DocumentDetailsVm</returns>
        /// <response code="200">Success</response>
        /// <responce code="401">If the user is unauthorized</responce>
        [HttpGet("{id}")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<CounterpartyDetailsVm>> Get(Guid id)
        {
            var query = new GetCounterpartyDetailsQuery
            {
                Id = id,
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        /// <summary>
        /// Creates the document
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// POST /counterparty
        /// {
        ///     senderId: "88DEB432-062F-43DE-8DCD-8B6EF79073D3",
        ///     recipientId: "88DEB432-062F-43DE-8DCD-8B6EF79073D3"
        /// }
        /// </remarks>
        /// <param name="createDocumentDto">CreateDocumentDto object</param>
        /// <returns>Returns id (guid)</returns>
        /// <response code="200">Success</response>
        /// <responce code="401">If the user is unauthorized</responce>
        [HttpPost]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCounterpartyDto createNoteDto)
        {
            var command = _mapper.Map<CreateCounterpartyCommand>(createNoteDto);
            var noteId = await Mediator.Send(command);
            return Created("https://localhost:44343/api/document", noteId);
        }

        /// <summary>
        /// Update the document
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// PUT /counterparty
        /// {
        ///     id: "document id"
        ///     type: "update type title"
        /// }
        /// </remarks>
        /// <param name="updateDocumentDto">updateDocumentDto object</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="200">Success</response>
        /// <responce code="401">If the user is unauthorized</responce>
        [HttpPut]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromBody] UpdateCounterpartyDto updateNoteDto)
        {
            var command = _mapper.Map<UpdateCounterpartyCommand>(updateNoteDto);
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes the counterparty by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// DELETE /counterparty/88DEB432-062F-43DE-8DCD-8B6EF79073D3
        /// </remarks>
        /// <param name="id">Id of the counterparty (guid)</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="401">If the user is unauthorized</response>
        [HttpDelete("{id}")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteCounterpartyCommand
            {
                Id = id,
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}