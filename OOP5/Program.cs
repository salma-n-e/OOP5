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
        }
    }
}
