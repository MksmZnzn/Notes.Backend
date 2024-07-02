using System;
using FluentValidation;

namespace Notes.Application.Notes.Commands.DeleteCommand
{
    public class DeleteNoteValidator : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteValidator() 
        {
            RuleFor(deleteNoteCommand => deleteNoteCommand.Id).NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand => deleteNoteCommand.UserId).NotEqual(Guid.Empty);
            
        }
    }
}
