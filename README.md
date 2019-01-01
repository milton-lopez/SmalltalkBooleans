# SmalltalkBooleans
A Smalltalk-like implementation of booleans in C#. Just for fun, not for actual use.

# Use

This is how you would evaluate a boolean expression in idiomatic C#:

```cs
    if (booleanExp && anotherBooleanExp)
    {
      // Code to handle true...
    }
    else
    {
      //Code to handle false...
    }
```


And this is how is done with a Smalltalk-like API:
    
```cs
    booleanExpression.And(anotherBooleanExp)
                     .IfTrue(() => //Code to handle true...)
                     .IfFalse(() => //Code to handle false...);
```

# Example

```cs
   var number = 15;
   
   (number % 3 == 0).And(number % 5 == 0)
                             .IfTrue(() => Console.WriteLine("Number is divisible by 15"))
                             .IfFalse(() => Console.WriteLine("Number is not divisible by 15"));
```
