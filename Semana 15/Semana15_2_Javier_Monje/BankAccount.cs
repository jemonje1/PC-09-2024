﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.AccessControl;
using Data;

namespace Classes;

public class BankAccount
{
    public string Type { get; set; }
    public string Number { get; }
    public string Owner { get; set; }
    #region BalanceComputation
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
    #endregion
    private static string tipo = "";
    public static void TipoCuenta(BankAccount account, string tipo)
    {
        account.Type = tipo;
    }
    private static int s_accountNumberSeed = 0;
    public static void SAccountNumberSeed(int numero)
    {
        s_accountNumberSeed = numero;
    }
    #region Constructor
    public BankAccount(string name, decimal initialBalance)
    {
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;

        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    }
    #endregion

    #region TransactionDeclaration
    private List<Transaction> _allTransactions = new List<Transaction>();
    #endregion

    #region DepositAndWithdrawal
    //errores modíficados, para que el valor sí pueda ser de 0
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }
    #endregion

    #region History
    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }
    #endregion
}