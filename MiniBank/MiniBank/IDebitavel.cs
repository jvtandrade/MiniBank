using System;

namespace Minibank;

public interface IDebitavel
{
    bool Sacar(decimal valor);
}