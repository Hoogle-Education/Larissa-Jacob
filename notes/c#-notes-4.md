# Generics

```c#
pubblic class PrintService<T> {

  private List<T> _contents;

  public PrintService() {
    _contents = new List<>();
  }

  public void Add(T item) {
    _contents.Add(item);
  }

  public void Print() {
    foreach(T item in _contents) {
      Console.WriteLine(item);
    }
  }
}
```

## Aplicando o generics

```c#
public class Program {
  public static void Main() {

    PrintService<string> service = new PrintService<>();

  }
}
```


```c#
public interface ICrud<TEntity, TKey> {

  void Save(TEntity entiy);
  Optional<TEntity> FindById(Tkey key);

}

public interface UserRepository : ICrud<User, Long> {

}


```