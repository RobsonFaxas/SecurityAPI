﻿using MediatR;
using RRF.Application.Models;
using RRF.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRF.Application.UserProfiles.Commands
{
    public class DeleteUserCommand : IRequest<OperationResult<UserProfile>>
    {
        public Guid UserProfileId { get; set; }
    }
}
