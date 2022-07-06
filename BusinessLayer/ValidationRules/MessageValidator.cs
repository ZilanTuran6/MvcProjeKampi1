﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            {
                RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz");
                RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Adını boş geçemezsiniz.");
                RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz");
                RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Geçerli bir e - posta adresi gerekli.");
                RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
                RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla karakter girişi yapmayınız.");
            }
        }
    }
}