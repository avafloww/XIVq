﻿using Waitingway.Backend.Database.Models;

namespace Waitingway.Backend.Server.Client;

public class ClientQueue
{
    private uint _queuePosition;

    public uint QueuePosition
    {
        get => _queuePosition;
        set
        {
            _queuePosition = value;
            LastUpdateReceived = DateTime.UtcNow;
        }
    }

    public QueueSession DbSession { get; init; }
    public DateTime LastUpdateReceived { get; set; } = DateTime.UtcNow;
}