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
            // 
        }
    }
}
