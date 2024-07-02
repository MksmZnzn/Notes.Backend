using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQuery: IRequest<NoteListVm>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
