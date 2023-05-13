using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roaming.Application.Roaming.Documents.Commands.CreateDocument;
using Roaming.Application.Roaming.Documents.Commands.DeleteDocument;
using Roaming.Application.Roaming.Documents.Commands.UpdateDocument;
using Roaming.Application.Roaming.Documents.Queries.GetDocumentDetails;
using Roaming.Application.Roaming.Documents.Queries.GetDocumentList;
using Roaming.WebApi.Models;
using System;
using System.Threading.Tasks;

namespace Roaming.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DocumentController : BaseController
    {
        private readonly IMapper _mapper;

        public DocumentController(IMapper mapper) => _mapper = mapper;

        /// <summary>
        /// Gets the list of documents
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET /document
        /// </remarks>
        /// <returns>Return DocumentListVm</returns>
        /// <response code="200">Success</response>
        /// <responce code="401">If the user is unauthorized</responce>
        [HttpGet]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<DocumentListVm>> GetAll()
        {
            var query = new GetDocumentListQuery
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
        /// GET /document/C90B000D-DFD6-4584-BC0B-92BAC02E432F
        /// </remarks>
        /// <param name="id">Document id (guid)</param>
        /// <returns>Returns DocumentDetailsVm</returns>
        /// <response code="200">Success</response>
        /// <responce code="401">If the user is unauthorized</responce>
        [HttpGet("{id}")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<DocumentDetailsVm>> Get(Guid id)
        {
            var query = new GetDocumentDetailsQuery
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
        /// POST /document
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
        public async Task<ActionResult<Guid>> Create([FromBody] CreateDocumentDto createNoteDto)
        {
            var command = _mapper.Map<CreateDocumentCommand>(createNoteDto);
            var noteId = await Mediator.Send(command);
            return Created("https://localhost:44343/api/document", noteId);
        }

        /// <summary>
        /// Update the document
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// PUT /document
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
        public async Task<IActionResult> Update([FromBody] UpdateDocumentDto updateNoteDto)
        {
            var command = _mapper.Map<UpdateDocumentCommand>(updateNoteDto);
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes the document by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// DELETE /document/88DEB432-062F-43DE-8DCD-8B6EF79073D3
        /// </remarks>
        /// <param name="id">Id of the document (guid)</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="401">If the user is unauthorized</response>
        [HttpDelete("{id}")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteDocumentCommand
            {
                Id = id,
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
