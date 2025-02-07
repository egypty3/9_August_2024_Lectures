namespace C_Sharp_Lect7_Web.Models
{
    public class SampleGenericArray<T>
    {
        private T[] array;

        // Constructor - create an array of the specified size
        public SampleGenericArray(int size)
        {
            array = new T[size];
        }

        // getMyItem - return the item at the specified index
        public T getMyItem(int index)
        {
            return array[index];
        }

        // setMyItem - set the item at the specified index
        public void setMyItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
