﻿using ControleCerto.DTOs.Events;
using ControleCerto.Services.Interfaces;
using MassTransit;

namespace ControleCerto.Bus
{
    public class SendEmailEventConsumer: IConsumer<EmailEvent>
    {
        private readonly IEmailService _emailService;

        public SendEmailEventConsumer(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public Task Consume(ConsumeContext<EmailEvent> context)
        {
            var email = context.Message;

            _emailService.SendEmail(email.Emails, email.Subject, email.Body);

            return Task.CompletedTask;
        }
    }
}
