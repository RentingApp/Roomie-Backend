﻿using Renting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renting.Services;

public class AccountService : IAccountService
{
    public string UniqueForEmail(string name, IList<string> emailsList)
    {
        var emails = emailsList;

        for(int i = 0; i < emails.Count; i++)
        {
            var email = emails[i];
            if (email.Contains(name))
            {
                return email + "exists";
            }

            return "ok";
        }
        return "";
    }

    public string UniqueForUsername(string name, IList<string> usernamesList)
    {
        var usernames = usernamesList;

        for (int i = 0; i < usernames.Count; i++)
        {
            var username = usernames[i];
            if (username.Contains(name))
            {
                return username + "exists";
            }

            return "ok";
        }
        return "";
    }
}
