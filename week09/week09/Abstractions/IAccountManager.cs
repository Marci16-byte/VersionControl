using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week09.Entities;
using System.ComponentModel;

namespace week09.Abstractions
{
    public interface IAccountManager
    {
        BindingList<Account> Accounts { get; }

        Account CreateAccount(Account account);
    }
}
