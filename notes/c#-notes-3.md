# Static

Uma variável estática é uma variável compartilhada e única, independente da instância da classe.

# Exceptions

Exceptions são erros que podem ser tratados, delegados e criados durante o programa.

```c#
public class AccountNotCreatedException : SystemException {

  public AccountNotCreatedException () {
  }

  public AccountNotCreatedException (string username) {
    base($"the username: {username} is not registered");
  }
}
```

## throw 

cria/arremessa uma excessão pelo programa

```c#
if(!banco.foundAccount(account)){
  throw new AccountNotCreatedException(account.username);
}
```

## try ... catch

```c#
try {
  Console.WriteLine(9/0);
} catch (DivisionByZeroException excep){

}
```