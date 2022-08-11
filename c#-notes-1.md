# POO em C#

## Classe e Objeto

Classe - molde
Objeto - fruto desse molde

## O que compõe uma classe

jeito rudimentar:

```c#
struct Pessoa {
  string Nome;
  string telefone;
  int idade;
}
```

ideia:

```c#
public class Pessoa {
  
  // atributos
  public string Nome;
  public string Telefone;
  public string BirthdayDate;
  public int Idade;

  // métodos
  public boolean isBirthday(string todayDate){

    if(todayDate == BirthdayDate){
      FazAniversario();
      return true;
    }

    return false;
  }

  public void FazAniversario( ){
    Idade++;
  }

}
```
