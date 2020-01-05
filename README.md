## Non-Primitive Types

**1. Classes**

A class combines related variables(fields) and function(methods)
```
            // Class              // Objects
            
            Person                  John
            Name: string            Mary
 Fields     Age: byte               Scott
            Height: float 
            Weight: byte  
            
            Walk()  
 Methods    Talk()
            Eat()
            Sleep()
```

- Declaring Clases
```
// Example 1
public class person
{
  public string Name;
  
  public void Introduce()
  {
    Console.WriteLine("Hi, my name is " + Name);
  }
}
```
```
// Example 2
public class Calculator
{
  public int Add(int a, int b)
  {
      return a + b;
  }
}
```

- Creating Objects
```
int number;
Person person = new Person();

var person = new Person();
person.Name = "Jackie";
person.Introduce();
```

- Static Modifier
```
// Example 1
public class Calculator
{
  public static int Add(int a, int b)
  {
      return a + b;
  }
}

// Example 2
int result = Calculator.Add(1, 2);
```
___

**2. Structs**

- Declaring Structs

```
public struct RgbColor
{
    public int Red;
    public int Green;
    public int Blue;
}
```
___

**3. Arrays**

An array is a data structure to store a collection of variables of the same type.

- Declaring Arrays
```
int number1;
int number2;
int number3;

int[] numbers = new int[3];
```

- Accessing Array Elements
```
// Example 1
int[] numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

// Exmaple 2
int[] numbers = new int[3] {1, 2, 3};
```
___

**4. Strings**

A string is a sequence of characters.

- Creating String
```
// using string Literals
string firstName = "Mosh";

// using string Concatenation
string name = firstName + " " + lastName;

// using string Format
string name = string.Format("{0} {1}", firstName, lastName);

// using string Join 
var name = new int[3] {1, 2, 3};
string list = string.Join(",", numbers);
```

- String Elements
```
string name = "Mosh";
char firstChar = name[0];
// name[0] = 'm';

// Strings are immutable: Once you create them you cannot change them.
```

- Escape Charaters

| Char | Description |
| --- | --- |
| \n | New Line |
| \t | Tab |
| \\ | Backslash |
| \' | Single Quotation Mark |
| \" | Double Quotation Mark |

- Verbatim Strings

Verbatim string is created using a special symbol @. @ is known as a verbatim identifier. If a string contains @ as a 
prefix followed by double quotes, then compiler identifies that string as a verbatim string and compile that string. 
The main advantage of @ symbol is to tell the string constructor to ignore escape characters and line breaks.
```
string path = "c:\\projects\\project1\\folder1";
string path = @"c:\\projects\\project1\\folder1";
```
___
**5. Enums**

An enum is a set of name/value pairs(constants).

```
const int RegularAirMail = 1;
const int RegularAirMail = 2;
const int Express = 3;

public enum ShippingMethod : byte
{
    RegularAirMail = 1;
    RegularAirMail = 2;
    Express = 3;
}

var method = ShippingMethod.Express;
```
___

**6. Reference Types and Value Types**

Structures
- Value Types
- Allocated on stack
- Memory allocation done automaticlly
- Immediately removed when out of scope

Classes
- Reference Types
- You need to allocate memory
- Memory allocated on heap
- Garbage collected by CLR
___

Next -> [Control Flow](https://github.com/JackieG19/Csharp-Control-Flow)
