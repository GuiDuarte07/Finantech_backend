﻿using ControleCerto.DTOs.Events;
using ControleCerto.Services.Interfaces;
using MassTransit;

namespace ControleCerto.Bus
{
    public class ConsoleMessageEventConsumer: IConsumer<ConsoleMessageEvent>
    {
        private readonly IEmailService _emailService;

        public ConsoleMessageEventConsumer(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task Consume(ConsumeContext<ConsoleMessageEvent> context)
        {
            Console.WriteLine("Enviando mensagem...");
            await Task.Delay(500);

            Console.WriteLine(context.Message.Message);

            Console.WriteLine("mensagem enviado!");
        }
    }
}
