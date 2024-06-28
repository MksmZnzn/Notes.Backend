using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    internal class GetNoteListQuery: IRequest<NoteListVm>
    {
        public Guid UserId { get; set; }
    }
}
