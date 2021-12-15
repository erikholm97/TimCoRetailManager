﻿using System;

namespace TRMDesktopUI.Library.Models
{
    public interface ILoggedInUserModel
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        DateTime CreatedDate { get; set; }
        string Token { get; set; }
    }
}