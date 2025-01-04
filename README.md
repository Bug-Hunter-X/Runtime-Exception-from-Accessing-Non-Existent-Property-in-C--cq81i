# Runtime Exception from Accessing Non-Existent Property in C#

This code demonstrates a common, yet subtle, error in C#: accessing a non-existent property.  In C#, attempting to access a property that doesn't exist on a class won't trigger a compiler error. Instead, it results in a runtime `NullReferenceException` if not properly handled.

## The Problem

The `bug.cs` file shows a simple class with a property.  The `MyMethod` function attempts to access a property, `NonExistentProperty`, that is not defined. This will not cause a compiler error, but a runtime exception will occur when `MyMethod` is called.

## The Solution

The `bugSolution.cs` file provides a corrected version.  This solution demonstrates how to avoid the exception by adding the missing property and using null checks where appropriate to handle possible null values, thereby promoting more robust code.
