# Тестирование 

**Тестирование проводиться с помощью библиотеки `BenchmarkDotNet`**

___

Строка подключения библиотеки в проект:
 ```
 dotnet add package BenchmarkDotNet
 ```

___

Для запуска теста используется метод:
```csharp
BenchmarkRunner.Run<TClass>();
```

Для тестирования класса, методы этого класса должны иметь модификатор доступа - **public**, и перед тестируемым методом должен быть указан атрибут `[Benchmark]`, а для отображения потребуемой методом памяти - `[MemoryDiagnoser]` 

___

Перед запуском теста следует учитывать:
+ Следует запускать проект в конфигурации **"Release"**
+ Для большей точности теста лучше выключить все остальные приложения, кроме текущего и стандартных процессов операционной системы.
+ Если для тестирования используется ноутбук, то лучше его подключить к электросети и использовать наиболее производительный режим.
___

Запуск программы:
```
dotnet run -c Release
```