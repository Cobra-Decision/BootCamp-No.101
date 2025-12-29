using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;

namespace Ticketing.Infra.Services
{
    public class TicketMessageService : ITicketMessageService
    {
        private readonly DatabaseContext _db;
        public TicketMessageService (DatabaseContext db)
        {
            _db = db;
        }



        public async Task<TicketMessageDto> AddMessage(int ticketid, TicketMessageDto dto)
        {
            var message = new TicketMessage
            {
                Id = dto.Id,
                Message = dto.Message,
                CreatedAt = dto.CreatedAt,
                TicketId = ticketid,
                UserId = dto.UserId,
            };

            _db.TicketMessage.AddAsync(message);
            await _db.SaveChangesAsync();

            return dto;

        }
