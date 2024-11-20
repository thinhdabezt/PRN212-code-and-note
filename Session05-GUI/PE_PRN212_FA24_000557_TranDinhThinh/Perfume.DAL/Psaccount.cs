﻿using System;
using System.Collections.Generic;

namespace Perfume.DAL;

public partial class Psaccount
{
    public int PsaccountId { get; set; }

    public string Password { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string PsaccountNote { get; set; } = null!;

    public int? Role { get; set; }
}
