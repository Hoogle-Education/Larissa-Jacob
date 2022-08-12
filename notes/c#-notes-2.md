# Herança

```c#
public class Rectangle {
  
  public double Altura {get; set;}
  public double Comprimento {get; set;}
  
  public Rectangle(double altura, double comprimento) {
    Altura = altura;
    Comprimento = comprimento;
  }

}
```

```c#
public class Square : Rectangle {

  public Square(double lado) {
    base(lado, lado);
  }


}
```