## Binary Search

- Binary search is a fundamental algorithm for searching for a specific target element in a sorted collection, such as an array. 
- It's a highly efficient algorithm with a time complexity of O(log n), where n is the number of elements in the collection.

**Binary Search Logic:**

1. **Initialization:**
   - Start with a sorted collection of elements (e.g., an array) and a target element you want to find.
   - Initialize two pointers: `left` and `right`. `left` points to the first element in the collection, and `right` points to the last element in the collection.

2. **Midpoint Calculation:**
   - Calculate the midpoint index as `mid = left + (right - left) / 2`.

3. **Comparison:**
   - Compare the element at the midpoint (`arr[mid]`) with the target element you want to find.

4. **Three Possible Cases:**
   - If `arr[mid]` is equal to the target element, you've found the element, and you can return its index (or do whatever you need with it).
   - If `arr[mid]` is greater than the target element, it means the target element must be on the left side of the `mid`. In this case, update `right` to `mid - 1`.
   - If `arr[mid]` is less than the target element, it means the target element must be on the right side of the `mid`. In this case, update `left` to `mid + 1`.

5. **Repeat Until Found or Invalid:**
   - Repeat steps 2-4 until `left` is greater than `right`. If you find the target element, return its index. If `left` becomes greater than `right`, it means the element is not in the collection.

**Example:**
Let's say you want to find the index of the target element `7` in a sorted array:

```csharp
int[] arr = { 1, 3, 5, 7, 9, 11, 13 };
int target = 7;

int left = 0;
int right = arr.Length - 1;

while (left <= right)
{
    int mid = (left + right) / 2;

    if (arr[mid] == target)
    {
        // Element found, return its index (mid)
        Console.WriteLine("Found at index " + mid);
        break;
    }
    else if (arr[mid] > target)
    {
        // Target is on the left side, update right
        right = mid - 1;
    }
    else
    {
        // Target is on the right side, update left
        left = mid + 1;
    }
}

// If left > right, element not found
if (left > right)
{
    Console.WriteLine("Element not found");
}
```

This binary search algorithm efficiently narrows down the search range by half in each iteration until the target element is found or until `left` is greater than `right`, indicating that the element is not in the collection. It's a powerful and efficient technique for searching in sorted data.