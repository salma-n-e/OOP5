using System.ComponentModel.Design;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q 1
            // a) Only the reference is copied, not the actual object data.
            //  Both variables now point to the exact same memory location on the Heap.
            // b) No. It does not allocate new memory or create a new object. Any modification
            // made through one variable will directly affect the other variable because they reference the same object.
            // c) Copying a Reference: Copies only the pointer/address to the existing object.
            // No new object is created on the Heap.
            // Copying an Object: Allocates memory on the Heap and creates a new object containing duplicate values
            // from the original object.

            // Q 2
            // a) A Shallow Copy creates a new object, but copies only the top-level fields.
            // Primitive values are copied by value, while reference-type fields are copied as references 
            //  b)A Deep Copy creates a new object and recursively creates new copies of all nested objects/reference types,
            //  resulting in complete independence between the original and copied objects.
            // c) Their references  are copied, meaning both the original
            // and shallow-copied objects will share the exact same nested objects in memory.
            // d) Entirely new instances of the reference-type members are instantiated in memory,
            // copying their internal values so no references are shared.
            // e)  When an object contains nested complex structures ,
            // and you want to modify the cloned order's item details without affecting the original order's data.

            // Q 3 
            // a) A static field belongs to the Class itself and is shared across all instances (objects) in a single memory location.
            // An instance field belongs to a specific Object and each created object has its own separate copy of that field. 
            // b) A static method belongs to the class and can be called directly using the class name without
            // creating an instance.
            // No, a static method cannot directly access instance members (fields or methods)
            // because instance members require a specific object reference (this), which does not exist in a static
            // context.
            // c) A static constructor is used to initialize static data or perform actions required only once.
            // It is executed automatically before the first instance is created or any static members are referenced.
            // It takes no access modifiers or parameters and executes only once per application run.
            // d) A static class is a class that contains only static members and cannot be instantiated.
            // No, you cannot create an object from a static class (using the new keyword is prohibited).

            // Q 4
            // a) An extension method is a special kind of static method that enables you to "add"
            // new methods to existing types (like string, int, or custom classes) without modifying
            // the original code, inheriting from it, or recompiling it. 
            // b) The this keyword must precede the first parameter.
            // c) It must be declared inside a non-generic static class.
            // d) No, an extension method cannot access private or protected
            // members of the extended class. It can only access its public members.

            // Q 5
            // a) A Partial Class allows the definition/implementation of a single class
            // to be split across multiple physical .cs files using the partial keyword.
            // When compiled, all parts are combined into one single class.
            // b) To allow multiple developers to work on different parts of the same class simultaneously without merge conflicts.
            // To separate auto - generated code(like UI designers or database entities) from custom user code.
            //To organize large classes into cleaner, more manageable files based on features.
            // c) A Partial Method is a method declared in one part of a partial class and optionally implemented in another
            // part of the same partial class. It must return void and cannot have access modifiers (implicitly private).
            // d) The C# compiler completely removes the method declaration and all calls to it during compilation.
            // There is no performance penalty or runtime overhead.
        }
    }
}
