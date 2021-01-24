using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace obfusarbugtest
{
	[System.Reflection.Obfuscation]
    class Program
    {
		[System.Reflection.Obfuscation]
		static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cls = new TestClass<string, string>();
            //cls.Add("", "");
			cls.Add("", new WeakReference<string>(""));

			//cls.Add(new KeyValuePair<string,WeakReference<string>>(null, null));
        }
    }
	internal class TestClass<TKey, TValue> : IDictionary<TKey, WeakReference<TValue>> where TValue : class
	{



		public WeakReference<TValue> this[TKey key]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();

			}
		}

		public ICollection<TKey> Keys => throw new NotImplementedException();


		public ICollection<WeakReference<TValue>> Values => throw new NotImplementedException();

		public int Count => throw new NotImplementedException();


		public bool IsReadOnly => throw new NotImplementedException();

		public TestClass()
		{
		}


		public void AddToSaveList(TValue value)
		{
			throw new NotImplementedException();
		}

		public void RemoveFromSaveList(TValue value)
		{
			throw new NotImplementedException();
		}

		public void ClearSaveList()
		{
			throw new NotImplementedException();
		}

		public void SetKeyValue(TKey key, TValue value)
		{
			throw new NotImplementedException();
		}

		public void Add(TKey key, TValue value)
		{
			throw new NotImplementedException();
		}

		public void Add(TKey key, WeakReference<TValue> value)
		{
			throw new NotImplementedException();
		}

		public void Add(KeyValuePair<TKey, WeakReference<TValue>> item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(KeyValuePair<TKey, WeakReference<TValue>> item)
		{
			throw new NotImplementedException();
		}

		public bool ContainsKey(TKey key)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(KeyValuePair<TKey, WeakReference<TValue>>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<TKey, WeakReference<TValue>>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public bool Remove(TKey key)
		{
			throw new NotImplementedException();
		}

		public bool Remove(KeyValuePair<TKey, WeakReference<TValue>> item)
		{
			throw new NotImplementedException();
		}

		public bool TryGetValue(TKey key, out WeakReference<TValue> value)
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
