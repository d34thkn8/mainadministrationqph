using FluentValidation;
using QPH_MAIN.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace QPH_MAIN.Infrastructure.Validators
{
    public class ChannelsValidator : AbstractValidator<ChannelDto>
    {
        public ChannelsValidator()
        {
            RuleFor(channel => channel.Enlace).Custom((value, context) =>
            {
                if (string.IsNullOrEmpty(value))
                {
                    context.AddFailure("Enlace vacio");
                }
            });
            RuleFor(channel => channel.Enlace).Custom((value, context) =>
            {
                if(!(Uri.TryCreate(value, UriKind.Absolute, out _)))
                {
                    context.AddFailure("Enlace no es una URL valida");
                }
            });
            
            
           
        }
    }
}
