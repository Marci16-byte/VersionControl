﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using week09.Abstractions;
using week09.Entities;

namespace week09.Services
{
    public class AccountManager : IAccountManager
    {
        public BindingList<Account> Accounts { get; } = new BindingList<Account>();

        public Account CreateAccount(Account account)
        {
            var oldAccount = (from a in Accounts
                              where a.Email.Equals(account.Email)
                              select a).FirstOrDefault();

            if (oldAccount != null)
                throw new ApplicationException(
                    "Már létezik felhasználó ilyen e-mail címmel!");

            Accounts.Add(account);

            return account;
        }
    }
}
