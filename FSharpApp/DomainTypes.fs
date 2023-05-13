namespace FSharpApp

open System

module DomainTypes =

    type SuccessfulWithdrawal =
        { Amount : decimal
          Balance : decimal }
        
    type FailedWithdrawal =
        { Amount : decimal
          Balance : decimal
          IsOverdraft : bool }
        
    type WithdrawalResult =
        | Success of SuccessfulWithdrawal
        | InsufficientFunds of FailedWithdrawal
        | CardExpired of DateTime
        | UndisclosedFailure