# 📋 Arrays in C#

## 1. What is an Array?

An **Array** is a collection of elements of the **same data type** stored under one variable name.

Example:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

Instead of creating separate variables:

```csharp
int n1 = 10;
int n2 = 20;
int n3 = 30;
int n4 = 40;
int n5 = 50;
```

We can use one array:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

---

# 2. Why do we use Arrays?

Arrays are useful when we need to store **multiple values of the same type**.

Example:

```csharp
int[] employeeIds = { 101, 102, 103, 104, 105 };
```

Instead of creating many variables, we can store them together.

### Main advantages

* Store multiple values
* Easy to access using index
* Fast access to an element
* Useful for searching and sorting
* Important foundation for DSA

---

# 3. When do we use Arrays?

Use an array when:

* You know the number of elements.
* You want fast access using index.
* You are working with a fixed-size collection.
* You need to process multiple values using loops.

Example:

```csharp
int[] marks = new int[5];
```

Here the array can store **5 integers**.

---

# 4. Array Index

Array indexing starts from **0**.

Example:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

| Index | Value |
| ----: | ----: |
|     0 |    10 |
|     1 |    20 |
|     2 |    30 |
|     3 |    40 |
|     4 |    50 |

Access an element:

```csharp
Console.WriteLine(numbers[0]);
```

Output:

```text
10
```

Another example:

```csharp
Console.WriteLine(numbers[3]);
```

Output:

```text
40
```

---

# 5. Creating an Array

## Method 1 — Direct Values

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

## Method 2 — Using `new`

```csharp
int[] numbers = new int[5];
```

Default values:

```text
0  0  0  0  0
```

Then values can be assigned:

```csharp
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;
```

---

# 6. Traversing an Array

Traversal means **visiting each element of the array**.

### Using `for` loop

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

Output:

```text
10
20
30
40
50
```

### Time Complexity

```text
O(n)
```

Because the loop visits all `n` elements.

---

# 7. `Length`

`Length` tells us how many elements are present in the array.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers.Length);
```

Output:

```text
5
```

---

# 8. Accessing an Element

Accessing an array element using its index is very fast.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers[3]);
```

Output:

```text
40
```

### Time Complexity

```text
O(1)
```

Why?

Because we directly access the element using its index.

```text
numbers[3]
    ↓
Directly get the value
```

We don't need to check all elements.

---

# 9. Updating an Element

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

numbers[2] = 100;

Console.WriteLine(numbers[2]);
```

Output:

```text
100
```

### Time Complexity

```text
O(1)
```

---

# 10. Searching in an Array

## Linear Search

If the array is not sorted, we can check elements one by one.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

int target = 40;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == target)
    {
        Console.WriteLine($"Found at index {i}");
        break;
    }
}
```

### Time Complexity

```text
O(n)
```

Worst case:

The target could be at the last position or not present.

---

# 11. Finding the Largest Element

```csharp
int[] numbers = { 10, 50, 20, 80, 30 };

int largest = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }
}

Console.WriteLine(largest);
```

Output:

```text
80
```

### Complexity

```text
Time: O(n)
Space: O(1)
```

---

# 12. Finding the Smallest Element

```csharp
int[] numbers = { 10, 50, 20, 80, 30 };

int smallest = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < smallest)
    {
        smallest = numbers[i];
    }
}

Console.WriteLine(smallest);
```

Output:

```text
10
```

### Complexity

```text
Time: O(n)
Space: O(1)
```

---

# 13. Reversing an Array

Example:

```text
Before:

10 20 30 40 50

After:

50 40 30 20 10
```

C#:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

int left = 0;
int right = numbers.Length - 1;

while (left < right)
{
    int temp = numbers[left];

    numbers[left] = numbers[right];
    numbers[right] = temp;

    left++;
    right--;
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

### Complexity

```text
Time: O(n)
Space: O(1)
```

---

# 14. Array Operations & Complexity

| Operation       | Time Complexity |
| --------------- | --------------: |
| Access by index |            O(1) |
| Update by index |            O(1) |
| Search          |            O(n) |
| Traversal       |            O(n) |
| Find Max        |            O(n) |
| Find Min        |            O(n) |
| Reverse         |            O(n) |

---

# 15. Array vs List

| Array                        | List                   |
| ---------------------------- | ---------------------- |
| Fixed size                   | Dynamic size           |
| `int[]`                      | `List<int>`            |
| Size is fixed after creation | Can grow/shrink        |
| Fast index access            | Fast index access      |
| Good when size is known      | Good when size changes |

Example Array:

```csharp
int[] numbers = new int[5];
```

Example List:

```csharp
List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
```

---

# 16. Important Array Concepts for DSA

After basic arrays, these concepts are important:

* Traversal
* Searching
* Sorting
* Reverse
* Two Pointers
* Sliding Window
* Prefix Sum
* Kadane's Algorithm
* Frequency Counting
* Array Rotation
* Duplicate Detection
* Missing Number

---

# 🎯 Interview Questions

### Q1. What is an Array?

An array is a collection of elements of the same data type stored under one variable name.

### Q2. Why does array indexing start from 0?

The first element is represented by index `0`.

### Q3. What is the time complexity of accessing an array element?

```text
O(1)
```

Because we can directly access an element using its index.

### Q4. What is the time complexity of searching an unsorted array?

```text
O(n)
```

Because we may need to check every element.

### Q5. What is the difference between Array and List?

Array has a fixed size, while `List<T>` is dynamic and can grow or shrink.

---

# 🧠 Remember

```text
Array
  ↓
Same Data Type
  ↓
Index starts from 0
  ↓
Fast Access
  ↓
Access = O(1)
  ↓
Search = O(n)
  ↓
Traversal = O(n)
```

---

# 🏆 Array Practice Levels

## 🟢 Level 1 — Basics

* Print all elements
* Find length
* Access element
* Update element
* Find sum

## 🟡 Level 2 — Easy

* Find largest
* Find smallest
* Reverse array
* Count even and odd numbers
* Find second largest
* Check if array is sorted

## 🟠 Level 3 — Medium

* Remove duplicates
* Move zeros to the end
* Rotate array
* Two Sum
* Missing Number
* Majority Element

## 🔴 Level 4 — Advanced

* Maximum Subarray
* Merge Intervals
* Product of Array Except Self
* Longest Consecutive Sequence

## 👑 Array Boss

Solve array problems by first thinking about:

```text
Brute Force
     ↓
Better Approach
     ↓
Optimal Approach
     ↓
Time Complexity
     ↓
Space Complexity
```

---
