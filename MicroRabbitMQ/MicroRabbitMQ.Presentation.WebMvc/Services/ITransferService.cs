using MicroRabbitMQ.Presentation.WebMvc.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbitMQ.Presentation.WebMvc.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
