namespace Data.Structure.Arrays
{
    public interface IDynamicArray
    {
        //insert
        void Insert(int value);

        //delete
        void Delete(int value);

        //Contains
        bool Contains(int value);

        //indexOf
        int IndexOf(int value);

        //Largest number.
        int Max();

        //return the common items in this array and another array
        int[] CommonItems(int[] values);

        //Array.reverse
        int[] Reverse();

        //Insert an item at a given index
        void InsertAt(int index);

        void Print();
    }
}