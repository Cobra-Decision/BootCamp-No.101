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
